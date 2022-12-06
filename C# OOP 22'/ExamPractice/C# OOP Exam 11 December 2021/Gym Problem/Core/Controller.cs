using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Gym.Core.Contracts;
using Gym.Models.Athletes;
using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms;
using Gym.Models.Gyms.Contracts;
using Gym.Repositories;
using Gym.Utilities.Messages;


namespace Gym.Core
{
    public class Controller : IController
    {
        private EquipmentRepository equipments;
        private List<IGym> gyms;

        public Controller()
        {
            this.equipments = new EquipmentRepository();
            this.gyms = new List<IGym>();
        }

        public string AddGym(string gymType, string gymName)
        {
            IGym gym = null;
             
            switch (gymType)
            {
                case "BoxingGym":
                    gym = new BoxingGym(gymName);
                    break;
                case "WeightliftingGym":
                    gym = new WeightliftingGym(gymName);
                    break;
                default:
                    throw new InvalidOperationException(ExceptionMessages.InvalidGymType);
            }

            this.gyms.Add(gym);

            return string.Format(OutputMessages.SuccessfullyAdded, gymType);
        }

        public string AddEquipment(string equipmentType)
        {
            IEquipment equipment = null;

            switch (equipmentType)
            {
                case "BoxingGloves":
                    equipment = new BoxingGloves();
                    break;
                case "Kettlebell":
                    equipment = new Kettlebell();
                    break;
                default:
                    throw new InvalidOperationException(ExceptionMessages.InvalidEquipmentType);
            }

            this.equipments.Add(equipment);
            return string.Format(OutputMessages.SuccessfullyAdded, equipmentType);
        }

        public string InsertEquipment(string gymName, string equipmentType)
        {
            IGym gym = this.gyms.Find(x => x.Name == gymName);

            IEquipment equipment = this.equipments.FindByType(equipmentType);

            if (equipment == null)
                throw new InvalidOperationException(string.Format(ExceptionMessages.InexistentEquipment, equipmentType));

            gym.AddEquipment(equipment);
            this.equipments.Remove(equipment);

            return string.Format(OutputMessages.EntityAddedToGym, equipmentType, gymName);

        }
        public string AddAthlete(string gymName, string athleteType, string athleteName, string motivation, int numberOfMedals)
        {
            IGym gym = this.gyms.Find(x => x.Name == gymName);

            IAthlete athlete = null;

            switch (athleteType)
            {
                case "Boxer":
                    if (gym.GetType().Name != "BoxingGym")
                    {
                        return OutputMessages.InappropriateGym;
                    }

                    athlete = new Boxer(athleteName, motivation, numberOfMedals);
                    break;
                case "Weightlifter":
                    if (gym.GetType().Name != "WeightliftingGym")
                    {
                        return OutputMessages.InappropriateGym;
                    }

                    athlete = new Weightlifter(athleteName, motivation, numberOfMedals);
                    break;
                default:
                    throw new InvalidOperationException(ExceptionMessages.InvalidAthleteType);
            } 


            gym.AddAthlete(athlete);

            return string.Format(OutputMessages.EntityAddedToGym, athleteType, gymName);
        }

        public string TrainAthletes(string gymName)
        {
            IGym gym = this.gyms.Find(x => x.Name == gymName);

            gym.Exercise();

            return string.Format(OutputMessages.AthleteExercise, gym.Athletes.Count);
        }
        public string EquipmentWeight(string gymName)
        {
            IGym gym = this.gyms.Find(x => x.Name == gymName);

            return string.Format(OutputMessages.EquipmentTotalWeight, gymName, gym.EquipmentWeight);
        }
        public string Report()
        {
            var sb = new StringBuilder();

            foreach (var gym in this.gyms)
            {
                sb.AppendLine(gym.GymInfo());
            }

            return sb.ToString().TrimEnd();
        }
    }
}

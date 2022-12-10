namespace ChristmasPastryShop.Core
{
    using System.Linq;
    using System.Text;
    using ChristmasPastryShop.Core.Contracts;
    using ChristmasPastryShop.Models.Booths;
    using ChristmasPastryShop.Models.Booths.Contracts;
    using ChristmasPastryShop.Models.Cocktails;
    using ChristmasPastryShop.Models.Cocktails.Contracts;
    using ChristmasPastryShop.Models.Delicacies;
    using ChristmasPastryShop.Models.Delicacies.Contracts;
    using ChristmasPastryShop.Repositories;
    using ChristmasPastryShop.Repositories.Contracts;
    using ChristmasPastryShop.Utilities.Messages;

    public class Controller : IController
    {
        private IRepository<IBooth> boothRepository;

        public Controller()
        {
            this.boothRepository = new BoothRepository();
        }

        public string AddBooth(int capacity)
        {
            int boothId = this.boothRepository.Models.Count + 1;

            IBooth booth = new Booth(boothId, capacity);

            this.boothRepository.AddModel(booth);

            return string.Format(OutputMessages.NewBoothAdded, boothId, capacity);
        }

        public string AddDelicacy(int boothId, string delicacyTypeName, string delicacyName)
        {
            if (delicacyTypeName != nameof(Gingerbread) &&
                delicacyTypeName != nameof(Stolen))
            {
                return string.Format(OutputMessages.InvalidDelicacyType, delicacyTypeName);
            }

            if (this.boothRepository.Models.Any(x => x.DelicacyMenu.Models.Any(x => x.Name == delicacyName)))
            {
                return string.Format(OutputMessages.DelicacyAlreadyAdded, delicacyName);
            }

            IDelicacy delicacy = null;

            switch (delicacyTypeName)
            {
                case "Stolen":
                    delicacy = new Stolen(delicacyName);
                    break;
                case "Gingerbread":
                    delicacy = new Gingerbread(delicacyName);
                    break;
            }

            var booth = this.boothRepository.Models.FirstOrDefault(x => x.BoothId == boothId);

            booth.DelicacyMenu.AddModel(delicacy);

            return string.Format(OutputMessages.NewDelicacyAdded, delicacyTypeName, delicacyName);
        }


        public string AddCocktail(int boothId, string cocktailTypeName, string cocktailName, string size)
        {
            if (cocktailTypeName != nameof(Hibernation)
                && cocktailTypeName != nameof(MulledWine))
            {
                return string.Format(OutputMessages.InvalidCocktailType, cocktailTypeName);
            }

            if (size != "Small" && size != "Middle" && size != "Large")
            {
                return string.Format(OutputMessages.InvalidCocktailSize, size);
            }

            if (this.boothRepository.Models.Any(x => x.CocktailMenu.Models.Any(x => x.Name == cocktailName && x.Size == size)))
            {
                return string.Format(OutputMessages.CocktailAlreadyAdded, size, cocktailName);
            }

            var booth = this.boothRepository.Models.FirstOrDefault(x => x.BoothId == boothId);

            ICocktail cocktail = null;

            switch (cocktailTypeName)
            {
                case "Hibernation":
                    cocktail = new Hibernation(cocktailName, size);
                    break;
                case "MulledWine":
                    cocktail = new MulledWine(cocktailName, size);
                    break;
            }

            booth.CocktailMenu.AddModel(cocktail);

            return string.Format(OutputMessages.NewCocktailAdded, size, cocktailName, cocktailTypeName);
        }

        public string ReserveBooth(int countOfPeople)
        {
            var booths = this.boothRepository.Models.Where(x => x.IsReserved == false
             && x.Capacity >= countOfPeople).ToList();

            booths = booths.OrderBy(x => x.Capacity).ThenByDescending(x => x.BoothId).ToList();

            if (!booths.Any())
            {
                return string.Format(OutputMessages.NoAvailableBooth, countOfPeople);
            }

            IBooth booth = booths.First();
            booth.ChangeStatus();

            return string.Format(OutputMessages.BoothReservedSuccessfully, booth.BoothId, countOfPeople);
        }

        public string TryOrder(int boothId, string order)
        {
            var tokens = order.Split("/", System.StringSplitOptions.RemoveEmptyEntries);

            var itemTypeName = tokens[0];
            string itemName = tokens[1];
            int pieces = int.Parse(tokens[2]);

            if (itemTypeName != nameof(MulledWine) && itemTypeName != nameof(Hibernation)
                && itemTypeName != nameof(Gingerbread) && itemTypeName != nameof(Stolen))
            {
                return string.Format(OutputMessages.NotRecognizedType, itemTypeName);
            }


            if (itemTypeName == nameof(MulledWine) || itemTypeName == nameof(Hibernation))
            {
                string size = tokens[3];

                ICocktail cocktail = null;


                switch (itemTypeName)
                {
                    case "Hibernation":
                        cocktail = new Hibernation(itemName, size);
                        break;
                    case "MulledWine":
                        cocktail = new MulledWine(itemName, size);
                        break;
                }

                var booth = this.boothRepository.Models.FirstOrDefault(x => x.BoothId == boothId);

                if (!booth.CocktailMenu.Models.Any(x => x.GetType().Name == itemTypeName && x.Name == cocktail.Name && x.Size == size))
                {
                    return string.Format(OutputMessages.CocktailStillNotAdded, size, itemName);
                }



                booth.UpdateCurrentBill(cocktail.Price * pieces);

                return string.Format(OutputMessages.SuccessfullyOrdered, booth.BoothId, pieces, itemName);
            }
            else if (itemTypeName == nameof(Gingerbread) || itemTypeName == nameof(Stolen))
            {
                IDelicacy delicacy = null;

                switch (itemTypeName)
                {
                    case "Stolen":
                        delicacy = new Stolen(itemName);
                        break;
                    case "Gingerbread":
                        delicacy = new Gingerbread(itemName);
                        break;
                }

                var booth = this.boothRepository.Models.FirstOrDefault(x => x.BoothId == boothId);

                if (!booth.DelicacyMenu.Models.Any(x => x.GetType().Name == itemTypeName && x.Name == delicacy.Name))
                {
                    return string.Format(OutputMessages.DelicacyStillNotAdded, itemTypeName, itemName);
                }
                booth.UpdateCurrentBill(delicacy.Price * pieces);

                return string.Format(OutputMessages.SuccessfullyOrdered, booth.BoothId, pieces, itemName);

            }

            return null;
        }


        public string BoothReport(int boothId)
        {
            IBooth booth = this.boothRepository.Models.FirstOrDefault(x => x.BoothId == boothId);

            return booth.ToString();
        }

        public string LeaveBooth(int boothId)
        {
            IBooth booth = this.boothRepository.Models.FirstOrDefault(x => x.BoothId == boothId);

            double currentBill = booth.CurrentBill;

            booth.Charge();


            booth.ChangeStatus();

            var sb = new StringBuilder();

            sb
                .AppendLine($"Bill {currentBill:f2} lv")
                .AppendLine($"Booth {boothId} is now available!");

            return sb.ToString().TrimEnd();
        }

    }
}

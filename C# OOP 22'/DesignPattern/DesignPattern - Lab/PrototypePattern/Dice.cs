namespace PrototypePattern
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

     
    public class Dice : ICloneable
    {
        public Dice(int id)
        {
            this.Id = id;
            Console.WriteLine("Initializing..");
        }
        public Side Side { get; set; }

        public int Id { get; set; }

        public object Clone()
        {
            return DeepCloner.DeepClone(this);

            //Deep copy
            //return new Dice(Id)
            //{
            //    Side = new Side()
            //    {
            //        Number = Side.Number,
            //        Occurs = Side.Occurs
            //    }
            //};
        }

        //public object Clone()
        //{
        //    //ShallowCopy 
        //    // return new Dice(Id) { Side = Side };
        //    //ShallowCopy
        //    return MemberwiseClone();
        //}
    }
}

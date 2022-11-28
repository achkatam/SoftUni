namespace PrototypePattern
{
    using Newtonsoft.Json;
    using System;


    //[Serializable]
    public class DeepCloner
    {

        // Deep clone
        public static T DeepClone<T>(T a)
        {
            //using JSon 
            var obj = JsonConvert.SerializeObject(a);

            return JsonConvert.DeserializeObject<T>(obj);

            //Dice and Side should be Serialized
            //using (MemoryStream stream = new MemoryStream())
            //{
            //    BinaryFormatter formatter = new BinaryFormatter();
            //    formatter.Serialize(stream, a);
            //    stream.Position = 0;
            //    return (T)formatter.Deserialize(stream);
            //}
        }

    }
}

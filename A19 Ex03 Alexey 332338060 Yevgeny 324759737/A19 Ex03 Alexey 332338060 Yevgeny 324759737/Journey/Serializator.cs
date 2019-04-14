
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    public class Serializator
    {

        public static T DeepClone <T> ( T i_ToClone)
            where T : class
        {
            using (Stream stream = new MemoryStream())
            {
                BinaryFormatter service = new BinaryFormatter();
                service.Serialize(stream, i_ToClone);
                stream.Flush();
                stream.Seek(0, SeekOrigin.Begin);
                T duplicate = service.Deserialize(stream) as T;

                return duplicate;
            }

        }






    }
}

using System.Runtime.Serialization.Formatters.Binary;

namespace LibExample.Single_responsibility_principle.After
{
    public class ManBinary
    {
        public bool BinarySerialization(string fileName = "Man.bin")
        {
            bool result = false;
            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, this);
                result = true;
            }
            return result;
        }

        public static Man BinaryDeserialization(string fileName = "Man.bin")
        {
            Man result = null;
            using (FileStream stream = new FileStream(fileName, FileMode.Open))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                result = binaryFormatter.Deserialize(stream) as Man;
            }
            return result;
        }
    }
}

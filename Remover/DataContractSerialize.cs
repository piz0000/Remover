using System.IO;
using System.Runtime.Serialization;

namespace Remover
{
    public static partial class DataContractSerialize
    {
        public static bool WriteObject<T>(ref T data, string path)
        {
            using (Stream streamWriter = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write, 4096, FileOptions.Asynchronous))
            {
                try
                {
                    DataContractSerializer xml = new DataContractSerializer(data.GetType());

                    xml.WriteObject(streamWriter, data);

                    streamWriter.Close();

                    return true;
                }
                catch
                {
                    streamWriter.Close();

                    throw;
                }
            }
        }

        public static bool ReadObject<T>(ref T data, string path)
        {
            if (File.Exists(path) == false)            
                return false;            

            using (Stream streamReader = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.Asynchronous))
            {
                try
                {
                    DataContractSerializer xmlSerializer = new DataContractSerializer(data.GetType());

                    data = (T)xmlSerializer.ReadObject(streamReader);

                    streamReader.Close();

                    return true;
                }
                catch
                {
                    streamReader.Close();

                    throw;
                }
            }
        }

    }
}

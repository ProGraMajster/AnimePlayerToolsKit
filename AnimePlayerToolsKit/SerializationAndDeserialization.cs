using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayerToolsKit
{
    public static class SerializationAndDeserialization
    {
        public static object Deserialization(string path)
        {

            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            IFormatter formattter = new BinaryFormatter();
#pragma warning disable SYSLIB0011 // Typ lub składowa jest przestarzała
            object obj = formattter.Deserialize(stream);
#pragma warning restore SYSLIB0011 // Typ lub składowa jest przestarzała
            stream.Close();
            stream.Dispose();
            return obj;
        }

        public static void Serialization(object obj, string path)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
#pragma warning disable SYSLIB0011 // Typ lub składowa jest przestarzała
            formatter.Serialize(stream, obj);
#pragma warning restore SYSLIB0011 // Typ lub składowa jest przestarzała
            stream.Close();
            stream.Dispose();
        }

        public static object DeserializationJson(string path, Type type)
        {

            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            System.Runtime.Serialization.Json.DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(type);
            object obj = dataContractJsonSerializer.ReadObject(stream);
            stream.Close();
            stream.Dispose();
            return obj;
        }

        public static void SerializationJson(object obj, string path, Type type)
        {
            Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
            DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(type);
            dataContractJsonSerializer.WriteObject(stream, obj);
            stream.Close();
            stream.Dispose();
        }
    }
}

using ForestClicker.Model.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ForestClicker.Model.Serialization
{
    public class DataSerializer
    {
        public static void SerializeData(string fileName, DataModel data)
        {
            var serializer = new DataContractSerializer(typeof(DataModel));
            var stream = new FileStream(fileName, FileMode.Create);
            serializer.WriteObject(stream, data);
        }
        public static DataModel DeserializeItem(string fileName)
        {
            var serializer = new DataContractSerializer(typeof(DataModel));
            var stream = new FileStream(fileName, FileMode.Open);
            return (DataModel)serializer.ReadObject(stream);
        }
    }
}

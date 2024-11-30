using ForestClicker.Model.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace ForestClicker.Model.Models
{
    [DataContract]
    public class DataModel
    {
        [DataMember]
        public IEnumerable<Forest> Forests { get; set; }

        [DataMember]
        public IEnumerable<Animal> Animals { get; set; }

        [DataMember]
        public IEnumerable<Poacher> Poachers { get; set; }

        public DataModel()
        {
            Forests = new List<Forest>
            {
                new Forest() {Image = "oak_forest", Type = "Oak Forest", Price = 3000, Bonus = 500, MaxCount = 4, Count = 0},
                new Forest() {Image = "birch_forest", Type = "Birch Forest", Price = 5000, Bonus = 900, MaxCount = 2, Count = 0},
                new Forest() {Image = "pine_forest", Type = "Pine Forest", Price = 7000, Bonus = 1200, MaxCount = 2, Count = 0},
            };

            Animals = new List<Animal>
            {
                new Animal() {Image = "fox", Name = "Fox", Price = 220, Bonus = 12, MaxCount = 22, Count = 0},
                new Animal() {Image = "wolf", Name = "Wolf", Price = 300, Bonus = 12, MaxCount = 15, Count = 0},
                new Animal() {Image = "rabbit", Name = "Rabbit", Price = 200, Bonus = 5, MaxCount = 30, Count = 0},
                new Animal() {Image = "bear", Name = "Bear", Price = 350, Bonus = 12, MaxCount = 18, Count = 0},
                new Animal() {Image = "squirrel", Name = "Squirrel", Price = 220, Bonus = 12, MaxCount = 28, Count = 0},
                new Animal() {Image = "monkey", Name = "Monkey", Price = 310, Bonus = 20, MaxCount = 19, Count = 0}
            };

            Poachers = new List<Poacher>
            {
                new Poacher() {Image = "poacher1", Name = "Poacher 1", Count = 20},
                new Poacher() {Image = "poacher2", Name = "Poacher 2", Count = 25},
                new Poacher() {Image = "poacher3", Name = "Poacher 3", Count = 18},
            };
        }

        public static string DataPath = "forestssssss.dat";

        public static DataModel Load()
        {
            if (File.Exists(DataPath))
            {
                return DataSerializer.DeserializeItem(DataPath);
            }

            return new DataModel();
        }

        public void Save()
        {
            DataSerializer.SerializeData(DataPath, this);
        }
    }
}

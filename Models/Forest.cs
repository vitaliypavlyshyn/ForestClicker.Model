using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ForestClicker.Model.Models
{
    [DataContract]
    public class Forest
    {
        [DataMember]
        public string Image { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public int Price { get; set; }
        [DataMember]
        public int Bonus { get; set; }
        [DataMember]
        public int MaxCount { get; set; }
        [DataMember]
        public int Count { get; set; }
    }
}

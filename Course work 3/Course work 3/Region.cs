using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ConsoleApplication1
{
    [DataContract]
    public class Region
    {
        [DataMember]
        public string country;
        [DataMember]
        public string name;
        [DataMember]
        public string id;
        public Region(string name, string country, string id) 
        {
            this.name = name;
            this.id = id;
            this.country = country;
        }

        public Region() : this("", "", "") { } 
    }
}
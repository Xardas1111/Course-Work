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
    public class Country
    {
        [DataMember]
        public string id;
        [DataMember]
        public string name;
        public Country() 
        {
            name = "";
            id = "";
        }
        public Country(string name, string id) 
        {
            this.name = name;
            this.id = id;
        }
    }
}
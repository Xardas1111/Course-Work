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
    public class Settlement
    {
        [DataMember]
        public string name;
        [DataMember]
        public string region;
        [DataMember]
        public string id;
        public Settlement(string name, string region, string id) 
        {
            this.name = name;
            this.region = region;
            this.id = id;
        }
        public Settlement() : this("", "", "") { }
    }
}

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
    public class OBject
    {
        [DataMember]
        public string name;
        [DataMember]
        public string id;
        [DataMember]
        public string settlement;
        public OBject() : this("", "", "") { }
        public OBject(string name, string id, string settlement) 
        {
            this.name = name;
            this.id = id;
            this.settlement = settlement;
        }
    }
}

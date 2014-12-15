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
    public class AccidentType
    {
        [DataMember]
        public string id;
        [DataMember]
        public string name;
        public AccidentType() 
        {
            name = "";
            id = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Course_work_3
{   
    [DataContract]
    public class Stage
    {
        [DataMember]
        public string name;
        [DataMember]
        public string id;
        public Stage() 
        {
            id = "";
            name = "";
        }
        public Stage(string name, string id) 
        {
            this.id = id;
            this.name = name;
        }
    }
}

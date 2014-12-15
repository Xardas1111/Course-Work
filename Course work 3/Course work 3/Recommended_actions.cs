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
    public class RecommendedActions
    {
        [DataMember]
        public string id;
        [DataMember]
        public string name;
        [DataMember]
        public string price;
        [DataMember]
        public string Description;
        [DataMember]
        public string Accident_Type_id;
        public RecommendedActions() : this("", "", "", "", "") { }
        public RecommendedActions(string name, string price, string Description, string Accident_Type_id, string id) 
        {
            this.name = name;
            this.price = price;
            this.Description = Description;
            this.Accident_Type_id = Accident_Type_id;
            this.id = id;
        }
    }
}

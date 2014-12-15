using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using ConsoleApplication1;

namespace Course_work_3
{
    [DataContract]
    public class RegData
    {
        [DataMember]
        public string stage;
        [DataMember]
        public List<RecommendedActions> action_list;
        public RegData() 
        {
            stage = "";
            action_list = new List<RecommendedActions>();
        }
        public RegData(string stage, List<RecommendedActions> action_list) 
        {
            this.stage = stage;
            this.action_list = action_list;
        }
    }
}

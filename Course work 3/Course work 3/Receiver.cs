using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ConsoleApplication1
{
    [DataContract]
    public class Receiver<T>
    {
        [DataMember]
        public List<T> data;
        [DataMember]
        public string table;
        public Receiver() 
        {
            data = new List<T>();
            table = "";
        }
    }
}

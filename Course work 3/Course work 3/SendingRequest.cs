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
    public class SendingRequest<T>
    {
        [DataMember]
        public string request;
        [DataMember]
        public string table;
        [DataMember]
        public T data;
        public SendingRequest(string request, string table, T data) 
        {
            this.request = request;
            this.table = table;
            this.data = data;
        }
    }
}
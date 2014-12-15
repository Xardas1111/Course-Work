using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ConsoleApplication1
{
    [DataContract]
    public struct ExecutedAction
    {
        [DataMember]
        public string Date;
        [DataMember]
        public string Description;
        [DataMember]
        public string id;
        [DataMember]
        public string registration_form;
        public ExecutedAction(DateTime Date, string Description, string id, string registration_form)
        {
            this.Description = Description;
            this.Date = "" + Date.Year + "-" + Date.Month + "-" + Date.Day + "T" + Date.Hour + ":" + Date.Minute + ":" + Date.Second;
            this.id = id;
            this.registration_form = registration_form;
        }
        public ExecutedAction(string Date, string Description, string id, string registration_form)
        {
            this.Description = Description;
            this.Date = Date;
            this.id = id;
            this.registration_form = registration_form;
        }
    }
    [DataContract]
    public class RegistrationForm
    {
        [DataMember]
        public string id;
        [DataMember]
        public string stage_id;
        [DataMember]
        public string Object_id;
        [DataMember]
        public string Accident_Type_id;
        [DataMember]
        public string located_money;
        [DataMember]
        public string used_money;
        [DataMember]
        public string Date;
        [DataMember]
        public string Commentary;
        public RegistrationForm() 
        {
            id = "";
            stage_id = "";
            Object_id = "";
            Accident_Type_id = "";
            located_money = "";
            used_money = "";
            Date = "";
            Commentary = "";
        }
       
    }
}
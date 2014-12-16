using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Net;
using ConsoleApplication1;
using System.Diagnostics;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Course_work_3
{
    public partial class Form1 : Form
    {
        List<ExecutedAction> executedactionlist;
        List<RecommendedActions> recommendedactionlist;
        List<Country> countrylist;
        List<Region> regionlist;
        List<Settlement> settlementlist;
        List<OBject> objectlist;
        List<AccidentType> typelist;
        List<Stage> stagelist;
        public Form1()
        {
            InitializeComponent();
        }

        private void Discard_Click(object sender, EventArgs e)
        {
            Country.Text = "Country";
            Region.Text = "Region";
            Settlement.Text = "Settlement";
            Object.Text = "Object";
            Type_of_accident.Text = "Accident Type";
            Budget.Text = "Budget";
            Executed_action_text.Text = "";
            Description.Text = "Description of the accident";
            executedactionlist.Clear();
        }

        private void Check_Input(object sender, EventArgs e) 
        { 
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if ((Login.Text == "Admin" || Login.Text == "admin") && Pass.Text=="admin")
            {
                Login.Visible = false;
                Pass.Visible = false;
                LoginButton.Visible = false;
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            form.located_money = Budget.Text;
            form.Commentary = Description.Text;
            form.Date = Date.Value.Year + "-" + Date.Value.Month + "-" + Date.Value.Day + "T" + Date.Value.Hour + ":" + Date.Value.Minute + ":" + Date.Value.Second;
            string id = "";
            for (int i = 0; i < objectlist.Count; i++) 
            {
                if (Object.Text == objectlist[i].name)
                {
                    bool key = false;
                    for (int j = 0; j < settlementlist.Count; j++)
                    {
                        if (objectlist[i].settlement == settlementlist[j].id)
                        {
                            key = true;
                            id = objectlist[i].id;
                            break;
                        }
                    }
                    if (key) 
                    {
                        break;
                    }
                }
            }
            form.Object = id;
            for (int i = 0; i < typelist.Count; i++)
            {
                if (Type_of_accident.Text == typelist[i].name)
                {
                    id = typelist[i].id;
                    break;
                }
            }
            form.Accident_Type = id;
            int current_year = Convert.ToInt32(form.Date.Substring(0, 4));
            if (DateTime.Now.Year - current_year < 1) 
            {
                form.stage = "1";
            }
            else if (DateTime.Now.Year - current_year > 1)
            {
                form.stage = "3";
            }
            else 
            {
                form.stage = "2";
            }
            int summary = 0;
            for (int i = 0; i < executedactionlist.Count; i++) 
            {
                summary += Convert.ToInt32(executedactionlist[i].price);
            }
            form.used_money = Convert.ToString(summary);
            SendingRequest<RegistrationForm> request = new SendingRequest<RegistrationForm>("set", "RegistrationForm", form);
            Receiver<RegistrationForm> receiver = new Receiver<RegistrationForm>();
            ServerUpp<RegistrationForm, RegistrationForm>(request, ref receiver);
            form = receiver.data[0];
            for (int i = 0; i < executedactionlist.Count; i++) 
            {
                executedactionlist[i] = new ExecutedAction(executedactionlist[i].Date, executedactionlist[i].Description, "", form.id,executedactionlist[i].price);
                SendingRequest<ExecutedAction> req = new SendingRequest<ExecutedAction>("set", "ExecutedActions", executedactionlist[i]);
                Receiver<ExecutedAction> rec = new Receiver<ExecutedAction>();
                ServerUpp<ExecutedAction, ExecutedAction>(req, ref rec);
                executedactionlist[i] = rec.data[0];
            }
                if (DialogResult.Yes == MessageBox.Show("Event Registered!!1 Do you want to print a report?", "?", MessageBoxButtons.YesNo))
                {
                    PrintReport(form, Country.Text, Region.Text, Settlement.Text, Object.Text);
                }
            executedactionlist.Clear();
        }

        private void Add_action_Click(object sender, EventArgs e)
        {
            ExecutedAction action = new ExecutedAction();
            action.Date = Executed_action_date.Value.Year + "-" + Executed_action_date.Value.Month + "-" + Executed_action_date.Value.Day + "T" + Executed_action_date.Value.Hour + ":" + Executed_action_date.Value.Minute + ":" + Executed_action_date.Value.Second;
            action.Description = Executed_action_text.Text;
            action.price = Price.Text;
            executedactionlist.Add(action);
            Executed_action_text.Text = "";
            MessageBox.Show("Added a new action!", "Result", MessageBoxButtons.OK);
        }
        private void Country_changed(object sender, EventArgs e)
        {
            Region.Text = "";
            Region.Items.Clear();
            string id = "";
            for (int i=0;i<countrylist.Count;i++)
            {
                if (Country.Text == countrylist[i].name)
                {
                    id = countrylist[i].id;
                    break;
                }
            }
            for (int i = 0; i < regionlist.Count; i++) 
            {
                if (id == regionlist[i].country) 
                {
                    Region.Items.Add(regionlist[i].name);
                }
            }
        }

        private void ServerUpp<T, K>(SendingRequest<T> sending_data,ref Receiver<K> receiving_data) 
        {

            MemoryStream m1 = new MemoryStream();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SendingRequest<T>));
            js.WriteObject(m1, sending_data);
            WebRequest request = WebRequest.Create("http://25.115.249.50:8080");
            request.Method = "POST";
            byte[] byteArray = m1.ToArray();
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            WebResponse response = request.GetResponse();
            dataStream = response.GetResponseStream();
            js = new DataContractJsonSerializer(typeof(Receiver<K>));
            receiving_data = (Receiver<K>)js.ReadObject(dataStream);
            dataStream.Close();
            response.Close();
        }
        private void Region_changed(object sender, EventArgs e)
        {
            Settlement.Items.Clear();
            string id = "";
            for (int i = 0; i < regionlist.Count; i++)
            {
                if (Region.Text == regionlist[i].name)
                {
                    id = regionlist[i].id;
                    break;
                }
            }
            for (int i = 0; i < settlementlist.Count; i++)
            {
                if (id == settlementlist[i].region)
                {
                    Settlement.Items.Add(settlementlist[i].name);
                }
            }
        }
        private void Settlement_changed(object sender, EventArgs e)
        {
            Object.Items.Clear();
            string id = "";
            for (int i = 0; i < settlementlist.Count; i++)
            {
                if (Settlement.Text == settlementlist[i].name)
                {
                    id = settlementlist[i].id;
                    break;
                }
            }
            for (int i = 0; i < objectlist.Count; i++)
            {
                if (id == objectlist[i].settlement)
                {
                    Object.Items.Add(objectlist[i].name);
                }
            }
        }

        private void PrintReport(RegistrationForm form,string country, string region, string settlement, string ect) 
        {
            var boldfont = FontFactory.GetFont(FontFactory.TIMES_BOLD, 14);
            var font = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12);
            var doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("Report.pdf", FileMode.OpenOrCreate));
            doc.Open();
            doc.Add(new Phrase("Registered event №" + form.id + " :" + "\n", boldfont));
            doc.Add(new Phrase("Country: " + country + "\n", font));
            doc.Add(new Phrase("Region: " + region + "\n", font));
            doc.Add(new Phrase("Settlement: " + settlement + "\n", font));
            doc.Add(new Phrase("Object: " + ect + "\n", font));
            string type = "";
            for (int i = 0; i < typelist.Count; i++) 
            {
                if (form.stage == typelist[i].id)
                {
                    type = typelist[i].name;
                    break;
                }
            }
            string stage = "";
            for (int i = 0; i < stagelist.Count; i++)
            {
                if (form.stage == stagelist[i].id)
                {
                    stage = stagelist[i].name;
                    break;
                }
            }
            doc.Add(new Phrase("Stage: " + stage + "\n", font));
            doc.Add(new Phrase("Type: " + type + "\n", font));
            doc.Add(new Phrase("Located money: " + form.located_money + "\n", font));
            doc.Add(new Phrase("Used money: " + form.used_money + "\n", font));
            doc.Add(new Phrase("Time: "+ form.Date +"\n", font));
            doc.Add(new Phrase("Commentary: " + form.Commentary + "\n", font));
            doc.Add(new Phrase("Recommended Actions: " + "\n", boldfont));
            for (int i = 0; i < recommendedactionlist.Count; i++) 
            {
                if (form.Accident_Type == recommendedactionlist[i].Accident_Type)
                {
                    doc.Add(new Phrase("Next action: " + "\n", font));
                    doc.Add(new Phrase(recommendedactionlist[i].name + ":" + "\n", font));
                    doc.Add(new Phrase("Description:" + recommendedactionlist[i].Description + "\n", font));
                }
            }
            doc.Add(new Phrase("Executed Actions: " + "\n", boldfont));
            for (int i = 0; i < executedactionlist.Count; i++)
            {
                doc.Add(new Phrase("Next action: "+"\n", font));
                doc.Add(new Phrase("Date:" + executedactionlist[i].Date + "\n", font));
                doc.Add(new Phrase("Price:" + executedactionlist[i].price + "\n", font));
                doc.Add(new Phrase("Description:" + executedactionlist[i].Description + "\n", font));
            }
            doc.Close();
            Process.Start(@"Report.pdf");
        }

        private void Calcel_Click(object sender, EventArgs e)
        {
            executedactionlist.Clear();
            Executed_action_text.Text = "Actions erased. Ready for typing";
        }
        private void b_discard_Click(object sender, EventArgs e)
        {
            B_accident_type.Text = "Name";
        }

        private void b_find_Click(object sender, EventArgs e)
        {
            string type_id = "";
            for (int i = 0; i < typelist.Count; i++) 
            {
                if (B_accident_type.Text == typelist[i].name) 
                {
                    type_id = typelist[i].id;
                    MessageBox.Show("You have a match!", "Result.", MessageBoxButtons.OK);
                    break;
                }
            }
            if (type_id == "")
            {
                MessageBox.Show("Not a match!","Result",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            string accident_id = "";
            for (int i = 0; i < typelist.Count; i++)
            {
                if (B_accident_type.Text == typelist[i].name)
                {
                    accident_id = typelist[i].id;
                    break;
                }
            }
            if (accident_id == "")
            {
                MessageBox.Show("Type does not exist", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else 
            {
                ConsoleApplication1.AccidentType item = new AccidentType(B_accident_type.Text, accident_id);
                Receiver<AccidentType> object_receiver = new Receiver<ConsoleApplication1.AccidentType>();
                SendingRequest<AccidentType> object_sender = new SendingRequest<AccidentType>("delete", "AccidentType", item);
                ServerUpp<AccidentType, AccidentType>(object_sender, ref object_receiver);
                typelist.Remove(item);
                MessageBox.Show("Object added to the database", "!", MessageBoxButtons.OK);
                RefreshData();
                return;
            }
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            string accident_id = "";
            for (int i = 0; i < typelist.Count; i++) 
            {
                if (B_accident_type.Text == typelist[i].name) 
                {
                    accident_id = typelist[i].id;
                    break;
                }
            }
            if (accident_id != "")
            {
                MessageBox.Show("Type already exists", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else 
            {
                ConsoleApplication1.AccidentType item = new AccidentType(B_accident_type.Text,"");
                Receiver<AccidentType> object_receiver = new Receiver<ConsoleApplication1.AccidentType>();
                SendingRequest<AccidentType> object_sender = new SendingRequest<AccidentType>("set", "AccidentType", item);
                ServerUpp<AccidentType, AccidentType>(object_sender, ref object_receiver);
                typelist.Add(object_receiver.data[0]);
                MessageBox.Show("Object added to the database", "!", MessageBoxButtons.OK);
                RefreshData();
                return;
            }
        }
    }
}
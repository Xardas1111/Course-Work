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
    public partial class Form1
    {
        private void c_add_rec_Click(object sender, EventArgs e)
        {
            if (rec_act_accident_type.Text != "")
            {
                string accident_id = "";
                for (int i = 0; i < typelist.Count; i++)
                {
                    if (rec_act_accident_type.Text == typelist[i].name)
                    {
                        accident_id = typelist[i].id;
                    }
                }
                if (accident_id == "")
                {
                    MessageBox.Show("Such accident type does not exist", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (rec_act_desc.Text == "" || rec_act_name.Text == "")
                    {
                        MessageBox.Show("Some of the data is missing!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        RecommendedActions item = new RecommendedActions(rec_act_name.Text, rec_act_desc.Text, accident_id, "");
                        Receiver<RecommendedActions> object_receiver = new Receiver<RecommendedActions>();
                        SendingRequest<RecommendedActions> object_sender = new SendingRequest<RecommendedActions>("set", "RecommendedActions", item);
                        ServerUpp<RecommendedActions, RecommendedActions>(object_sender, ref object_receiver);
                        MessageBox.Show("Recommended Action has been added", "!", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("No accident type!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RefreshData();
        }

        private void c_delete_rec_Click(object sender, EventArgs e)
        {
            if (rec_act_accident_type.Text != "")
            {
                string accident_id = "";
                for (int i = 0; i < typelist.Count; i++)
                {
                    if (rec_act_accident_type.Text == typelist[i].name)
                    {
                        accident_id = typelist[i].id;
                    }
                }
                if (accident_id == "")
                {
                    MessageBox.Show("Such accident type does not exist", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (rec_act_desc.Text == "" || rec_act_name.Text == "")
                    {
                        MessageBox.Show("Some of the data is missing!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        string action_id = "";
                        for (int i = 0; i < recommendedactionlist.Count; i++)
                        {
                            if ((rec_act_desc.Text == recommendedactionlist[i].Description) && (rec_act_name.Text == recommendedactionlist[i].name) && (rec_act_accident_type.Text == recommendedactionlist[i].Accident_Type))
                            {
                                action_id = recommendedactionlist[i].id;
                                break;
                            }
                        }
                        if (action_id == "")
                        {
                            MessageBox.Show("Such action does not exist!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            RecommendedActions item = new RecommendedActions(rec_act_name.Text, rec_act_desc.Text, accident_id, action_id);
                            Receiver<RecommendedActions> object_receiver = new Receiver<RecommendedActions>();
                            SendingRequest<RecommendedActions> object_sender = new SendingRequest<RecommendedActions>("delete", "RecommendedActions", item);
                            ServerUpp<RecommendedActions, RecommendedActions>(object_sender, ref object_receiver);
                            MessageBox.Show("Recommended Action has been deleted", "!", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            else 
            {
                MessageBox.Show("No accident type!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RefreshData();
        }

        private void c_find_rec_Click(object sender, EventArgs e)
        {
            string accident = "";
            for (int i=0;i<typelist.Count;i++)
            {
                if (typelist[i].name == rec_act_accident_type.Text)
                {
                    accident = typelist[i].id;
                }
            }
            if ((accident == "") && (rec_act_accident_type.Text != ""))
            {
                MessageBox.Show("Such accident type does not exist!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var boldfont = FontFactory.GetFont(FontFactory.TIMES_BOLD, 14);
            var font = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12);
            var doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("Report.pdf", FileMode.OpenOrCreate));
            doc.Open();
            doc.Add(new Phrase("Matches found: \n", boldfont));
            for (int i = 0; i < recommendedactionlist.Count; i++) 
            {
                if ((recommendedactionlist[i].name == ((rec_act_name.Text != "") ? rec_act_name.Text : recommendedactionlist[i].name)) 
                    && (recommendedactionlist[i].Description == ((rec_act_desc.Text != "") ? rec_act_desc.Text : recommendedactionlist[i].Description))
                    && (recommendedactionlist[i].Accident_Type == ((rec_act_accident_type.Text != "") ? accident : recommendedactionlist[i].Accident_Type)))
                {
                    doc.Add(new Phrase("Match: \n", boldfont));
                    doc.Add(new Phrase(recommendedactionlist[i].name + ";\n", font));
                    doc.Add(new Phrase(recommendedactionlist[i].Description + ";\n", font));
                }
            }
            doc.Close();
        }

        private void c_discard_rec_Click(object sender, EventArgs e)
        {
            rec_act_accident_type.Text = "Accident Type";
            rec_act_desc.Text = "Description";
            rec_act_name.Text = "name";
        }

        private void RefreshData() 
        {
            Country.Items.Clear();
            Type_of_accident.Items.Clear();
            Region.Items.Clear();
            Settlement.Items.Clear();
            Object.Items.Clear();
            executedactionlist = new List<ExecutedAction>();
            countrylist = new List<ConsoleApplication1.Country>();
            Receiver<Country> country_receiver = new Receiver<ConsoleApplication1.Country>();
            SendingRequest<Country> country_sender = new SendingRequest<Country>("get", "Country", new Country());
            ServerUpp<Country, Country>(country_sender, ref country_receiver);
            countrylist = country_receiver.data;
            for (int i = 0; i < countrylist.Count; i++) 
            {
                Country.Items.Add(countrylist[i].name);
            }
            Receiver<Region> Region_receiver = new Receiver<ConsoleApplication1.Region>();
            SendingRequest<Region> Region_sender = new SendingRequest<Region>("get", "Region", new Region());
            ServerUpp<Region, Region>(Region_sender, ref Region_receiver);
            regionlist = Region_receiver.data;
            Receiver<Settlement> Settlement_receiver = new Receiver<ConsoleApplication1.Settlement>();
            SendingRequest<Settlement> Settlement_sender = new SendingRequest<Settlement>("get", "Settlement", new Settlement());
            ServerUpp<Settlement, Settlement>(Settlement_sender, ref Settlement_receiver);
            settlementlist = Settlement_receiver.data;
            Receiver<OBject> object_receiver = new Receiver<ConsoleApplication1.OBject>();
            SendingRequest<OBject> object_sender = new SendingRequest<OBject>("get", "Object", new OBject());
            ServerUpp<OBject, OBject>(object_sender, ref object_receiver);
            objectlist = object_receiver.data;
            Receiver<AccidentType> AccidentType_receiver = new Receiver<ConsoleApplication1.AccidentType>();
            SendingRequest<AccidentType> AccidentType_sender = new SendingRequest<AccidentType>("get", "AccidentType", new AccidentType());
            ServerUpp<AccidentType, AccidentType>(AccidentType_sender, ref AccidentType_receiver);
            typelist = AccidentType_receiver.data;
            for (int i = 0; i < typelist.Count; i++)
            {
                Type_of_accident.Items.Add(typelist[i].name);
            }
            Receiver<Stage> Stage_receiver = new Receiver<Stage>();
            SendingRequest<Stage> Stage_sender = new SendingRequest<Stage>("get", "Stage", new Stage());
            ServerUpp<Stage, Stage>(Stage_sender, ref Stage_receiver);
            stagelist = Stage_receiver.data;
            SendingRequest<RecommendedActions> req = new SendingRequest<RecommendedActions>("get", "RecommendedActions", new RecommendedActions());
            Receiver<RecommendedActions> rec = new Receiver<RecommendedActions>();
            ServerUpp<RecommendedActions, RecommendedActions>(req, ref rec);
            recommendedactionlist = rec.data;
            Discard_Click(null, null);
        }

    }
}
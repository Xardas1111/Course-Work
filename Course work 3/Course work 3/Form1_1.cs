﻿using System;
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
        private void A_add_Click(object sender, EventArgs e)
        {
            int action = 0;
            if (A_object.Text != "")
            {
                if (A_settlement.Text == "")
                {
                    MessageBox.Show("Need a settlement", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (A_region.Text == "")
                    {
                        MessageBox.Show("Need a region", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (A_country.Text == "")
                        {
                            MessageBox.Show("Need a country", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            action = 1;
                        }
                    }
                }
            }
            else
            {
                if (A_settlement.Text != "")
                {
                    if (A_region.Text == "")
                    {
                        MessageBox.Show("Need a region", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (A_country.Text == "")
                        {
                            MessageBox.Show("Need a country", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            action = 2;
                        }
                    }
                }
                else
                {
                    if (A_region.Text != "")
                    {
                        if (A_country.Text == "")
                        {
                            MessageBox.Show("Need a country", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            action = 3;
                        }
                    }
                    else
                    {
                        if (A_country.Text != "")
                        {
                            action = 4;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
            if (action == 1)
            {
                string country_id = "";
                for (int i = 0; i < countrylist.Count; i++)
                {
                    if (A_country.Text == countrylist[i].name)
                    {
                        country_id = countrylist[i].id;
                        break;
                    }
                }
                if (country_id != "")
                {
                    string region_id = "";
                    for (int i = 0; i < regionlist.Count; i++)
                    {
                        if ((A_region.Text == regionlist[i].name) && (country_id == regionlist[i].country))
                        {
                            region_id = regionlist[i].id;
                            break;
                        }
                    }
                    if (region_id != "")
                    {
                        string settlement_id = "";
                        for (int i = 0; i < settlementlist.Count; i++)
                        {
                            if ((A_settlement.Text == settlementlist[i].name) && (region_id == settlementlist[i].region))
                            {
                                settlement_id = settlementlist[i].id;
                                break;
                            }
                        }
                        if (settlement_id != "")
                        {
                            string object_id = "";
                            for (int i = 0; i < objectlist.Count; i++)
                            {
                                if ((A_object.Text == objectlist[i].name) && (settlement_id == objectlist[i].settlement))
                                {
                                    object_id = objectlist[i].id;
                                    break;
                                }
                            }
                            if (object_id != "")
                            {
                                MessageBox.Show("Object already exists", "Result", MessageBoxButtons.OK);
                                return;
                            }
                            else
                            {
                                ConsoleApplication1.OBject item = new OBject(A_object.Text, "", settlement_id);
                                Receiver<OBject> object_receiver = new Receiver<ConsoleApplication1.OBject>();
                                SendingRequest<OBject> object_sender = new SendingRequest<OBject>("set", "Object", item);
                                ServerUpp<OBject, OBject>(object_sender, ref object_receiver);
                                objectlist.Add(object_receiver.data[0]);
                                MessageBox.Show("Object added to the database", "!", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No such settlement in the database", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No such region in the database", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("No such country in the database", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (action == 2) 
            { 
                string country_id = "";
                for (int i = 0; i < countrylist.Count; i++)
                {
                    if (A_country.Text == countrylist[i].name)
                    {
                        country_id = countrylist[i].id;
                        break;
                    }
                }
                if (country_id != "")
                {
                    string region_id = "";
                    for (int i = 0; i < regionlist.Count; i++)
                    {
                        if ((A_region.Text == regionlist[i].name) && (country_id == regionlist[i].country))
                        {
                            region_id = regionlist[i].id;
                            break;
                        }
                    }
                    if (region_id != "")
                    {
                        string settlement_id = "";
                        for (int i = 0; i < settlementlist.Count; i++)
                        {
                            if ((A_settlement.Text == settlementlist[i].name) && (region_id == settlementlist[i].region))
                            {
                                settlement_id = settlementlist[i].id;
                                break;
                            }
                        }
                        if (settlement_id != "")
                        {
                           MessageBox.Show("Settlement already exists", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           return;
                        }
                        else
                        {
                            ConsoleApplication1.Settlement item = new Settlement(A_settlement.Text,region_id,"");
                            Receiver<Settlement> object_receiver = new Receiver<ConsoleApplication1.Settlement>();
                            SendingRequest<Settlement> object_sender = new SendingRequest<Settlement>("set", "Settlement", item);
                            ServerUpp<Settlement, Settlement>(object_sender, ref object_receiver);
                            settlementlist.Add(object_receiver.data[0]);
                            MessageBox.Show("Settlement added to the database", "!", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No such region in the database", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("No such country in the database", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (action == 3) 
            {
                string country_id = "";
                for (int i = 0; i < countrylist.Count; i++)
                {
                    if (A_country.Text == countrylist[i].name)
                    {
                        country_id = countrylist[i].id;
                        break;
                    }
                }
                if (country_id != "")
                {
                    string region_id = "";
                    for (int i = 0; i < regionlist.Count; i++)
                    {
                        if ((A_region.Text == regionlist[i].name) && (country_id == regionlist[i].country))
                        {
                            region_id = regionlist[i].id;
                            break;
                        }
                    }
                    if (region_id != "")
                    {
                        MessageBox.Show("Region already exists", "Fail", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        ConsoleApplication1.Region item = new Region(A_region.Text,country_id,"");
                        Receiver<Region> object_receiver = new Receiver<ConsoleApplication1.Region>();
                        SendingRequest<Region> object_sender = new SendingRequest<Region>("set", "Region", item);
                        ServerUpp<Region, Region>(object_sender, ref object_receiver);
                        regionlist.Add(object_receiver.data[0]);
                        MessageBox.Show("Region added to the database", "!", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("No such country in the database", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (action == 4) 
            {
                string country_id = "";
                for (int i = 0; i < countrylist.Count; i++)
                {
                    if (A_country.Text == countrylist[i].name)
                    {
                        country_id = countrylist[i].id;
                        break;
                    }
                }
                if (country_id != "")
                {
                    MessageBox.Show("Country already exists", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ConsoleApplication1.Country item = new Country(A_country.Text,"");
                    Receiver<Country> object_receiver = new Receiver<ConsoleApplication1.Country>();
                    SendingRequest<Country> object_sender = new SendingRequest<Country>("set", "Country", item);
                    ServerUpp<Country, Country>(object_sender, ref object_receiver);
                    countrylist.Add(object_receiver.data[0]);
                    MessageBox.Show("Country added to the database", "!", MessageBoxButtons.OK);
                }
            }
            RefreshData();
        }
        private void A_delete_Click(object sender, EventArgs e)
        {
            int action = 0;
            if (A_object.Text != "")
            {
                if (A_settlement.Text == "")
                {
                    MessageBox.Show("Need a settlement", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (A_region.Text == "")
                    {
                        MessageBox.Show("Need a region", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (A_country.Text == "")
                        {
                            MessageBox.Show("Need a country", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            action = 1;
                        }
                    }
                }
            }
            else
            {
                if (A_settlement.Text != "")
                {
                    if (A_region.Text == "")
                    {
                        MessageBox.Show("Need a region", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (A_country.Text == "")
                        {
                            MessageBox.Show("Need a country", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            action = 2;
                        }
                    }
                }
                else
                {
                    if (A_region.Text != "")
                    {
                        if (A_country.Text == "")
                        {
                            MessageBox.Show("Need a country", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            action = 3;
                        }
                    }
                    else
                    {
                        if (A_country.Text != "")
                        {
                            action = 4;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
            if (action == 1)
            {
                string country_id = "";
                for (int i = 0; i < countrylist.Count; i++)
                {
                    if (A_country.Text == countrylist[i].name)
                    {
                        country_id = countrylist[i].id;
                        break;
                    }
                }
                if (country_id != "")
                {
                    string region_id = "";
                    for (int i = 0; i < regionlist.Count; i++)
                    {
                        if ((A_region.Text == regionlist[i].name) && (country_id == regionlist[i].country))
                        {
                            region_id = regionlist[i].id;
                            break;
                        }
                    }
                    if (region_id != "")
                    {
                        string settlement_id = "";
                        for (int i = 0; i < settlementlist.Count; i++)
                        {
                            if ((A_settlement.Text == settlementlist[i].name) && (region_id == settlementlist[i].region))
                            {
                                settlement_id = settlementlist[i].id;
                                break;
                            }
                        }
                        if (settlement_id != "")
                        {
                            string object_id = "";
                            for (int i = 0; i < objectlist.Count; i++)
                            {
                                if ((A_object.Text == objectlist[i].name) && (settlement_id == objectlist[i].settlement))
                                {
                                    object_id = objectlist[i].id;
                                    break;
                                }
                            }
                            if (object_id == "")
                            {
                                MessageBox.Show("Object does not exist", "Result", MessageBoxButtons.OK);
                                return;
                            }
                            else
                            {
                                ConsoleApplication1.OBject item = new OBject(A_object.Text, object_id, settlement_id);
                                Receiver<OBject> object_receiver = new Receiver<ConsoleApplication1.OBject>();
                                SendingRequest<OBject> object_sender = new SendingRequest<OBject>("delete", "Object", item);
                                ServerUpp<OBject, OBject>(object_sender, ref object_receiver);
                                objectlist.Remove(item);
                                MessageBox.Show("Object has been deleted", "!", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No such settlement in the database", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No such region in the database", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("No such country in the database", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (action == 2)
            {
                string country_id = "";
                for (int i = 0; i < countrylist.Count; i++)
                {
                    if (A_country.Text == countrylist[i].name)
                    {
                        country_id = countrylist[i].id;
                        break;
                    }
                }
                if (country_id != "")
                {
                    string region_id = "";
                    for (int i = 0; i < regionlist.Count; i++)
                    {
                        if ((A_region.Text == regionlist[i].name) && (country_id == regionlist[i].country))
                        {
                            region_id = regionlist[i].id;
                            break;
                        }
                    }
                    if (region_id != "")
                    {
                        string settlement_id = "";
                        for (int i = 0; i < settlementlist.Count; i++)
                        {
                            if ((A_settlement.Text == settlementlist[i].name) && (region_id == settlementlist[i].region))
                            {
                                settlement_id = settlementlist[i].id;
                                break;
                            }
                        }
                        if (settlement_id == "")
                        {
                            MessageBox.Show("Settlement does not exist", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            ConsoleApplication1.Settlement item = new Settlement(A_settlement.Text, region_id, settlement_id);
                            Receiver<Settlement> object_receiver = new Receiver<ConsoleApplication1.Settlement>();
                            SendingRequest<Settlement> object_sender = new SendingRequest<Settlement>("delete", "Settlement", item);
                            ServerUpp<Settlement, Settlement>(object_sender, ref object_receiver);
                            settlementlist.Remove(item);
                            MessageBox.Show("Settlement has been deleted", "!", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No such region in the database", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("No such country in the database", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (action == 3)
            {
                string country_id = "";
                for (int i = 0; i < countrylist.Count; i++)
                {
                    if (A_country.Text == countrylist[i].name)
                    {
                        country_id = countrylist[i].id;
                        break;
                    }
                }
                if (country_id != "")
                {
                    string region_id = "";
                    for (int i = 0; i < regionlist.Count; i++)
                    {
                        if ((A_region.Text == regionlist[i].name) && (country_id == regionlist[i].country))
                        {
                            region_id = regionlist[i].id;
                            break;
                        }
                    }
                    if (region_id == "")
                    {
                        MessageBox.Show("Region does not exist", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        ConsoleApplication1.Region item = new Region(A_region.Text, country_id, region_id);
                        Receiver<Region> object_receiver = new Receiver<ConsoleApplication1.Region>();
                        SendingRequest<Region> object_sender = new SendingRequest<Region>("delete", "Region", item);
                        ServerUpp<Region, Region>(object_sender, ref object_receiver);
                        regionlist.Remove(item);
                        MessageBox.Show("Region has been deleted", "!", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("No such country in the database", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (action == 4)
            {
                string country_id = "";
                for (int i = 0; i < countrylist.Count; i++)
                {
                    if (A_country.Text == countrylist[i].name)
                    {
                        country_id = countrylist[i].id;
                        break;
                    }
                }
                if (country_id == "")
                {
                    MessageBox.Show("Country does not exist", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ConsoleApplication1.Country item = new Country(A_country.Text, country_id);
                    Receiver<Country> object_receiver = new Receiver<ConsoleApplication1.Country>();
                    SendingRequest<Country> object_sender = new SendingRequest<Country>("delete", "Country", item);
                    ServerUpp<Country, Country>(object_sender, ref object_receiver);
                    countrylist.Add(object_receiver.data[0]);
                    MessageBox.Show("Country added to the database", "!", MessageBoxButtons.OK);
                }
            }
            RefreshData();
        }
        private void A_discard_Click(object sender, EventArgs e)
        {
            A_country.Text = "Country";
            A_region.Text = "Region";
            A_settlement.Text = "Settlement";
            A_object.Text = "Object";
        }
        private void A_find_Click(object sender, EventArgs e)
        {
            int action = 0;
            if (A_object.Text != "")
            {
                if (A_settlement.Text == "")
                {
                    MessageBox.Show("Need a settlement", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (A_region.Text == "")
                    {
                        MessageBox.Show("Need a region", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (A_country.Text == "")
                        {
                            MessageBox.Show("Need a country", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            action = 1;
                        }
                    }
                }
            }
            else
            {
                if (A_settlement.Text != "")
                {
                    if (A_region.Text == "")
                    {
                        MessageBox.Show("Need a region", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (A_country.Text == "")
                        {
                            MessageBox.Show("Need a country", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            action = 2;
                        }
                    }
                }
                else
                {
                    if (A_region.Text != "")
                    {
                        if (A_country.Text == "")
                        {
                            MessageBox.Show("Need a country", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            action = 3;
                        }
                    }
                    else
                    {
                        if (A_country.Text != "")
                        {
                            action = 4;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
            if (action == 4) 
            {
                string country_id = "";
                for (int i = 0; i < countrylist.Count; i++)
                {
                    if (A_country.Text == countrylist[i].name)
                    {
                        country_id = countrylist[i].id;
                        break;
                    }
                }
                if (country_id != "")
                {
                    var boldfont = FontFactory.GetFont(FontFactory.TIMES_BOLD, 14);
                    var font = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12);
                    var doc = new Document();
                    PdfWriter.GetInstance(doc, new FileStream("Report.pdf", FileMode.OpenOrCreate));
                    doc.Open();
                    doc.Add(new Phrase("Regions in :" + A_country.Text + "\n", boldfont));
                    for (int i = 0; i < regionlist.Count; i++)
                    {
                        if (regionlist[i].country == country_id)
                        {
                            doc.Add(new Phrase(regionlist[i].name + ";\n", font));
                        }
                    }
                    doc.Close();
                }
                else 
                {
                    MessageBox.Show("No such country", "Fail", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }
            if (action == 3) 
            {
                string country_id = "";
                for (int i = 0; i < countrylist.Count; i++)
                {
                    if (A_country.Text == countrylist[i].name)
                    {
                        country_id = countrylist[i].id;
                        break;
                    }
                }
                if (country_id != "")
                {
                    string region_id = "";
                    for (int i = 0; i < regionlist.Count; i++)
                    {
                        if ((A_region.Text == regionlist[i].name) && (regionlist[i].country == country_id))
                        {
                            region_id = regionlist[i].id;
                            break;
                        }
                    }
                    if (region_id != "")
                    {
                        var boldfont = FontFactory.GetFont(FontFactory.TIMES_BOLD, 14);
                        var font = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12);
                        var doc = new Document();
                        PdfWriter.GetInstance(doc, new FileStream("Report.pdf", FileMode.OpenOrCreate));
                        doc.Open();
                        doc.Add(new Phrase("Settlements in country " + A_country.Text + "" + " and region " + A_region.Text + ":" + "\n", boldfont));
                        for (int i = 0; i < settlementlist.Count; i++)
                        {
                            if (settlementlist[i].region == region_id)
                            {
                                doc.Add(new Phrase(settlementlist[i].name + ";\n", font));
                            }
                        }
                        doc.Close();
                    }
                    else
                    {
                        MessageBox.Show("No such region", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else 
                {
                    MessageBox.Show("No such country", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (action == 2) 
            {
                string country_id = "";
                for (int i = 0; i < countrylist.Count; i++)
                {
                    if (A_country.Text == countrylist[i].name)
                    {
                        country_id = countrylist[i].id;
                        break;
                    }
                }
                if (country_id != "")
                {
                    string region_id = "";
                    for (int i = 0; i < regionlist.Count; i++)
                    {
                        if ((A_region.Text == regionlist[i].name) && (regionlist[i].country == country_id))
                        {
                            region_id = regionlist[i].id;
                            break;
                        }
                    }
                    if (region_id != "")
                    {
                        string settlement_id = "";
                        for (int i = 0; i < settlementlist.Count; i++)
                        {
                            if ((A_settlement.Text == settlementlist[i].name) && (settlementlist[i].region == region_id))
                            {
                                settlement_id = settlementlist[i].id;
                                break;
                            }
                        }
                        if (settlement_id != "")
                        {
                            var boldfont = FontFactory.GetFont(FontFactory.TIMES_BOLD, 14);
                            var font = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12);
                            var doc = new Document();
                            PdfWriter.GetInstance(doc, new FileStream("Report.pdf", FileMode.OpenOrCreate));
                            doc.Open();
                            doc.Add(new Phrase("Objects in settlement " + A_settlement.Text + " and region "+ A_region.Text + " and country " + A_country.Text + ":" + "\n", boldfont));
                            for (int i = 0; i < objectlist.Count; i++)
                            {
                                if (objectlist[i].settlement == settlement_id)
                                {
                                    doc.Add(new Phrase(objectlist[i].name + ";\n", font));
                                }
                            }
                            doc.Close();
                        }
                        else 
                        {
                            MessageBox.Show("No such settlement", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No such region", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("No such country", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (action == 1) 
            {
                string country_id = "";
                for (int i = 0; i < countrylist.Count; i++)
                {
                    if (A_country.Text == countrylist[i].name)
                    {
                        country_id = countrylist[i].id;
                        break;
                    }
                }
                if (country_id != "")
                {
                    string region_id = "";
                    for (int i = 0; i < regionlist.Count; i++)
                    {
                        if ((A_region.Text == regionlist[i].name) && (regionlist[i].country == country_id))
                        {
                            region_id = regionlist[i].id;
                            break;
                        }
                    }
                    if (region_id != "")
                    {
                        string settlement_id = "";
                        for (int i = 0; i < settlementlist.Count; i++)
                        {
                            if ((A_settlement.Text == settlementlist[i].name) && (settlementlist[i].region == region_id))
                            {
                                settlement_id = settlementlist[i].id;
                                break;
                            }
                        }
                        if (settlement_id != "")
                        {
                            string object_id = "";
                            for (int i = 0; i < objectlist.Count; i++)
                            {
                                if ((A_object.Text == objectlist[i].name) && (objectlist[i].settlement == settlement_id))
                                {
                                    object_id = objectlist[i].id;
                                    break;
                                }
                            }
                            if (object_id != "")
                            {
                                MessageBox.Show("Match!", "Result", MessageBoxButtons.OK);
                                return;
                            }
                            else 
                            {
                                MessageBox.Show("Not a match", "Fail", MessageBoxButtons.OK);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No such settlement", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No such region", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("No such country", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
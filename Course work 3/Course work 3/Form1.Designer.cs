namespace Course_work_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Admin = new System.Windows.Forms.TabControl();
            this.Registration = new System.Windows.Forms.TabPage();
            this.Budget = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Add_action = new System.Windows.Forms.Button();
            this.Calcel = new System.Windows.Forms.Button();
            this.Executed_action_text = new System.Windows.Forms.RichTextBox();
            this.Executed_action_date = new System.Windows.Forms.DateTimePicker();
            this.Type_of_accident = new System.Windows.Forms.ComboBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Discard = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Object = new System.Windows.Forms.ComboBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Settlement = new System.Windows.Forms.ComboBox();
            this.Region = new System.Windows.Forms.ComboBox();
            this.Country = new System.Windows.Forms.ComboBox();
            this.Report = new System.Windows.Forms.TabPage();
            this.rep_refresh = new System.Windows.Forms.Button();
            this.Delete_event = new System.Windows.Forms.Button();
            this.rec_id = new System.Windows.Forms.ComboBox();
            this.rep_discard = new System.Windows.Forms.Button();
            this.rep_make = new System.Windows.Forms.Button();
            this.rep_type_of_accident = new System.Windows.Forms.ComboBox();
            this.rep_object = new System.Windows.Forms.ComboBox();
            this.rep_settlement = new System.Windows.Forms.ComboBox();
            this.rep_region = new System.Windows.Forms.ComboBox();
            this.rep_country = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.date_to = new System.Windows.Forms.DateTimePicker();
            this.date_from = new System.Windows.Forms.DateTimePicker();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Logout = new System.Windows.Forms.Button();
            this.A_recommended_actions = new System.Windows.Forms.GroupBox();
            this.rec_act_desc = new System.Windows.Forms.RichTextBox();
            this.c_discard_rec = new System.Windows.Forms.Button();
            this.c_find_rec = new System.Windows.Forms.Button();
            this.c_delete_rec = new System.Windows.Forms.Button();
            this.c_add_rec = new System.Windows.Forms.Button();
            this.rec_act_accident_type = new System.Windows.Forms.TextBox();
            this.rec_act_name = new System.Windows.Forms.TextBox();
            this.A_accident_types = new System.Windows.Forms.GroupBox();
            this.B_discard_click = new System.Windows.Forms.Button();
            this.B_find_click = new System.Windows.Forms.Button();
            this.B_delete_click = new System.Windows.Forms.Button();
            this.B_add_click = new System.Windows.Forms.Button();
            this.B_accident_type = new System.Windows.Forms.TextBox();
            this.A_object_management = new System.Windows.Forms.GroupBox();
            this.A_discard = new System.Windows.Forms.Button();
            this.A_object = new System.Windows.Forms.TextBox();
            this.A_find = new System.Windows.Forms.Button();
            this.A_delete = new System.Windows.Forms.Button();
            this.A_add = new System.Windows.Forms.Button();
            this.A_settlement = new System.Windows.Forms.TextBox();
            this.A_region = new System.Windows.Forms.TextBox();
            this.A_country = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.Pass = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Admin.SuspendLayout();
            this.Registration.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Report.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.A_recommended_actions.SuspendLayout();
            this.A_accident_types.SuspendLayout();
            this.A_object_management.SuspendLayout();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Admin.Controls.Add(this.Registration);
            this.Admin.Controls.Add(this.Report);
            this.Admin.Controls.Add(this.tabPage1);
            this.Admin.Location = new System.Drawing.Point(12, 12);
            this.Admin.Name = "Admin";
            this.Admin.SelectedIndex = 0;
            this.Admin.Size = new System.Drawing.Size(915, 367);
            this.Admin.TabIndex = 0;
            // 
            // Registration
            // 
            this.Registration.Controls.Add(this.Budget);
            this.Registration.Controls.Add(this.groupBox1);
            this.Registration.Controls.Add(this.Type_of_accident);
            this.Registration.Controls.Add(this.Submit);
            this.Registration.Controls.Add(this.Discard);
            this.Registration.Controls.Add(this.Description);
            this.Registration.Controls.Add(this.Object);
            this.Registration.Controls.Add(this.Date);
            this.Registration.Controls.Add(this.Settlement);
            this.Registration.Controls.Add(this.Region);
            this.Registration.Controls.Add(this.Country);
            this.Registration.Location = new System.Drawing.Point(4, 22);
            this.Registration.Name = "Registration";
            this.Registration.Padding = new System.Windows.Forms.Padding(3);
            this.Registration.Size = new System.Drawing.Size(907, 341);
            this.Registration.TabIndex = 0;
            this.Registration.Text = "Registration";
            this.Registration.UseVisualStyleBackColor = true;
            // 
            // Budget
            // 
            this.Budget.Location = new System.Drawing.Point(7, 250);
            this.Budget.Name = "Budget";
            this.Budget.Size = new System.Drawing.Size(167, 20);
            this.Budget.TabIndex = 12;
            this.Budget.Text = "Budget";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Price);
            this.groupBox1.Controls.Add(this.Add_action);
            this.groupBox1.Controls.Add(this.Calcel);
            this.groupBox1.Controls.Add(this.Executed_action_text);
            this.groupBox1.Controls.Add(this.Executed_action_date);
            this.groupBox1.Location = new System.Drawing.Point(499, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 257);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Executed Actions";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(7, 228);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(200, 20);
            this.Price.TabIndex = 14;
            this.Price.Text = "Price";
            // 
            // Add_action
            // 
            this.Add_action.Location = new System.Drawing.Point(320, 228);
            this.Add_action.Name = "Add_action";
            this.Add_action.Size = new System.Drawing.Size(75, 23);
            this.Add_action.TabIndex = 13;
            this.Add_action.Text = "Add Action";
            this.Add_action.UseVisualStyleBackColor = true;
            this.Add_action.Click += new System.EventHandler(this.Add_action_Click);
            // 
            // Calcel
            // 
            this.Calcel.Location = new System.Drawing.Point(230, 228);
            this.Calcel.Name = "Calcel";
            this.Calcel.Size = new System.Drawing.Size(75, 23);
            this.Calcel.TabIndex = 12;
            this.Calcel.Text = "Cancel";
            this.Calcel.UseVisualStyleBackColor = true;
            this.Calcel.Click += new System.EventHandler(this.Calcel_Click);
            // 
            // Executed_action_text
            // 
            this.Executed_action_text.Location = new System.Drawing.Point(6, 45);
            this.Executed_action_text.Name = "Executed_action_text";
            this.Executed_action_text.Size = new System.Drawing.Size(386, 177);
            this.Executed_action_text.TabIndex = 11;
            this.Executed_action_text.Text = "Description of the action";
            // 
            // Executed_action_date
            // 
            this.Executed_action_date.Location = new System.Drawing.Point(7, 19);
            this.Executed_action_date.Name = "Executed_action_date";
            this.Executed_action_date.Size = new System.Drawing.Size(200, 20);
            this.Executed_action_date.TabIndex = 10;
            // 
            // Type_of_accident
            // 
            this.Type_of_accident.FormattingEnabled = true;
            this.Type_of_accident.Location = new System.Drawing.Point(7, 202);
            this.Type_of_accident.Name = "Type_of_accident";
            this.Type_of_accident.Size = new System.Drawing.Size(167, 21);
            this.Type_of_accident.TabIndex = 8;
            this.Type_of_accident.Text = "Type of accident";
            // 
            // Submit
            // 
            this.Submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Submit.Location = new System.Drawing.Point(551, 301);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(117, 34);
            this.Submit.TabIndex = 7;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Discard
            // 
            this.Discard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Discard.Location = new System.Drawing.Point(306, 301);
            this.Discard.Name = "Discard";
            this.Discard.Size = new System.Drawing.Size(117, 34);
            this.Discard.TabIndex = 6;
            this.Discard.Text = "Discard";
            this.Discard.UseVisualStyleBackColor = true;
            this.Discard.Click += new System.EventHandler(this.Discard_Click);
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(180, 10);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(313, 253);
            this.Description.TabIndex = 5;
            this.Description.Text = "Description of the accident";
            // 
            // Object
            // 
            this.Object.FormattingEnabled = true;
            this.Object.Location = new System.Drawing.Point(7, 154);
            this.Object.Name = "Object";
            this.Object.Size = new System.Drawing.Size(167, 21);
            this.Object.TabIndex = 4;
            this.Object.Text = "Object";
            // 
            // Date
            // 
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Date.Location = new System.Drawing.Point(6, 297);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(168, 20);
            this.Date.TabIndex = 3;
            // 
            // Settlement
            // 
            this.Settlement.FormattingEnabled = true;
            this.Settlement.Location = new System.Drawing.Point(7, 106);
            this.Settlement.Name = "Settlement";
            this.Settlement.Size = new System.Drawing.Size(167, 21);
            this.Settlement.TabIndex = 2;
            this.Settlement.Text = "Settlement";
            this.Settlement.TextChanged += new System.EventHandler(this.Settlement_changed);
            // 
            // Region
            // 
            this.Region.FormattingEnabled = true;
            this.Region.Location = new System.Drawing.Point(7, 58);
            this.Region.Name = "Region";
            this.Region.Size = new System.Drawing.Size(167, 21);
            this.Region.TabIndex = 1;
            this.Region.Text = "Region";
            this.Region.TextChanged += new System.EventHandler(this.Region_changed);
            // 
            // Country
            // 
            this.Country.FormattingEnabled = true;
            this.Country.Location = new System.Drawing.Point(7, 10);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(167, 21);
            this.Country.TabIndex = 0;
            this.Country.Text = "Country";
            this.Country.TextChanged += new System.EventHandler(this.Country_changed);
            // 
            // Report
            // 
            this.Report.Controls.Add(this.rep_refresh);
            this.Report.Controls.Add(this.Delete_event);
            this.Report.Controls.Add(this.rec_id);
            this.Report.Controls.Add(this.rep_discard);
            this.Report.Controls.Add(this.rep_make);
            this.Report.Controls.Add(this.rep_type_of_accident);
            this.Report.Controls.Add(this.rep_object);
            this.Report.Controls.Add(this.rep_settlement);
            this.Report.Controls.Add(this.rep_region);
            this.Report.Controls.Add(this.rep_country);
            this.Report.Controls.Add(this.label2);
            this.Report.Controls.Add(this.label1);
            this.Report.Controls.Add(this.date_to);
            this.Report.Controls.Add(this.date_from);
            this.Report.Location = new System.Drawing.Point(4, 22);
            this.Report.Name = "Report";
            this.Report.Padding = new System.Windows.Forms.Padding(3);
            this.Report.Size = new System.Drawing.Size(907, 341);
            this.Report.TabIndex = 1;
            this.Report.Text = "Report";
            this.Report.UseVisualStyleBackColor = true;
            // 
            // rep_refresh
            // 
            this.rep_refresh.Location = new System.Drawing.Point(179, 272);
            this.rep_refresh.Name = "rep_refresh";
            this.rep_refresh.Size = new System.Drawing.Size(109, 34);
            this.rep_refresh.TabIndex = 1;
            this.rep_refresh.Text = "Refresh data";
            this.rep_refresh.UseVisualStyleBackColor = true;
            this.rep_refresh.Click += new System.EventHandler(this.rep_refresh_Click);
            // 
            // Delete_event
            // 
            this.Delete_event.Location = new System.Drawing.Point(6, 272);
            this.Delete_event.Name = "Delete_event";
            this.Delete_event.Size = new System.Drawing.Size(167, 34);
            this.Delete_event.TabIndex = 23;
            this.Delete_event.Text = "Delete event";
            this.Delete_event.UseVisualStyleBackColor = true;
            this.Delete_event.Click += new System.EventHandler(this.Delete_event_Click);
            // 
            // rec_id
            // 
            this.rec_id.FormattingEnabled = true;
            this.rec_id.Location = new System.Drawing.Point(6, 3);
            this.rec_id.Name = "rec_id";
            this.rec_id.Size = new System.Drawing.Size(167, 21);
            this.rec_id.TabIndex = 22;
            this.rec_id.Text = "Id";
            this.rec_id.TextChanged += new System.EventHandler(this.rec_id_text_changed);
            // 
            // rep_discard
            // 
            this.rep_discard.Location = new System.Drawing.Point(6, 312);
            this.rep_discard.Name = "rep_discard";
            this.rep_discard.Size = new System.Drawing.Size(167, 23);
            this.rep_discard.TabIndex = 21;
            this.rep_discard.Text = "Discard";
            this.rep_discard.UseVisualStyleBackColor = true;
            // 
            // rep_make
            // 
            this.rep_make.Location = new System.Drawing.Point(6, 243);
            this.rep_make.Name = "rep_make";
            this.rep_make.Size = new System.Drawing.Size(167, 23);
            this.rep_make.TabIndex = 20;
            this.rep_make.Text = "Make reports";
            this.rep_make.UseVisualStyleBackColor = true;
            this.rep_make.Click += new System.EventHandler(this.rep_make_Click);
            // 
            // rep_type_of_accident
            // 
            this.rep_type_of_accident.FormattingEnabled = true;
            this.rep_type_of_accident.Location = new System.Drawing.Point(6, 138);
            this.rep_type_of_accident.Name = "rep_type_of_accident";
            this.rep_type_of_accident.Size = new System.Drawing.Size(167, 21);
            this.rep_type_of_accident.TabIndex = 19;
            this.rep_type_of_accident.Text = "Type of accident";
            // 
            // rep_object
            // 
            this.rep_object.FormattingEnabled = true;
            this.rep_object.Location = new System.Drawing.Point(6, 111);
            this.rep_object.Name = "rep_object";
            this.rep_object.Size = new System.Drawing.Size(167, 21);
            this.rep_object.TabIndex = 18;
            this.rep_object.Text = "Object";
            // 
            // rep_settlement
            // 
            this.rep_settlement.FormattingEnabled = true;
            this.rep_settlement.Location = new System.Drawing.Point(6, 84);
            this.rep_settlement.Name = "rep_settlement";
            this.rep_settlement.Size = new System.Drawing.Size(167, 21);
            this.rep_settlement.TabIndex = 17;
            this.rep_settlement.Text = "Settlement";
            this.rep_settlement.TextChanged += new System.EventHandler(this.rep_settlement_changed);
            // 
            // rep_region
            // 
            this.rep_region.FormattingEnabled = true;
            this.rep_region.Location = new System.Drawing.Point(6, 57);
            this.rep_region.Name = "rep_region";
            this.rep_region.Size = new System.Drawing.Size(167, 21);
            this.rep_region.TabIndex = 16;
            this.rep_region.Text = "Region";
            this.rep_region.TextChanged += new System.EventHandler(this.rep_region_changed);
            // 
            // rep_country
            // 
            this.rep_country.FormattingEnabled = true;
            this.rep_country.Location = new System.Drawing.Point(6, 30);
            this.rep_country.Name = "rep_country";
            this.rep_country.Size = new System.Drawing.Size(167, 21);
            this.rep_country.TabIndex = 15;
            this.rep_country.Text = "Country";
            this.rep_country.TextChanged += new System.EventHandler(this.rep_country_changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "From";
            // 
            // date_to
            // 
            this.date_to.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.date_to.Location = new System.Drawing.Point(6, 217);
            this.date_to.Name = "date_to";
            this.date_to.Size = new System.Drawing.Size(167, 20);
            this.date_to.TabIndex = 12;
            // 
            // date_from
            // 
            this.date_from.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.date_from.Location = new System.Drawing.Point(6, 178);
            this.date_from.Name = "date_from";
            this.date_from.Size = new System.Drawing.Size(167, 20);
            this.date_from.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Logout);
            this.tabPage1.Controls.Add(this.A_recommended_actions);
            this.tabPage1.Controls.Add(this.A_accident_types);
            this.tabPage1.Controls.Add(this.A_object_management);
            this.tabPage1.Controls.Add(this.LoginButton);
            this.tabPage1.Controls.Add(this.Pass);
            this.tabPage1.Controls.Add(this.Login);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(907, 341);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Admin";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(801, 31);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 23);
            this.Logout.TabIndex = 11;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // A_recommended_actions
            // 
            this.A_recommended_actions.Controls.Add(this.rec_act_desc);
            this.A_recommended_actions.Controls.Add(this.c_discard_rec);
            this.A_recommended_actions.Controls.Add(this.c_find_rec);
            this.A_recommended_actions.Controls.Add(this.c_delete_rec);
            this.A_recommended_actions.Controls.Add(this.c_add_rec);
            this.A_recommended_actions.Controls.Add(this.rec_act_accident_type);
            this.A_recommended_actions.Controls.Add(this.rec_act_name);
            this.A_recommended_actions.Location = new System.Drawing.Point(362, 6);
            this.A_recommended_actions.Name = "A_recommended_actions";
            this.A_recommended_actions.Size = new System.Drawing.Size(150, 329);
            this.A_recommended_actions.TabIndex = 10;
            this.A_recommended_actions.TabStop = false;
            this.A_recommended_actions.Text = "Recommended actions";
            // 
            // rec_act_desc
            // 
            this.rec_act_desc.Location = new System.Drawing.Point(7, 71);
            this.rec_act_desc.Name = "rec_act_desc";
            this.rec_act_desc.Size = new System.Drawing.Size(137, 97);
            this.rec_act_desc.TabIndex = 9;
            this.rec_act_desc.Text = "Description";
            // 
            // c_discard_rec
            // 
            this.c_discard_rec.Location = new System.Drawing.Point(3, 300);
            this.c_discard_rec.Name = "c_discard_rec";
            this.c_discard_rec.Size = new System.Drawing.Size(139, 23);
            this.c_discard_rec.TabIndex = 8;
            this.c_discard_rec.Text = "Discard";
            this.c_discard_rec.UseVisualStyleBackColor = true;
            this.c_discard_rec.Click += new System.EventHandler(this.c_discard_rec_Click);
            // 
            // c_find_rec
            // 
            this.c_find_rec.Location = new System.Drawing.Point(3, 258);
            this.c_find_rec.Name = "c_find_rec";
            this.c_find_rec.Size = new System.Drawing.Size(139, 23);
            this.c_find_rec.TabIndex = 6;
            this.c_find_rec.Text = "Find";
            this.c_find_rec.UseVisualStyleBackColor = true;
            this.c_find_rec.Click += new System.EventHandler(this.c_find_rec_Click);
            // 
            // c_delete_rec
            // 
            this.c_delete_rec.Location = new System.Drawing.Point(3, 229);
            this.c_delete_rec.Name = "c_delete_rec";
            this.c_delete_rec.Size = new System.Drawing.Size(139, 23);
            this.c_delete_rec.TabIndex = 5;
            this.c_delete_rec.Text = "Delete";
            this.c_delete_rec.UseVisualStyleBackColor = true;
            this.c_delete_rec.Click += new System.EventHandler(this.c_delete_rec_Click);
            // 
            // c_add_rec
            // 
            this.c_add_rec.Location = new System.Drawing.Point(3, 200);
            this.c_add_rec.Name = "c_add_rec";
            this.c_add_rec.Size = new System.Drawing.Size(139, 23);
            this.c_add_rec.TabIndex = 4;
            this.c_add_rec.Text = "Add";
            this.c_add_rec.UseVisualStyleBackColor = true;
            this.c_add_rec.Click += new System.EventHandler(this.c_add_rec_Click);
            // 
            // rec_act_accident_type
            // 
            this.rec_act_accident_type.Location = new System.Drawing.Point(4, 45);
            this.rec_act_accident_type.Name = "rec_act_accident_type";
            this.rec_act_accident_type.Size = new System.Drawing.Size(140, 20);
            this.rec_act_accident_type.TabIndex = 1;
            this.rec_act_accident_type.Text = "Accident type";
            // 
            // rec_act_name
            // 
            this.rec_act_name.Location = new System.Drawing.Point(4, 19);
            this.rec_act_name.Name = "rec_act_name";
            this.rec_act_name.Size = new System.Drawing.Size(140, 20);
            this.rec_act_name.TabIndex = 0;
            this.rec_act_name.Text = "Name";
            // 
            // A_accident_types
            // 
            this.A_accident_types.Controls.Add(this.B_discard_click);
            this.A_accident_types.Controls.Add(this.B_find_click);
            this.A_accident_types.Controls.Add(this.B_delete_click);
            this.A_accident_types.Controls.Add(this.B_add_click);
            this.A_accident_types.Controls.Add(this.B_accident_type);
            this.A_accident_types.Location = new System.Drawing.Point(184, 6);
            this.A_accident_types.Name = "A_accident_types";
            this.A_accident_types.Size = new System.Drawing.Size(155, 329);
            this.A_accident_types.TabIndex = 9;
            this.A_accident_types.TabStop = false;
            this.A_accident_types.Text = "Accident types";
            // 
            // B_discard_click
            // 
            this.B_discard_click.Location = new System.Drawing.Point(6, 301);
            this.B_discard_click.Name = "B_discard_click";
            this.B_discard_click.Size = new System.Drawing.Size(139, 23);
            this.B_discard_click.TabIndex = 8;
            this.B_discard_click.Text = "Discard";
            this.B_discard_click.UseVisualStyleBackColor = true;
            this.B_discard_click.Click += new System.EventHandler(this.b_discard_Click);
            // 
            // B_find_click
            // 
            this.B_find_click.Location = new System.Drawing.Point(6, 258);
            this.B_find_click.Name = "B_find_click";
            this.B_find_click.Size = new System.Drawing.Size(139, 23);
            this.B_find_click.TabIndex = 6;
            this.B_find_click.Text = "Find";
            this.B_find_click.UseVisualStyleBackColor = true;
            this.B_find_click.Click += new System.EventHandler(this.b_find_Click);
            // 
            // B_delete_click
            // 
            this.B_delete_click.Location = new System.Drawing.Point(6, 229);
            this.B_delete_click.Name = "B_delete_click";
            this.B_delete_click.Size = new System.Drawing.Size(139, 23);
            this.B_delete_click.TabIndex = 5;
            this.B_delete_click.Text = "Delete";
            this.B_delete_click.UseVisualStyleBackColor = true;
            this.B_delete_click.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // B_add_click
            // 
            this.B_add_click.Location = new System.Drawing.Point(6, 200);
            this.B_add_click.Name = "B_add_click";
            this.B_add_click.Size = new System.Drawing.Size(139, 23);
            this.B_add_click.TabIndex = 4;
            this.B_add_click.Text = "Add";
            this.B_add_click.UseVisualStyleBackColor = true;
            this.B_add_click.Click += new System.EventHandler(this.b_add_Click);
            // 
            // B_accident_type
            // 
            this.B_accident_type.Location = new System.Drawing.Point(5, 19);
            this.B_accident_type.Name = "B_accident_type";
            this.B_accident_type.Size = new System.Drawing.Size(140, 20);
            this.B_accident_type.TabIndex = 0;
            this.B_accident_type.Text = "Name";
            // 
            // A_object_management
            // 
            this.A_object_management.Controls.Add(this.A_discard);
            this.A_object_management.Controls.Add(this.A_object);
            this.A_object_management.Controls.Add(this.A_find);
            this.A_object_management.Controls.Add(this.A_delete);
            this.A_object_management.Controls.Add(this.A_add);
            this.A_object_management.Controls.Add(this.A_settlement);
            this.A_object_management.Controls.Add(this.A_region);
            this.A_object_management.Controls.Add(this.A_country);
            this.A_object_management.Location = new System.Drawing.Point(6, 6);
            this.A_object_management.Name = "A_object_management";
            this.A_object_management.Size = new System.Drawing.Size(155, 329);
            this.A_object_management.TabIndex = 3;
            this.A_object_management.TabStop = false;
            this.A_object_management.Text = "Object management";
            // 
            // A_discard
            // 
            this.A_discard.Location = new System.Drawing.Point(6, 301);
            this.A_discard.Name = "A_discard";
            this.A_discard.Size = new System.Drawing.Size(139, 23);
            this.A_discard.TabIndex = 8;
            this.A_discard.Text = "Discard";
            this.A_discard.UseVisualStyleBackColor = true;
            this.A_discard.Click += new System.EventHandler(this.A_discard_Click);
            // 
            // A_object
            // 
            this.A_object.Location = new System.Drawing.Point(6, 97);
            this.A_object.Name = "A_object";
            this.A_object.Size = new System.Drawing.Size(140, 20);
            this.A_object.TabIndex = 7;
            this.A_object.Text = "Object";
            // 
            // A_find
            // 
            this.A_find.Location = new System.Drawing.Point(6, 258);
            this.A_find.Name = "A_find";
            this.A_find.Size = new System.Drawing.Size(139, 23);
            this.A_find.TabIndex = 6;
            this.A_find.Text = "Find";
            this.A_find.UseVisualStyleBackColor = true;
            this.A_find.Click += new System.EventHandler(this.A_find_Click);
            // 
            // A_delete
            // 
            this.A_delete.Location = new System.Drawing.Point(6, 229);
            this.A_delete.Name = "A_delete";
            this.A_delete.Size = new System.Drawing.Size(139, 23);
            this.A_delete.TabIndex = 5;
            this.A_delete.Text = "Delete";
            this.A_delete.UseVisualStyleBackColor = true;
            this.A_delete.Click += new System.EventHandler(this.A_delete_Click);
            // 
            // A_add
            // 
            this.A_add.Location = new System.Drawing.Point(6, 200);
            this.A_add.Name = "A_add";
            this.A_add.Size = new System.Drawing.Size(139, 23);
            this.A_add.TabIndex = 4;
            this.A_add.Text = "Add";
            this.A_add.UseVisualStyleBackColor = true;
            this.A_add.Click += new System.EventHandler(this.A_add_Click);
            // 
            // A_settlement
            // 
            this.A_settlement.Location = new System.Drawing.Point(6, 71);
            this.A_settlement.Name = "A_settlement";
            this.A_settlement.Size = new System.Drawing.Size(140, 20);
            this.A_settlement.TabIndex = 2;
            this.A_settlement.Text = "Settleement";
            // 
            // A_region
            // 
            this.A_region.Location = new System.Drawing.Point(6, 45);
            this.A_region.Name = "A_region";
            this.A_region.Size = new System.Drawing.Size(140, 20);
            this.A_region.TabIndex = 1;
            this.A_region.Text = "Region";
            // 
            // A_country
            // 
            this.A_country.Location = new System.Drawing.Point(6, 19);
            this.A_country.Name = "A_country";
            this.A_country.Size = new System.Drawing.Size(140, 20);
            this.A_country.TabIndex = 0;
            this.A_country.Text = "Country";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(705, 32);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(801, 6);
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '*';
            this.Pass.Size = new System.Drawing.Size(100, 20);
            this.Pass.TabIndex = 1;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(680, 6);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 20);
            this.Login.TabIndex = 0;
            this.Login.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 391);
            this.Controls.Add(this.Admin);
            this.Name = "Form1";
            this.Text = "Application for registration of hazardous radioactive events (administration part" +
    " included)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Admin.ResumeLayout(false);
            this.Registration.ResumeLayout(false);
            this.Registration.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Report.ResumeLayout(false);
            this.Report.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.A_recommended_actions.ResumeLayout(false);
            this.A_recommended_actions.PerformLayout();
            this.A_accident_types.ResumeLayout(false);
            this.A_accident_types.PerformLayout();
            this.A_object_management.ResumeLayout(false);
            this.A_object_management.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Admin;
        private System.Windows.Forms.TabPage Registration;
        private System.Windows.Forms.ComboBox Object;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.ComboBox Settlement;
        private System.Windows.Forms.ComboBox Region;
        private System.Windows.Forms.ComboBox Country;
        private System.Windows.Forms.TabPage Report;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Discard;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.ComboBox Type_of_accident;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Add_action;
        private System.Windows.Forms.Button Calcel;
        private System.Windows.Forms.RichTextBox Executed_action_text;
        private System.Windows.Forms.DateTimePicker Executed_action_date;
        private System.Windows.Forms.TextBox Budget;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.GroupBox A_object_management;
        private System.Windows.Forms.TextBox A_settlement;
        private System.Windows.Forms.TextBox A_region;
        private System.Windows.Forms.TextBox A_country;
        private System.Windows.Forms.Button A_find;
        private System.Windows.Forms.Button A_delete;
        private System.Windows.Forms.Button A_add;
        private System.Windows.Forms.Button A_discard;
        private System.Windows.Forms.TextBox A_object;
        private System.Windows.Forms.GroupBox A_recommended_actions;
        private System.Windows.Forms.Button c_discard_rec;
        private System.Windows.Forms.Button c_find_rec;
        private System.Windows.Forms.Button c_delete_rec;
        private System.Windows.Forms.Button c_add_rec;
        private System.Windows.Forms.TextBox rec_act_accident_type;
        private System.Windows.Forms.TextBox rec_act_name;
        private System.Windows.Forms.GroupBox A_accident_types;
        private System.Windows.Forms.Button B_discard_click;
        private System.Windows.Forms.Button B_find_click;
        private System.Windows.Forms.Button B_delete_click;
        private System.Windows.Forms.Button B_add_click;
        private System.Windows.Forms.TextBox B_accident_type;
        private System.Windows.Forms.RichTextBox rec_act_desc;
        private System.Windows.Forms.Button rep_discard;
        private System.Windows.Forms.Button rep_make;
        private System.Windows.Forms.ComboBox rep_type_of_accident;
        private System.Windows.Forms.ComboBox rep_object;
        private System.Windows.Forms.ComboBox rep_settlement;
        private System.Windows.Forms.ComboBox rep_region;
        private System.Windows.Forms.ComboBox rep_country;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_to;
        private System.Windows.Forms.DateTimePicker date_from;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.ComboBox rec_id;
        private System.Windows.Forms.Button Delete_event;
        private System.Windows.Forms.Button rep_refresh;

    }
}


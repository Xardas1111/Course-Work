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
            this.Add_action = new System.Windows.Forms.Button();
            this.Calcel = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Type_of_accident = new System.Windows.Forms.ComboBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Discard = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Object = new System.Windows.Forms.ComboBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Settlement = new System.Windows.Forms.ComboBox();
            this.Region = new System.Windows.Forms.ComboBox();
            this.Country = new System.Windows.Forms.ComboBox();
            this.Report = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LoginButton = new System.Windows.Forms.Button();
            this.Pass = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.A_add_settlement = new System.Windows.Forms.GroupBox();
            this.A_country = new System.Windows.Forms.TextBox();
            this.A_region = new System.Windows.Forms.TextBox();
            this.A_settlement = new System.Windows.Forms.TextBox();
            this.A_add = new System.Windows.Forms.Button();
            this.A_delete = new System.Windows.Forms.Button();
            this.A_find = new System.Windows.Forms.Button();
            this.Admin.SuspendLayout();
            this.Registration.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.A_add_settlement.SuspendLayout();
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
            this.Registration.Controls.Add(this.richTextBox1);
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
            this.groupBox1.Controls.Add(this.Add_action);
            this.groupBox1.Controls.Add(this.Calcel);
            this.groupBox1.Controls.Add(this.richTextBox2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(499, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 257);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Executed Actions";
            // 
            // Add_action
            // 
            this.Add_action.Location = new System.Drawing.Point(203, 228);
            this.Add_action.Name = "Add_action";
            this.Add_action.Size = new System.Drawing.Size(75, 23);
            this.Add_action.TabIndex = 13;
            this.Add_action.Text = "Add Action";
            this.Add_action.UseVisualStyleBackColor = true;
            // 
            // Calcel
            // 
            this.Calcel.Location = new System.Drawing.Point(113, 228);
            this.Calcel.Name = "Calcel";
            this.Calcel.Size = new System.Drawing.Size(75, 23);
            this.Calcel.TabIndex = 12;
            this.Calcel.Text = "Cancel";
            this.Calcel.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(6, 45);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(386, 177);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = "Description of the action";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
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
            this.Submit.Location = new System.Drawing.Point(503, 287);
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
            this.Discard.Location = new System.Drawing.Point(287, 287);
            this.Discard.Name = "Discard";
            this.Discard.Size = new System.Drawing.Size(117, 34);
            this.Discard.TabIndex = 6;
            this.Discard.Text = "Discard";
            this.Discard.UseVisualStyleBackColor = true;
            this.Discard.Click += new System.EventHandler(this.Discard_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(180, 10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(313, 253);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "Description of the accident";
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
            // 
            // Region
            // 
            this.Region.FormattingEnabled = true;
            this.Region.Location = new System.Drawing.Point(7, 58);
            this.Region.Name = "Region";
            this.Region.Size = new System.Drawing.Size(167, 21);
            this.Region.TabIndex = 1;
            this.Region.Text = "Region";
            // 
            // Country
            // 
            this.Country.FormattingEnabled = true;
            this.Country.Location = new System.Drawing.Point(7, 10);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(167, 21);
            this.Country.TabIndex = 0;
            this.Country.Text = "Country";
            // 
            // Report
            // 
            this.Report.Location = new System.Drawing.Point(4, 22);
            this.Report.Name = "Report";
            this.Report.Padding = new System.Windows.Forms.Padding(3);
            this.Report.Size = new System.Drawing.Size(907, 341);
            this.Report.TabIndex = 1;
            this.Report.Text = "Report";
            this.Report.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.A_add_settlement);
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
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(754, 32);
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
            // A_add_settlement
            // 
            this.A_add_settlement.Controls.Add(this.A_find);
            this.A_add_settlement.Controls.Add(this.A_delete);
            this.A_add_settlement.Controls.Add(this.A_add);
            this.A_add_settlement.Controls.Add(this.A_settlement);
            this.A_add_settlement.Controls.Add(this.A_region);
            this.A_add_settlement.Controls.Add(this.A_country);
            this.A_add_settlement.Location = new System.Drawing.Point(6, 6);
            this.A_add_settlement.Name = "A_add_settlement";
            this.A_add_settlement.Size = new System.Drawing.Size(152, 185);
            this.A_add_settlement.TabIndex = 3;
            this.A_add_settlement.TabStop = false;
            this.A_add_settlement.Text = "Add Settlement";
            // 
            // A_country
            // 
            this.A_country.Location = new System.Drawing.Point(6, 19);
            this.A_country.Name = "A_country";
            this.A_country.Size = new System.Drawing.Size(140, 20);
            this.A_country.TabIndex = 0;
            this.A_country.Text = "Country";
            // 
            // A_region
            // 
            this.A_region.Location = new System.Drawing.Point(6, 45);
            this.A_region.Name = "A_region";
            this.A_region.Size = new System.Drawing.Size(140, 20);
            this.A_region.TabIndex = 1;
            this.A_region.Text = "Region";
            // 
            // A_settlement
            // 
            this.A_settlement.Location = new System.Drawing.Point(6, 71);
            this.A_settlement.Name = "A_settlement";
            this.A_settlement.Size = new System.Drawing.Size(140, 20);
            this.A_settlement.TabIndex = 2;
            this.A_settlement.Text = "Settleement";
            // 
            // A_add
            // 
            this.A_add.Location = new System.Drawing.Point(6, 97);
            this.A_add.Name = "A_add";
            this.A_add.Size = new System.Drawing.Size(139, 23);
            this.A_add.TabIndex = 4;
            this.A_add.Text = "Add";
            this.A_add.UseVisualStyleBackColor = true;
            // 
            // A_delete
            // 
            this.A_delete.Location = new System.Drawing.Point(6, 126);
            this.A_delete.Name = "A_delete";
            this.A_delete.Size = new System.Drawing.Size(139, 23);
            this.A_delete.TabIndex = 5;
            this.A_delete.Text = "Delete";
            this.A_delete.UseVisualStyleBackColor = true;
            // 
            // A_find
            // 
            this.A_find.Location = new System.Drawing.Point(6, 155);
            this.A_find.Name = "A_find";
            this.A_find.Size = new System.Drawing.Size(139, 23);
            this.A_find.TabIndex = 6;
            this.A_find.Text = "Find";
            this.A_find.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 391);
            this.Controls.Add(this.Admin);
            this.Name = "Form1";
            this.Text = "Putin huilo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Admin.ResumeLayout(false);
            this.Registration.ResumeLayout(false);
            this.Registration.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.A_add_settlement.ResumeLayout(false);
            this.A_add_settlement.PerformLayout();
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox Type_of_accident;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Add_action;
        private System.Windows.Forms.Button Calcel;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox Budget;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.GroupBox A_add_settlement;
        private System.Windows.Forms.TextBox A_settlement;
        private System.Windows.Forms.TextBox A_region;
        private System.Windows.Forms.TextBox A_country;
        private System.Windows.Forms.Button A_find;
        private System.Windows.Forms.Button A_delete;
        private System.Windows.Forms.Button A_add;

    }
}


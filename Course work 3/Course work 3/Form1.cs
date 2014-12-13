using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Course_work_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Discard_Click(object sender, EventArgs e)
        {
            
        }

        private void Check_Input(object sender, EventArgs e) 
        { 
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_work_3
{
    public partial class IP_set : Form
    {
        string server_ip;
        public IP_set()
        {
            InitializeComponent();
        }

        public IP_set(ref string ip)
        {
            ip = server_ip;
            InitializeComponent();
        }

        private void Confirm_ip_Click(object sender, EventArgs e)
        {
            server_ip = ip_box.Text;
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelManagement
{
    public partial class Admin : UserControl
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            adminupdate.Visible = false;
            admindelete.Visible = false;
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            adminadd.Visible = false;
            admindelete.Visible = false;
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
           adminadd.Visible = false;
            adminupdate.Visible = false;
            admindelete.Visible = true;
            admindelete.BringToFront();
        }
    }
}

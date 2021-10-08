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
            adminadd.Visible = true;
            adminupdate.Visible = false;
            admindelete.Visible = false;
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            adminupdate.Visible = true;
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

        private void Admin_Load(object sender, EventArgs e)
        {
            panelforbutton.Location = new Point(240,0);
            adminadd.Location = new Point(240,50);
            adminadd.Size = new Size(900, 400);
            adminupdate.Location = new Point(240, 50);
            adminupdate.Size = new Size(900, 400); 
            admindelete.Location = new Point(240, 50);
            admindelete.Size = new Size(900, 400);
        }

        private void Crossbutton_Click(object sender, EventArgs e)
        {
            MyGlobal.crosstimer = 1;
        }
    }
}

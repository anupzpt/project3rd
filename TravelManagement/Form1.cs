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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Aboutus_Click(object sender, EventArgs e)
        {
            aboutususercontrol.Visible = true;
            aboutususercontrol.BringToFront();
            homepageusercontrol.Visible = false;
            tourusercontrolform.Visible = false;
            trekkingusercontrol.Visible = false;
            specialusercontrol.Visible = false;
            contactusercontrol.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            login.Visible = false;
            tourusercontrolform.Visible = false;
            trekkingusercontrol.Visible = false;
            specialusercontrol.Visible = false;
            contactusercontrol.Visible = false;
            this.MinimumSize = new Size(1330,768);
        }
        
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            login.Visible = true;
            login.BringToFront();
            loginbutton2.BringToFront();
            loginbutton.SendToBack();
        }

        private void loginbutton2_Click(object sender, EventArgs e)
        {
            login.Visible = false;
            login.SendToBack();
            loginbutton2.SendToBack();
            loginbutton.BringToFront();
        }

        private void Trekking_Click(object sender, EventArgs e)
        {
            trekkingusercontrol.Visible = true;
            trekkingusercontrol.BringToFront();
            homepageusercontrol.Visible = false;
            tourusercontrolform.Visible = true;
            specialusercontrol.Visible = false;
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tours_Click(object sender, EventArgs e)
        {
            tourusercontrolform.BringToFront();
            tourusercontrolform.Visible = true;
            homepageusercontrol.Visible = false;
            specialusercontrol.Visible = false;
            trekkingusercontrol.Visible = false;

        }

        private void Home_Click(object sender, EventArgs e)
        {
            homepageusercontrol.Visible = true;
            homepageusercontrol.BringToFront();
            trekkingusercontrol.Visible = false;
            tourusercontrolform.Visible = false;
            specialusercontrol.Visible = false;
            contactusercontrol.Visible = false;
        }

        private void Specialbutton_Click(object sender, EventArgs e)
        {
            specialusercontrol.BringToFront();
            specialusercontrol.Visible = true;
            homepageusercontrol.Visible = false;
            trekkingusercontrol.Visible = false;
            tourusercontrolform.Visible = false;
        }

        private void Contact_Click(object sender, EventArgs e)
        {
            contactusercontrol.Visible = true;
            contactusercontrol.BringToFront(); 
            homepageusercontrol.Visible = false;
            tourusercontrolform.Visible = false;
            trekkingusercontrol.Visible = false;
            specialusercontrol.Visible = false;

        }
    }
}

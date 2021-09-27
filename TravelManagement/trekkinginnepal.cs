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
    public partial class trekkinginnepal : UserControl
    {
        public trekkinginnepal()
        {
            InitializeComponent();
        }
        private void trekkinginnepal_Load(object sender, EventArgs e)
        {
            trekkingnepal.Location = new Point(635, 45);
            bestpanel1.Location = new Point(100, 100);
            bestpanel2.Location = new Point(400, 100);
            bestpanel3.Location = new Point(700, 100);
            bestpanel4.Location = new Point(1000, 100);
            detail.Visible = false;



        }
        private void mardihimaltrekbutton_Click_1(object sender, EventArgs e)
        {
            backcoverpanel.Visible = false;
            detail.Visible = true;
            detail.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mardihimaltrekbutton_Click(object sender, EventArgs e)
        {
         //   backcoverpanel.Visible = false;
            detail.Visible = true;
            detail.BringToFront();
        }
    }

}

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
    public partial class explorenepal : UserControl
    {
        public explorenepal()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Chitwan_Click(object sender, EventArgs e)
        {

        }

        private void LUMBINI_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void explorenepal_Load(object sender, EventArgs e)
        {
            Explore.Location = new Point(600,15);
            best.Location = new Point(590, 45);
            bestpanel1.Location = new Point(100, 100);
            bestpanel2.Location = new Point(400,100);
            bestpanel3.Location = new Point(700, 100);
            bestpanel4.Location = new Point(1000, 100);
            
        }
    }
}

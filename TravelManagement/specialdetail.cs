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
    public partial class specialdetail : UserControl
    {
        public specialdetail()
        {
            InitializeComponent();
        }

        private void specialdetail_Load(object sender, EventArgs e)
        {
            specialtourlabel.Location = new Point(635, 45);
            bestpanel1.Location = new Point(100, 100);
            bestpanel2.Location = new Point(400, 100);
            bestpanel3.Location = new Point(700, 100);
            bestpanel4.Location = new Point(1000, 100);
            detail.Visible = false;
        }

        private void specialbutton1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            detail.Visible = true;
            detail.BringToFront();
        }
    }
}

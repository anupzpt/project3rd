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
    public partial class Detail : UserControl
    {
        public Detail()
        {
            InitializeComponent();
        }

        private void detailpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Detail_Load(object sender, EventArgs e)
        {
            //  detailshadowpanel.Location = new Point(0, 492);
            //   detailshadowpanel.Size = new Size(900, 400);
            panel1.Location = new Point(45,20);
            detaillabel.Location = new Point(62, 89);
            detaillabel.Size = new Size(900, 280);
            bookpanel.Location = new Point(270, 45);
            bookpanel.Size = new Size(400, 360);
        // // //  Crossbutton.Location = new Point(780,10);
        }

        private void detailshadowpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

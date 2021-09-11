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
    public partial class tourusercontrolform : UserControl
    {
        public tourusercontrolform()
        {
            InitializeComponent();
        }

        private void tourusercontrolform_Load(object sender, EventArgs e)
        {
            tour.Size = new Size(840, 489);
            tourinnepal.Location = new Point(0, 492);
            tourinnepal.Size = new Size(900, 400);
            tourlastpanel.Location = new Point(0, 1000);
        }
    }
}

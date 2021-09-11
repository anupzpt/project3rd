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
    public partial class contactusercontrol : UserControl
    {
        public contactusercontrol()
        {
            InitializeComponent();
        }

        private void contactusercontrol_Load(object sender, EventArgs e)
        {
            contactus.Size = new Size(840, 489);
            contactusdetail.Location = new Point(0, 493);
            contactusdetail.Size = new Size(900, 450);
            lastpanel.Location = new Point(0, 970);
        }
    }
}

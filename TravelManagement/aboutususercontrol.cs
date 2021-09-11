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
    public partial class aboutususercontrol : UserControl
    {
        public aboutususercontrol()
        {
            InitializeComponent();
        }

        private void aboutususercontrol_Load(object sender, EventArgs e)
        {
            aboutus.Size = new Size(840, 489);
            aboutusdetail.Location = new Point(0, 492);
            aboutusdetail.Size = new Size(900, 465);
            
            lastpanel.Size = new Size(840, 300);
            lastpanel.Location = new Point(0, 1000);
        }
    }
}

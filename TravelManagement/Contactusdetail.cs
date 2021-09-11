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
    public partial class Contactusdetail : UserControl
    {
        public Contactusdetail()
        {
            InitializeComponent();
        }

        private void Contactusdetail_Load(object sender, EventArgs e)
        {
            contactuslabel.Location = new Point(73,42);
            contactimagepanel.Location = new Point(62, 89);
            contactimagepanel.Size = new Size(500, 300);
            havequestionpanel.Location = new Point(100,20);
            havequestionpanel.Size = new Size(600, 400);
        }
    }
}

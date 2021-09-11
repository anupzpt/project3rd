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
    public partial class trekking : UserControl
    {
        public trekking()
        {
            InitializeComponent();
        }

        private void trekking_Load(object sender, EventArgs e)
        {
            trekkingtext.Location = new Point(750, 45);
        }
    }
}

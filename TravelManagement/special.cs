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
    public partial class special : UserControl
    {
        public special()
        {
            InitializeComponent();
        }

        private void special_Load(object sender, EventArgs e)
        {
            experiencetext.Location = new Point(550,255);
        }
    }
}

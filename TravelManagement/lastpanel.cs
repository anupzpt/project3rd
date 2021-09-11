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
    public partial class lastpanel : UserControl
    {
        public lastpanel()
        {
            InitializeComponent();
        }

        private void lastpanel_Load(object sender, EventArgs e)
        {
            fronthome.Size = new Size(600,150);
            contactus.Size = new Size(500,150);
            home.Location = new Point(150, 20);
            aboutus.Location = new Point(150, 55);
            faq.Location = new Point(150, 85);
            blogs.Location = new Point(440, 20);
            review.Location = new Point(440, 55);
            special.Location = new Point(440, 85);
            contactus.Location = new Point(490, 2);
            travel.Location = new Point(435, 15);
        }
    }
}

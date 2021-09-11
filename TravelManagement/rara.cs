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
    public partial class rara : UserControl
    {
        public rara()
        {
            InitializeComponent();
        }

        private void rara_Load(object sender, EventArgs e)
        {
            have.Location = new Point(450, 18);
            middlerara.Location = new Point(700, 15);
            recently.Location = new Point(800, 18);
            textofrara.Location = new Point(200, 100);
            readmore.Location = new Point(600,200);
        }
    }
}

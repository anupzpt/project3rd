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
    public partial class afterloggedadmin : UserControl
    {
        public afterloggedadmin()
        {
            InitializeComponent();
        }
        private void afterloggedadmin_Load(object sender, EventArgs e)
        {
            Refreshhtimer.Start();
        }
        private void passwordbutton_Click(object sender, EventArgs e)
        {

        }

       

        private void Refreshhtimer_Tick(object sender, EventArgs e)
        {
            adminlabel.Text = MyGlobal.username;
        }
    }
}

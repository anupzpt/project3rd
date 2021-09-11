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
    public partial class login : UserControl
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            logincircle.Enabled = false;
            crossbutton.Visible = false;
            crossbutton.SendToBack();
            loggedin.Visible = false;

        }

        private void Admin_Click(object sender, EventArgs e)
        {
            loggedin.Visible = true;
            loggedin.BringToFront();
            crossbutton.Visible = true;
            crossbutton.BringToFront();

            
        }

        private void User_Click(object sender, EventArgs e)
        {
            loggedin.BringToFront();
            crossbutton.Visible = true;
            crossbutton.BringToFront();
            loggedin.Visible = true;
        }

        private void crossbutton_Click(object sender, EventArgs e)
        {
            loggedin.SendToBack();
            crossbutton.Visible = false;
            crossbutton.SendToBack();
            loggedin.Visible = false;
        }
    }
}

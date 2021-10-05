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
    public partial class adminfrontpage : UserControl
    {
        public adminfrontpage()
        {
            InitializeComponent();
        }
        private void adminfrontpage_Load(object sender, EventArgs e)
        {
           tourpanel.Location = new Point(100, 25);
            trekpanel.Location = new Point(400, 25);
            specialpanel.Location = new Point(700, 25);
            homepanel.Location = new Point(1000, 25);
            tourimage.Location = new Point(100, 230);
            trekimage.Location = new Point(400, 230);
            specialimage.Location = new Point(700,230);
            homeimage.Location = new Point(1000, 230);
            admin.Visible = false;
            Crossbutton.Visible = false;

        }

        private void tourpicturebox_MouseDown(object sender, MouseEventArgs e)
        {
            MyGlobal.admininfo=1;
            admin.Visible = true;
            Crossbutton.Visible = true;
            Crossbutton.BringToFront();
            adminforntpagepanel.Visible = false;
            admin.BringToFront();
        }

        private void trekpicturebox_MouseDown(object sender, MouseEventArgs e)
        {
            MyGlobal.admininfo = 2;
            admin.Visible = true;
            Crossbutton.Visible = true;
            Crossbutton.BringToFront();
            adminforntpagepanel.Visible = false;
            admin.BringToFront();

        }

        private void specialpicturebox_MouseDown(object sender, MouseEventArgs e)
        {
            MyGlobal.admininfo = 3;
            admin.Visible = true;
            Crossbutton.Visible = true;
            Crossbutton.BringToFront();
            adminforntpagepanel.Visible = false;
            admin.BringToFront();

        }

        private void homepicturebox_MouseDown(object sender, MouseEventArgs e)
        {
            MyGlobal.admininfo = 4;
            admin.Visible = true;
            Crossbutton.Visible = true;
            Crossbutton.BringToFront();
            adminforntpagepanel.Visible = false;
            admin.BringToFront();

        }

        private void tourimagepicturebox_MouseDown(object sender, MouseEventArgs e)
        {
            MyGlobal.admininfo = 5;
            admin.Visible = true;
            Crossbutton.Visible = true;
            Crossbutton.BringToFront();
            adminforntpagepanel.Visible = false;
            admin.BringToFront();
        }

        private void trekimagepicturebox_MouseDown(object sender, MouseEventArgs e)
        {
            MyGlobal.admininfo = 6;
            admin.Visible = true;
            Crossbutton.Visible = true;
            Crossbutton.BringToFront();
            adminforntpagepanel.Visible = false;
            admin.BringToFront();
        }

        private void specialimagepicturebox_MouseDown(object sender, MouseEventArgs e)
        {
            MyGlobal.admininfo = 7;
            admin.Visible = true;
            Crossbutton.Visible = true;
            Crossbutton.BringToFront();
            adminforntpagepanel.Visible = false;
            admin.BringToFront();
        }

        private void homeimagepicturebox_MouseDown(object sender, MouseEventArgs e)
        {
            MyGlobal.admininfo = 8;
            admin.Visible = true;
            Crossbutton.Visible = true;
            Crossbutton.BringToFront();
            adminforntpagepanel.Visible = false;
            admin.BringToFront();
        }

        private void Crossbutton_Click(object sender, EventArgs e)
        {
            adminforntpagepanel.Visible = true;
        }
    }
}

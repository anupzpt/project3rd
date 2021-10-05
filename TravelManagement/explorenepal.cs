using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelManagement
{
    public partial class explorenepal : UserControl
    {
        public explorenepal()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Crossbutton.Visible = false;

        }

        private void explorenepal_Load(object sender, EventArgs e)
        {
            Explore.Location = new Point(600,15);
            best.Location = new Point(590, 45);
            bestpanel1.Location = new Point(100, 100);
            bestpanel2.Location = new Point(400,100);
            bestpanel3.Location = new Point(700, 100);
            bestpanel4.Location = new Point(1000, 100);
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            try
            {
                con.Open();
                string image = "Select * from hompagechangepanel";
                SqlDataAdapter sda = new SqlDataAdapter(image, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string destination = dt.Rows[0]["hompagelocation"].ToString();
                string destination1 = dt.Rows[1]["hompagelocation"].ToString();
                string destination2 = dt.Rows[2]["hompagelocation"].ToString();
                string destination3 = dt.Rows[3]["hompagelocation"].ToString(); 
                string label = dt.Rows[0]["hompagepricelabel"].ToString();
                string label1 = dt.Rows[1]["hompagepricelabel"].ToString();
                string label2 = dt.Rows[2]["hompagepricelabel"].ToString();
                string label3 = dt.Rows[3]["hompagepricelabel"].ToString();
                string bestpanel = dt.Rows[0]["hompagepicture"].ToString();
                string bestpanel1 = dt.Rows[1]["hompagepicture"].ToString();
                string bestpanel2 = dt.Rows[2]["hompagepicture"].ToString();
                string bestpanel3 = dt.Rows[3]["hompagepicture"].ToString();
                pictureBox1.Image = Image.FromFile(bestpanel);
                pictureBox2.Image = Image.FromFile(bestpanel1);
                pictureBox3.Image = Image.FromFile(bestpanel2);
                pictureBox4.Image = Image.FromFile(bestpanel3);
                homepagebutton1.Text = destination;
                homepagebutton2.Text = destination1;
                homepagebutton3.Text = destination2;
                homepagebutton4.Text = destination3;
                homepagelabel1.Text = label;
                homepagelabel2.Text = label1;
                homepagelabel3.Text = label2;
                homepagelabel4.Text = label3;

            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        

        private void homepagebutton1_Click(object sender, EventArgs e)
        {
            detail.Visible = true;
            detail.BringToFront();
            Crossbutton.Visible = true;
            Crossbutton.BringToFront();
        }

        private void homepagebutton2_Click(object sender, EventArgs e)
        {
            detail.Visible = true;
            detail.BringToFront();
            Crossbutton.Visible = true;
            Crossbutton.BringToFront();
        }

        private void homepagebutton3_Click(object sender, EventArgs e)
        {
            detail.Visible = true;
            detail.BringToFront();
            Crossbutton.Visible = true;
            Crossbutton.BringToFront();
        }

        private void homepagebutton4_Click(object sender, EventArgs e)
        {
            detail.Visible = true;
            detail.BringToFront();
            Crossbutton.Visible = true;
            Crossbutton.BringToFront();
        }

        private void Crossbutton_Click_1(object sender, EventArgs e)
        {
            detail.Visible = false;

        }
    }
}

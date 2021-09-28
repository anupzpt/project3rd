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
    public partial class trekkinginnepal : UserControl
    {
        public trekkinginnepal()
        {
            InitializeComponent();
        }
        int SN = 4;

        private void trekkinginnepal_Load(object sender, EventArgs e)
        {
            trekkingnepal.Location = new Point(635, 45);
            bestpanel1.Location = new Point(100, 100);
            bestpanel2.Location = new Point(400, 100);
            bestpanel3.Location = new Point(700, 100);
            bestpanel4.Location = new Point(1000, 100);
            detail.Visible = false;
            SqlConnection con = new SqlConnection(MyGlobal.constring);
           try
            {
                con.Open();
                string image = "Select * from trekchangepanel";
                SqlDataAdapter sda = new SqlDataAdapter(image, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string destination = dt.Rows[0]["treklocation"].ToString();
                string destination1 = dt.Rows[1]["treklocation"].ToString();
                string destination2 = dt.Rows[2]["treklocation"].ToString();
                string destination3 = dt.Rows[3]["treklocation"].ToString();
                string bestpanel = dt.Rows[0]["trekpicture"].ToString();
                string bestpanel1 = dt.Rows[1]["trekpicture"].ToString();
                string bestpanel2 = dt.Rows[2]["trekpicture"].ToString();
                string bestpanel3 = dt.Rows[3]["trekpicture"].ToString();
                pictureBox1.Image = Image.FromFile(bestpanel);
                pictureBox2.Image = Image.FromFile(bestpanel1);
                pictureBox3.Image = Image.FromFile(bestpanel2);
                pictureBox4.Image = Image.FromFile(bestpanel3);
                trekbutton1.Text = destination;
                trekbutton2.Text = destination1;
                trekbutton3.Text = destination2;
                trekbutton4.Text = destination3;

            }
            catch (Exception ex)
            {

            }
            finally
            {

            }

    }
        private void mardihimaltrekbutton_Click_1(object sender, EventArgs e)
        {
            backcoverpanel.Visible = false;
            detail.Visible = true;
            detail.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mardihimaltrekbutton_Click(object sender, EventArgs e)
        {
         //   backcoverpanel.Visible = false;
            detail.Visible = true;
            detail.BringToFront();
        }

        private void right_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            int count = 1;
            for (int i = 1; i <= 4; i++)
            {
                try
                {
                    con.Open();

                    string image = "Select * from trekchangepanel";
                    SqlDataAdapter sda = new SqlDataAdapter(image, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    string bestpanel = dt.Rows[SN]["trekpicture"].ToString();
                    string destination = dt.Rows[SN]["treklocation"].ToString();

                    if (count == 1)
                    {
                        SN = SN + 1;
                        pictureBox1.Image = Image.FromFile(bestpanel);
                        trekbutton1.Text = destination;

                    }
                    if (count == 2)
                    {
                        SN = SN + 1;
                        pictureBox2.Image = Image.FromFile(bestpanel);
                        trekbutton2.Text = destination;

                    }
                    if (count == 3)
                    {
                        SN = SN + 1;
                        pictureBox3.Image = Image.FromFile(bestpanel);
                        trekbutton3.Text = destination;

                    }
                    if (count == 4)
                    {
                        SN = SN + 1;
                        pictureBox4.Image = Image.FromFile(bestpanel);
                        trekbutton4.Text = destination;

                        count = 1;
                    }
                    count++;
                }
                catch (Exception ex)
                {
                    if (count == 1)
                    {
                        bestpanel1.Visible = false;
                        count++;
                    }
                    if (count == 2)
                    {
                        bestpanel2.Visible = false;
                        count++;
                    }
                    if (count == 3)
                    {
                        bestpanel3.Visible = false;

                        count++;
                    }
                    if (count == 4)
                    {
                        bestpanel4.Visible = false;

                        count++;
                    }
                }
                finally
                {
                    con.Close();
                }

            }
        }

        private void left_Click(object sender, EventArgs e)
        {

        }
    }

}

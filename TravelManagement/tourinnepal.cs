using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelManagement
{
    public partial class tourinnepal : UserControl
    {
        public tourinnepal()
        {
            InitializeComponent();
        }
         int SN = 4;

        private void tourinnepal_Load(object sender, EventArgs e)
        {
            lost.Visible = false;
            tournepal.Location = new Point(635, 45);
            bestpanel1.Location = new Point(100, 100);
            bestpanel2.Location = new Point(400, 100);
            bestpanel3.Location = new Point(700, 100);
            bestpanel4.Location = new Point(980, 80);
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            try
            {

                con.Open();
                string image = "Select * from changepanel";
                SqlDataAdapter sda = new SqlDataAdapter(image, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string destination = dt.Rows[0]["Location"].ToString();
                string destination1 = dt.Rows[1]["Location"].ToString();
                string destination2 = dt.Rows[2]["Location"].ToString();
                string destination3 = dt.Rows[3]["Location"].ToString();
                string label = dt.Rows[0]["Pricelabel"].ToString();
                string label1 = dt.Rows[1]["Pricelabel"].ToString();
                string label2 = dt.Rows[2]["Pricelabel"].ToString();
                string label3 = dt.Rows[3]["Pricelabel"].ToString();
                string bestpanel = dt.Rows[0]["Picture"].ToString();
                string bestpanel1 = dt.Rows[1]["Picture"].ToString();
                string bestpanel2 = dt.Rows[2]["Picture"].ToString();
                string bestpanel3 = dt.Rows[3]["Picture"].ToString();
                pictureBox1.Image = Image.FromFile(bestpanel);
                pictureBox2.Image = Image.FromFile(bestpanel1);
                pictureBox3.Image = Image.FromFile(bestpanel2);
                pictureBox4.Image = Image.FromFile(bestpanel3);
                tourbutton1.Text = destination;
                tourbutton2.Text = destination1;
                tourbutton3.Text = destination2;
                tourbutton4.Text = destination3;
                tourlabel1.Text = label;
                tourlabel2.Text = label1;
                tourlabel3.Text = label2;
                tourlabel4.Text = label3;

            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        private void Crossbutton_Click(object sender, EventArgs e)
        {
            detail.Visible = false;
        }
       // int SN = 0;
        int flag = 1;
        private void right_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                SN = SN + 5;
                flag = 1;
            }
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            int count = 1;
            for (int i = 1; i <= 4; i++)
            {
                try
                {
                    con.Open();
                    string image = "Select * from changepanel";
                    SqlDataAdapter sda = new SqlDataAdapter(image, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    string bestpanel = dt.Rows[SN]["Picture"].ToString();
                    string destination = dt.Rows[SN]["Location"].ToString();
                    string label = dt.Rows[SN]["Pricelabel"].ToString();

                    if (count == 1)
                    {
                        SN = SN + 1;
                        pictureBox1.Image = Image.FromFile(bestpanel);
                        tourbutton1.Text = destination;
                        tourlabel1.Text = label;
                    }
                    if (count == 2)
                    {
                        SN = SN + 1;
                        pictureBox2.Image = Image.FromFile(bestpanel);
                        tourbutton2.Text = destination;
                        tourlabel2.Text = label;

                    }
                    if (count == 3)
                    {
                        SN = SN + 1;
                        pictureBox3.Image = Image.FromFile(bestpanel);
                        tourbutton3.Text = destination;
                        tourlabel3.Text = label;

                    }
                    if (count == 4)
                    {
                        SN = SN + 1;
                        pictureBox4.Image = Image.FromFile(bestpanel);
                        tourbutton4.Text = destination;
                        tourlabel4.Text = label;

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

        private void tourbutton1_Click(object sender, EventArgs e)
        {
            detail.Visible = true;
            detail.BringToFront();
            Crossbutton.Visible = true;
            Crossbutton.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Crossbutton.Visible = false;
        }

        private void tourbutton2_Click(object sender, EventArgs e)
        {
            detail.Visible = true;
            detail.BringToFront();
            Crossbutton.Visible = true;
            Crossbutton.BringToFront();
        }

        private void tourbutton3_Click(object sender, EventArgs e)
        {
            detail.Visible = true;
            detail.BringToFront();
            Crossbutton.Visible = true;
            Crossbutton.BringToFront();
        }

        private void tourbutton4_Click(object sender, EventArgs e)
        {
            detail.Visible = true;
            detail.BringToFront();
            Crossbutton.Visible = true;
            Crossbutton.BringToFront();
        }

        private void left_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                SN = SN - 5;
                flag = 0;
            }
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            int count = 1;
            for (int i = 1; i <= 4; i++)
            {
               // MessageBox.Show(SN.ToString());
                try
                {
                    con.Open();
                    string image = "Select * from changepanel";
                    SqlDataAdapter sda = new SqlDataAdapter(image, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    string bestpanel = dt.Rows[SN]["Picture"].ToString();
                    string destination = dt.Rows[SN]["Location"].ToString();
                    string label = dt.Rows[SN]["Pricelabel"].ToString();

                    if (count == 1)
                    {
                       
                        pictureBox1.Image = Image.FromFile(bestpanel);
                        tourbutton1.Text = destination;
                        tourlabel1.Text = label;
                        SN--;
                    }
                    if (count == 2)
                    {
                        
                        pictureBox2.Image = Image.FromFile(bestpanel);
                        tourbutton2.Text = destination;
                        tourlabel2.Text = label;
                        SN--;

                    }
                    if (count == 3)
                    {
                      
                        pictureBox3.Image = Image.FromFile(bestpanel);
                        tourbutton3.Text = destination;
                        tourlabel3.Text = label;
                        SN--;

                    }
                    if (count == 4)
                    {
                        
                        pictureBox4.Image = Image.FromFile(bestpanel);
                        tourbutton4.Text = destination;
                        tourlabel4.Text = label;
                        SN--;

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
    }
}

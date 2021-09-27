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
            detail.Visible = false;
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
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }
        

        private void right_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            int count = 1;
            for (int i=1;i<=4; i++)
            {
                try
                {
                    con.Open();
                    
                     string image = "Select * from changepanel";
                        SqlDataAdapter sda = new SqlDataAdapter(image, con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        string bestpanel = dt.Rows[SN]["Picture"].ToString();
                        if (count == 1)
                        {
                            SN = SN + 1;
                            pictureBox1.Image = Image.FromFile(bestpanel);
                        }
                        if (count == 2)
                        {
                            SN = SN + 1;
                            pictureBox2.Image = Image.FromFile(bestpanel);
                        }
                        if (count == 3)
                        {
                            SN = SN + 1;
                            pictureBox3.Image = Image.FromFile(bestpanel);
                        }
                        if (count == 4)
                        {
                            SN = SN + 1;
                            pictureBox4.Image = Image.FromFile(bestpanel);
                            count = 1;
                        }
                        count++;
                }
                catch (Exception ex)
                {
                    if(count ==1)
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
            panel1.Visible = false;
            detail.Visible = true;
            detail.BringToFront();

        }
    }
}

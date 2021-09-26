using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
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
            experiencetext.Location = new Point(520, 120);
            string SN = "2";
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            string image = "Select * from imagetable where SN = '" + SN + "'";
            SqlDataAdapter sda = new SqlDataAdapter(image, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string specialpicture = dt.Rows[0]["Special"].ToString();
            panel.BackgroundImage = Image.FromFile(specialpicture);
        }
        int SN = 1;
        private void right_Click(object sender, EventArgs e)
        {
            try
            {
                SN = SN + 1;
                SqlConnection con = new SqlConnection(MyGlobal.constring);
                string image = "Select * from imagetable where SN = '" + SN + "'";
                SqlDataAdapter sda = new SqlDataAdapter(image, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string specialpicture = dt.Rows[0]["Special"].ToString();
                panel.BackgroundImage = Image.FromFile(specialpicture);
            }
            catch (Exception ex)
            {
                SN = 1;
                SqlConnection con = new SqlConnection(MyGlobal.constring);
                string image = "Select * from imagetable where SN = '" + SN + "'";
                SqlDataAdapter sda = new SqlDataAdapter(image, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string specialpicture = dt.Rows[0]["Special"].ToString();
                panel.BackgroundImage = Image.FromFile(specialpicture);
            }
            finally
            {

            }
        }

        private void left_Click(object sender, EventArgs e)
        {
            try
            {
                SN = SN - 1;
                SqlConnection con = new SqlConnection(MyGlobal.constring);
                string image = "Select * from imagetable where SN = '" + SN + "'";
                SqlDataAdapter sda = new SqlDataAdapter(image, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string specialpicture = dt.Rows[0]["Special"].ToString();
                panel.BackgroundImage = Image.FromFile(specialpicture);
            }
            catch (Exception ex)
            {
                SN = 1;
            }
            finally
            {

            }
        }
    }
}

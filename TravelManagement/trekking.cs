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
    public partial class trekking : UserControl
    {
        public trekking()
        {
            InitializeComponent();
        }

        private void trekking_Load(object sender, EventArgs e)
        {
            trektext.Location = new Point(520, 150);
            string SN = "1";
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            string image = "Select * from imagetable where SN = '" + SN + "'";
            SqlDataAdapter sda = new SqlDataAdapter(image, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string trekpicture = dt.Rows[0]["Trekking"].ToString();
            trekimagepanel.BackgroundImage = Image.FromFile(trekpicture);

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
                string trekpicture = dt.Rows[0]["Trekking"].ToString();
                trekimagepanel.BackgroundImage = Image.FromFile(trekpicture);
            }
            catch (Exception ex)
            {
                SN = 1;
                SqlConnection con = new SqlConnection(MyGlobal.constring);
                string image = "Select * from imagetable where SN = '" + SN + "'";
                SqlDataAdapter sda = new SqlDataAdapter(image, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string trekpicture = dt.Rows[0]["Trekking"].ToString();
                trekimagepanel.BackgroundImage = Image.FromFile(trekpicture);
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
                string trekpicture = dt.Rows[0]["Trekking"].ToString();
                trekimagepanel.BackgroundImage = Image.FromFile(trekpicture);
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

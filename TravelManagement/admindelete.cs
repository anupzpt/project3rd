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
    public partial class admindelete : UserControl
    {
        public admindelete()
        {
            InitializeComponent();
        }
        string location;

        private void admindelete_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            try
            {
                con.Open();
                string image = "Select *from changepanel";

                //string image1 = "Select * from treklocation";
                //string image2 = "Select * from hompagelocation";
                //string image3 = "Select * from speciallocation";
                SqlDataAdapter sda = new SqlDataAdapter(image, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                for (int i = 0; ;)
                {
                    string destionation = dt.Rows[i]["Location"].ToString();
                    selectComboBox.Items.Add(destionation);

                    i++;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {

            }
        }



        private void selectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            location = selectComboBox.Text;
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            con.Open();
            string query = "Select *From changepanel Where CONVERT(VARCHAR,Location)='" + selectComboBox.Text + "';";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            descriptiontextbox.Text = dt.Rows[0]["Descripition"].ToString();
            Durationtextbox.Text = dt.Rows[0]["Duration"].ToString();
            transporttextbox.Text = dt.Rows[0]["Transport"].ToString();
            accomodationtextbox.Text = dt.Rows[0]["Accomodation"].ToString();
            destinationtextbox.Text = dt.Rows[0]["Location"].ToString();
            trippricetextbox.Text = dt.Rows[0]["Pricelabel"].ToString();
            imagetextbox.Text = dt.Rows[0]["Picture"].ToString();
            imagepicturebox.Image = Image.FromFile(imagetextbox.Text);

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from changepanel where CONVERT(VARCHAR, Location)='" + selectComboBox.Text + "'";
            cmd.ExecuteNonQuery();
            descriptiontextbox.Text = null;
        }
    }      
}

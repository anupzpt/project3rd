﻿using System;
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
    public partial class homepage : UserControl
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void homepage_Load(object sender, EventArgs e)
        {
            string SN = "1";
            SqlConnection con = new SqlConnection(MyGlobal.constring);
            string image="Select * from imagetable where SN = '"+ SN +"'";
            SqlDataAdapter sda = new SqlDataAdapter(image, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string homepagepicture =dt.Rows[0]["Homepage"].ToString();
            homepagepanel.BackgroundImage = Image.FromFile(homepagepicture);

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
                string homepagepicture = dt.Rows[0]["Homepage"].ToString();
                homepagepanel.BackgroundImage = Image.FromFile(homepagepicture);
            }
            catch (Exception ex)
            {
                SN = 1;
                SqlConnection con = new SqlConnection(MyGlobal.constring);
                string image = "Select * from imagetable where SN = '" + SN + "'";
                SqlDataAdapter sda = new SqlDataAdapter(image, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string homepagepicture = dt.Rows[0]["Homepage"].ToString();
                homepagepanel.BackgroundImage = Image.FromFile(homepagepicture);
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
                string homepagepicture = dt.Rows[0]["Homepage"].ToString();
                homepagepanel.BackgroundImage = Image.FromFile(homepagepicture);
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

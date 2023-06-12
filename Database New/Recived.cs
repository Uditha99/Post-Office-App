using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Database_New
{
    public partial class Recived : Form
    {
        DBAccess obj2 = new DBAccess();
        DataTable dtUser = new DataTable();
        public Recived()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String Post_ID = txtPostID.Text;

            
            String Recived_Date = txtDateTimePicker1.Text;
            String Current_Post_Office = txtCurrentPlace.Text;
            String Next_Locations = "NULL";
            String Send_Date = "NULL";


            SqlCommand insertComand = new SqlCommand("Update Posts_Details set Recived_Date ='" + Recived_Date + "' ,Current_Post_Office= '"+ Current_Post_Office + "',Next_Locations='"+ Next_Locations + "',Send_Date='"+ Send_Date + "'  where Post_ID = '" + Post_ID + " ' ");
            insertComand.Parameters.AddWithValue("Recived_Date", Recived_Date);
            insertComand.Parameters.AddWithValue("Send_Date", Send_Date);
            insertComand.Parameters.AddWithValue("Next_Locations", Next_Locations);
            insertComand.Parameters.AddWithValue("Current_Post_Office", Current_Post_Office);
            int row = obj2.executeQuery(insertComand);

            SqlCommand insertComand2 = new SqlCommand("Select Post_ID,Recived_Date,Current_Post_Office from Posts_Details where Post_ID='" + Post_ID + "' ");
            int row1 = obj2.executeQuery(insertComand2);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(insertComand2);
            DataTable dtUser = new DataTable();
            sqlDataAdapter.Fill(dtUser);
            DataGridView1.DataSource = dtUser;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            welcome welcome = new welcome();
            welcome.Show();
        }

    }
}

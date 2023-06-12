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
    public partial class Sending_Details : Form
    {
        DBAccess obj2 = new DBAccess();
        DataTable dtUser = new DataTable();
        public Sending_Details()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
                String Post_ID = txtPostID.Text;
           
                String Next_Locations = txtNextDestination.Text;
                 String Send_Date = txtDateTimePicker1.Text;
                
           
                SqlCommand insertComand = new SqlCommand("Update Posts_Details set Next_Locations ='"+Next_Locations+ "' , Send_Date='" + Send_Date + "' where Post_ID = '" + Post_ID+" ' "); 
                insertComand.Parameters.AddWithValue("Next_Locations", Next_Locations);
                insertComand.Parameters.AddWithValue("Send_Date", Send_Date);
                 int row = obj2.executeQuery(insertComand);



            SqlCommand insertComand2 = new SqlCommand("Select Post_ID,Next_Locations,Send_Date from Posts_Details where Post_ID='" + Post_ID + "' ");
            int row1 = obj2.executeQuery(insertComand2);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(insertComand2);
            DataTable dtUser = new DataTable();
            sqlDataAdapter.Fill(dtUser);
            DataGridView1.DataSource = dtUser;


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome welcome = new welcome();
            welcome.Show();
        }

    }
}

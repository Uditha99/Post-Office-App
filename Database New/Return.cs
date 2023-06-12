using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

using System.Data.SqlClient;
namespace Database_New
{
    public partial class Return : Form
    {
        DBAccess obj2 = new DBAccess();
        DataTable dtUser = new DataTable();
        public Return()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String Post_ID = txtPostID.Text;
            String Returned = "YES";
            String Returned_Date = txtDateTimePicker1.Text;
            String Return_Locations = txtretun.Text;

            SqlCommand insertComand = new SqlCommand("Update Posts_Details set Returned ='" + Returned + "' , Returned_Date='" + Returned_Date + "',Return_Locations='"+ Return_Locations + "' where Post_ID = '" + Post_ID + " ' ");
            insertComand.Parameters.AddWithValue("Returned", Returned);
            insertComand.Parameters.AddWithValue("Returned_Date", Returned_Date);
            insertComand.Parameters.AddWithValue("Return_Locations", Return_Locations);
            int row = obj2.executeQuery(insertComand);

            SqlCommand insertComand2 = new SqlCommand("Select Post_ID,Returned,Returned_Date,Return_Locations from Posts_Details where Post_ID='" + Post_ID + "' ");
            int row1 = obj2.executeQuery(insertComand2);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(insertComand2);
            DataTable dtUser = new DataTable();
            sqlDataAdapter.Fill(dtUser);
            DataGridView1.DataSource = dtUser;

            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome welcome = new welcome();
            welcome.Show();
        }

    }
}

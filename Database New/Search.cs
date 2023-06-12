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
    public partial class Search : Form
    {
        DBAccess obj2 = new DBAccess();
        DataTable dtUser = new DataTable();
        public Search()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String Post_ID=txtPostID.Text;
            SqlCommand insertComand = new SqlCommand("Select Post_ID,Reciver_Address,Returned,Returned_Date,Return_Locations from Posts_Details where Post_ID='"+ Post_ID + "' ");
            int row = obj2.executeQuery(insertComand);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(insertComand);
            DataTable dtUser = new DataTable();
            sqlDataAdapter.Fill(dtUser);
            DataGridView1.DataSource= dtUser;
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            welcome welcome = new welcome();    
            welcome.Show();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

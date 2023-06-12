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
    public partial class Newly_Accepted_Post : Form
    {
        DBAccess obj = new DBAccess();
        public Newly_Accepted_Post()
        {
            InitializeComponent();
        }



        private void btnOK_Click(object sender, EventArgs e)
        {

            String Name = txtName.Text;
            String Sender_Address = txtSender.Text;
            String Reciver_Address = txtReciever.Text;
            String Post_ID =txtPostID.Text;
            String Current_Post_Office = txtCurrent.Text;
           



            SqlCommand insertComand = new SqlCommand("insert into Posts_Details(Name,Sender_Address,Reciver_Address,Post_ID,Current_Post_Office) values( @Name, @Sender_Address, @Reciver_Address,@Post_ID,@Current_Post_Office)");

            insertComand.Parameters.AddWithValue("Name", Name);
            insertComand.Parameters.AddWithValue("Sender_Address", Sender_Address);
            insertComand.Parameters.AddWithValue("Reciver_Address", Reciver_Address);
            insertComand.Parameters.AddWithValue("Post_ID", Post_ID);
            insertComand.Parameters.AddWithValue("Current_Post_Office", Current_Post_Office);
            

            int row = obj.executeQuery(insertComand);

            SqlCommand insertComand2 = new SqlCommand("Select Name,Sender_Address,Reciver_Address,Post_ID,Current_Post_Office from Posts_Details where Post_ID='" + Post_ID + "' ");
            int row1 = obj.executeQuery(insertComand2);
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

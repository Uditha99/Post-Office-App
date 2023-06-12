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
    public partial class Login : Form
    {
        DBAccess obj2 = new DBAccess();
        DataTable dtUser = new DataTable();

        public Login()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            String name = txtUserNAme.Text;
            String password = txtPassword.Text;

            String quary = "Select * from DBPostOffice Where Post_Office_number = '" + name + "' AND Create_Password = '" + password + "'";

            obj2.readDatathroughAdapter(quary, dtUser);

            if (dtUser.Rows.Count == 1)
            {
                
                obj2.closeConn();

                this.Hide();
                welcome welcome = new welcome();
                welcome.Show();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

       
        

        
    }
}


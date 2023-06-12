using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Database_New
{
    public partial class Register : Form
    {
        DBAccess obj = new DBAccess();
        public Register()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            String Province = comboBox1.Text;
            String District = txtDistrict.Text;
            String Divisional_Secretariat = txtDivisional.Text;
            String Postal_code = txtPostal.Text;
            String Post_office_number = txtPostOfficeNumber.Text;
            String Create_Password = texPassword.Text;
            String Reenter_Password = txtReEnterPassword.Text;
        


            SqlCommand insertComand = new SqlCommand("insert into DBPostOffice(Province,District,Divisional_Secretariat,Postal_code,Post_office_number,Create_Password,Reenter_Password) values( @Province, @District, @Divisional_Secretariat,@Postal_code,@Post_office_number,@Create_Password,@Reenter_Password)");

            insertComand.Parameters.AddWithValue("Province", Province);
            insertComand.Parameters.AddWithValue("District", District);
            insertComand.Parameters.AddWithValue("Divisional_Secretariat", Divisional_Secretariat);
            insertComand.Parameters.AddWithValue("Postal_code", Postal_code);
            insertComand.Parameters.AddWithValue("Post_office_number", Post_office_number);
            insertComand.Parameters.AddWithValue("Create_Password", Create_Password);
            insertComand.Parameters.AddWithValue("Reenter_Password", Reenter_Password);

            int row = obj.executeQuery(insertComand);

            if (row == 1)
            {
                MessageBox.Show("Account Success");

                this.Hide();
                Login login = new Login();
                login.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String Province = comboBox1.Text;
            String District = txtDistrict.Text;
            String Divisional_Secretariat = txtDivisional.Text;
            String Postal_code = txtPostal.Text;
            String Post_office_number = txtPostOfficeNumber.Text;
            String Create_Password = texPassword.Text;
            String Reenter_Password = txtReEnterPassword.Text;



            SqlCommand insertComand = new SqlCommand("insert into DBPostOffice(Province,District,Divisional_Secretariat,Postal_code,Post_office_number,Create_Password,Reenter_Password) values( @Province, @District, @Divisional_Secretariat,@Postal_code,@Post_office_number,@Create_Password,@Reenter_Password)");

            insertComand.Parameters.AddWithValue("Province", Province);
            insertComand.Parameters.AddWithValue("District", District);
            insertComand.Parameters.AddWithValue("Divisional_Secretariat", Divisional_Secretariat);
            insertComand.Parameters.AddWithValue("Postal_code", Postal_code);
            insertComand.Parameters.AddWithValue("Post_office_number", Post_office_number);
            insertComand.Parameters.AddWithValue("Create_Password", Create_Password);
            insertComand.Parameters.AddWithValue("Reenter_Password", Reenter_Password);

            int row = obj.executeQuery(insertComand);

         

                this.Hide();
                Login login = new Login();
                login.Show();
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}

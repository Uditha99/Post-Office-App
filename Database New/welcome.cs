using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_New
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void btnRegisterNew_Click(object sender, EventArgs e)
        {
            Newly_Accepted_Post newly_Accepted_Post = new Newly_Accepted_Post();
            newly_Accepted_Post.Show();
            this.Close();
        }

        private void btnSendPost_Click(object sender, EventArgs e)
        {
            Sending_Details sending_Details = new Sending_Details();
            sending_Details.Show();
            this.Close();
        }

        private void btnRecived_Click(object sender, EventArgs e)
        {
            Recived recived = new Recived();
            recived.Show();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Return retu = new Return();
            retu.Show();
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Login wel = new Login();
            wel.Show();
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }
    }
}

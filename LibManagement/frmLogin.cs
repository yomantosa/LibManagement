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

namespace LibManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == "" || tb_password.Text == "")
            {
                MessageBox.Show("Please fill in the fields");
            }
            else
            {
                SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-C1548M6R\SQLEXPRESS;Initial Catalog=LibManagement;Integrated Security=True");
                string query = "SELECT * FROM [Users] WHERE username= '" + tb_username.Text.Trim() + "' AND password='" + tb_password.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count == 1)
                {
                    frmMain objfrmMain = new frmMain();
                    this.Hide();
                    objfrmMain.Show();
                }
                else
                {
                    MessageBox.Show("Check your username and password");
                }
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (tb_username.Text =="" || tb_password.Text == "")
            {
                MessageBox.Show("Please fill in the fields");
            }
            else
            {
                SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-C1548M6R\SQLEXPRESS;Initial Catalog=LibManagement;Integrated Security=True");
                string query = "SELECT * FROM [Users] WHERE username= '" + tb_username.Text.Trim() + "' AND password='" + tb_password.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count != 1)
                {
                    sqlCon.Open();
                    string queryInsert = "INSERT INTO [Users] VALUES ('" + tb_username.Text + "', '" + tb_password.Text+"' )";
                    SqlCommand cmd = new SqlCommand(queryInsert, sqlCon);
                    cmd.ExecuteNonQuery();
                    sqlCon.Close();
                    MessageBox.Show("Registereation is successfull");
                    Clear();
                }
                else
                {
                    MessageBox.Show("The username is already Taken!");
                }
            }
        }

        void Clear()
        {
            tb_username.Text = tb_password.Text = "";
        }
    }
}

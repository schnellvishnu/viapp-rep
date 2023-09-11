using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace responsive_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string uname = txtUsername.Text;
            string pass = txtPassword.Text;
            string login = "login";
            string operator1= "operator";
            string description = "34243242342hhjjj234abc";
            string date = DateTime.Now.ToString();
            string strConnString = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=DB4";
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            NpgsqlCommand cmd = new NpgsqlCommand();
            string sql = "SELECT * FROM accounts_register where email='" + uname + "' and password='" + pass + "' ";
            
            string sql1= "INSERT INTO accounts_history VALUES('',3,'"+ login +"','" + uname + "','" + operator1 + "' ," + date + ",'" +description + "')";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sql1, conn);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            da.Fill(dt);
            da.Fill(dt1);
          //  string timestamp = dt1.ToString("MM/dd/yyyy HH:mm:ss",
                           //   CultureInfo.InvariantCulture);
            //da1.Fill(dt1);
            
            cmd.Connection = conn;
            conn.Open();
            if (dt.Rows.Count > 0)

            {
               
                TNTDashboardForm2 f2 = new TNTDashboardForm2();
                f2.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Login failed,Incorrect username or password");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

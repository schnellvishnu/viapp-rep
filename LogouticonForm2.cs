using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace responsive_app
{
    public partial class LogouticonForm2 : Form
    {
        public LogouticonForm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = txtusername.Text;
            string pass = txtpassword.Text;
            string login = "logout";
            string operator1 = "operator";

            string strConnString = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=DB4";
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            NpgsqlCommand cmd = new NpgsqlCommand();
            string sql = "SELECT * FROM accounts_register where email='" + uname + "' and password='" + pass + "' ";

            string sql1 = "INSERT INTO accounts_history VALUES('',3,'" + login + "','" + uname + "','" + operator1 + "' ,'" + DateTime.Now + "')";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sql1, conn);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            da.Fill(dt);
            da.Fill(dt1);

            cmd.Connection = conn;
            conn.Open();
            if (dt.Rows.Count > 0)

            {
                this.Close();
                Form1 f1 = new Form1();
                f1.Show();
                MessageBox.Show("Logout successfully");


            }
            else
            {

                MessageBox.Show("Login failed,Incorrect username or password");
            }
        }

        private void LogouticonForm2_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
    }
}

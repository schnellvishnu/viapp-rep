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
using System.Configuration;

namespace responsive_app
{
    public partial class ChangepasswordiconForm2 : Form
    {
        public ChangepasswordiconForm2()
        {
            InitializeComponent();
            panel1.Hide();
           
        }

        private void txtoldpass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string uname = txtUsername.Text;
            string pass = txtoldpass.Text;
            string strConnString = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=db1";
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            NpgsqlCommand cmd = new NpgsqlCommand();
            string sql = "SELECT * FROM accounts_register where  password='" + pass + "' ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Connection = conn;
            conn.Open();
            if (dt.Rows.Count > 0)

            {

                panel1.Show();
            }
            else
            {

                MessageBox.Show("wrong password");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string uname = txtusername.Text;
            string newpass = txtnewpass.Text;
            string pass = txtoldpass.Text;
            string conpass = txtconpass.Text;
            string strConnString = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=db1";
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            NpgsqlCommand cmd = new NpgsqlCommand();
            
            if (newpass == conpass)
            {
                string sql = "update accounts_register set password= '" + newpass + "' where  email='" + uname + "' ";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmd.Connection = conn;
                conn.Open();
                MessageBox.Show("Password changed successfully");
            }
         
            else
            {

                MessageBox.Show("new password and cofirm password are not match");
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string uname = txtusername.Text;
            string newpass = txtnewpass.Text;
            string pass = txtoldpass.Text;
            string conpass = txtconpass.Text;
            string strConnString = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=db1";
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);

            NpgsqlCommand cmd = new NpgsqlCommand();

            if (newpass == conpass)
            {
                string sql = "update accounts_register set password= '" + newpass + "' where  email='" + uname + "' ";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmd.Connection = conn;
                conn.Open();
                MessageBox.Show("Password changed successfully");
            }

            else
            {

                MessageBox.Show("new password and cofirm password are not match");
            }
        }

        private void ChangepasswordiconForm2_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
    }
}

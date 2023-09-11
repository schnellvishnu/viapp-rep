using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace responsive_app
{
    public partial class batchForm2 : Form
    {
        public batchForm2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void batchForm2_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string line = txtline.Text;
            string strConnString = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=db1";
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);
            string sql = "SELECT process_order_number,batch_number FROM masterapp_productionorder where line ='" + line + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
     
            conn.Open();

            using (NpgsqlDataReader saReader = cmd.ExecuteReader())
            {
                while (saReader.Read())
                {
                    string process_order_number = saReader.GetString(0);
                    ;
                    cmbline.Items.Add(process_order_number);
                    
                }
            }
            conn.Close();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string line = cmbline.Text;
            string strConnString = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=db1";
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);
            string sql = "SELECT batch_number FROM masterapp_productionorder where process_order_number ='" + line + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

            conn.Open();

            using (NpgsqlDataReader saReader = cmd.ExecuteReader())
            {
                while (saReader.Read())
                {
                    string batch_number = saReader.GetString(0);

                    listjob.Items.Add("Batch Number :" +batch_number);
                    listjob.Items.Add("Available Quantity :");
                    listjob.Items.Add("Total CameraInspected :");
                    listjob.Items.Add("Camera Accepted :");
                    listjob.Items.Add("Camera Rejected :");

                }
            }
            conn.Close();
        }

        private void txtline_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

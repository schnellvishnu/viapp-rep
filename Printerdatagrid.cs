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
    public partial class Printerdatagrid : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        public Printerdatagrid()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowindex];
            printerjobs p2= new printerjobs(row.Cells[2].Value.ToString());
            p2.Show();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowindex];
            printerjobs p2 = new printerjobs(row.Cells[2].Value.ToString());
            p2.Show();
        }
   
       
        private void Printerdatagrid_Load(object sender, EventArgs e)
        {
           

            string strConnString = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=DB4";
            try
            {
                // Making connection with Npgsql provider
               
                NpgsqlConnection conn = new NpgsqlConnection(strConnString);
                conn.Open();
                // quite complex sql statement
                string sql = "SELECT id,processordernumber,gtin FROM masterapp_printerdatatable";
                // data adapter making request from our connection
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                // i always reset DataSet before i do
                // something with it.... i don't know why :-)
                ds.Reset();
                // filling DataSet with result from NpgsqlDataAdapter
                da.Fill(ds);
                // since it C# DataSet can handle multiple tables, we will select first
                dt = ds.Tables[0];
                // connect grid to DataTable
                dataGridView1.DataSource = dt;
                // since we only showing the result we don't need connection anymore
                conn.Close();
                
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
    }


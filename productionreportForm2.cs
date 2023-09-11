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
    public partial class productionreportForm2 : Form
    {
        public productionreportForm2()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string batch = txtbatch.Text;
            string strConnString = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=db1";
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);
            string sql = "SELECT process_order_number,product_name,manufacture_loc_name,line_name,system_name FROM reportapp_productionreport where batch_number ='" + batch + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

            conn.Open();

            using (NpgsqlDataReader saReader = cmd.ExecuteReader())
            {
                while (saReader.Read())
                {
                    string process_order_number = saReader.GetString(0);
                    string product_name = saReader.GetString(1);
                    string manufacture_loc_name = saReader.GetString(2);
                    string line_name = saReader.GetString(3);
                    string system_name = saReader.GetString(4);

                    ;
                    txtpo.Text = saReader.GetValue(0).ToString();
                    txtproductname.Text = saReader.GetValue(1).ToString();
                    txtlocation.Text = saReader.GetValue(2).ToString();
                    txtline.Text = saReader.GetValue(3).ToString();
                    txtsystem.Text = saReader.GetValue(4).ToString();

                }
            }
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string batch =txtbatch.Text;
            string strConnString = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=db1";
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);
            string sql = "SELECT accepted,specimen,damaged,sample,challenged,teach,inprocess,rejectedbycamera,unused FROM reportapp_productionreport where batch_number ='" + batch+ "'";
            DataTable table = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand cmd = new NpgsqlCommand(sql,conn);
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            conn.Open();


            using (NpgsqlDataReader saReader = cmd.ExecuteReader())
            {
                while (saReader.Read())
                {
               
                    string accepted = saReader.GetString(0);
                    string specimen = saReader.GetString(1);
                    string damaged = saReader.GetString(2);
                    string sample = saReader.GetString(3);
                    string challenged = saReader.GetString(4);
                    string teach = saReader.GetString(5);
                    string inprocess = saReader.GetString(6);
                    string rejectedbycamera = saReader.GetString(7);
                    string unused = saReader.GetString(8);

                   listreport.Items.Add("Accepted :" + accepted);
                   listreport.Items.Add("Speciemen :" + specimen);
                    listreport.Items.Add("Damaged :" + damaged);
                    listreport.Items.Add("Sample :" + sample);
                    listreport.Items.Add("Challenged :" + challenged);
                    listreport.Items.Add("Teach :" + teach);
                    listreport.Items.Add("InProcess :" + inprocess);
                    listreport.Items.Add("rejectedByCamera :" + rejectedbycamera);
                    listreport.Items.Add("unused :" + unused);

                    this.chart1.DataSource = table;
                   
                    chart1.Series[0].XValueMember = "accepted";
                    chart1.Series[0].YValueMembers = "accepted";

                    chart1.Series[1].XValueMember = "specimen";
                    chart1.Series[1].YValueMembers = "specimen";


                    chart1.Series[2].XValueMember = "damaged";
                    chart1.Series[2].YValueMembers = "damaged";


                    chart1.Series[3].XValueMember = "sample";
                    chart1.Series[3].YValueMembers = "sample";


                    chart1.Series[4].XValueMember = "challenged";
                    chart1.Series[4].YValueMembers = "challenged";


                    chart1.Series[5].XValueMember = "teach";
                    chart1.Series[5].YValueMembers = "teach";


                    chart1.Series[6].XValueMember = "inprocess";
                    chart1.Series[6].YValueMembers = "inprocess";


                    chart1.Series[7].XValueMember = "rejectedbycamera";
                    chart1.Series[7].YValueMembers = "rejectedbycamera";

                    chart1.Series[8].XValueMember = "unused";
                    chart1.Series[8].YValueMembers = "unused";


                    this.chart1.DataSource = table;
                    this.chart1.DataBind();
                }
            }
            conn.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void productionreportForm2_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }
    }
}

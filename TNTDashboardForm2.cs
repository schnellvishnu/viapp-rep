using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace responsive_app
{
    public partial class TNTDashboardForm2 : Form
    {
        public TNTDashboardForm2()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm2 f1 = new mainForm2();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReworkiconForm2 f1 = new ReworkiconForm2();
            f1.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            InformationiconForm2 f1 = new InformationiconForm2();
            f1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReporticonForm2 f1 = new ReporticonForm2();
            f1.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Printerdatagrid pd = new Printerdatagrid();
            pd.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AuditlogiconForm2 f1 = new AuditlogiconForm2();
            f1.Show();
        }

        private void TNTDashboardForm2_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
    }
}

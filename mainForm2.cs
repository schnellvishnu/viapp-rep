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
    public partial class mainForm2 : Form
    {
        public mainForm2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddjobForm2 f1 = new AddjobForm2();
            f1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PreferencesiconForm2 f1 = new PreferencesiconForm2();
            f1.Show();
        }

        private void mainForm2_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TNTDashboardForm2 f1 = new TNTDashboardForm2();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            LogouticonForm2 f1 = new LogouticonForm2();
            f1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChangepasswordiconForm2 f1 = new ChangepasswordiconForm2();
            f1.Show();
        }
    }
}

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
    public partial class AddjobForm2 : Form
    {
        public AddjobForm2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            batchForm2 f1 = new batchForm2();
            f1.Show(); 
        }   
        private void AddjobForm2_Load(object sender, EventArgs e)
        {
            
        }
    }
}

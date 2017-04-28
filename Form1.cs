using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example2
{
    public partial class example2 : Form
    {
        public example2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void example2_Load(object sender, EventArgs e)
        {

        }

        private void lblExpSub_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcAdd_Click(object sender, EventArgs e)
        {
            lblAnsAdd.Text = String.Format("{0}",1+2);
        }

        private void btnCalsSub_Click(object sender, EventArgs e)
        {
            lblAnsSub.Text = String.Format("{0}",5-3);
        }

        private void btnCalcMul_Click(object sender, EventArgs e)
        {
            lblAnsMul.Text = String.Format("{0}",2*3);
        }

        private void btnCalcDiv_Click(object sender, EventArgs e)
        {
            lblAnsDiv.Text = String.Format("{0}",8/2);
        }
    }
}

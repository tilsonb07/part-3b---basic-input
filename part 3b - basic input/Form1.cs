using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace part_3b___basic_input
{
    public partial class frmlife : Form
    {
        public frmlife()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string height = txtboxheight.Text;
            string name = txtboxname.Text;
            int ageFinal;
            ageFinal = Convert.ToInt32(txtboxage.Text);
            Convert.ToDouble(height);


            ageFinal = 82 - ageFinal;

            lblmessage.Text = ($"Greetings {name}, your height is {height}m, your average years of life left is, {ageFinal}");









        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

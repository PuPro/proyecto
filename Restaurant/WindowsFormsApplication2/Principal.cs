using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();

        }
    }
}

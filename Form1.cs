using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Open Source Code by: KyrixTools */
namespace BasicLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "test")
            {
                MessageBox.Show("Successful");
                /* do something */
                /* f2 Form2 = new Form2 
                f2.Show();
                this.Hide(); */
            }
            else 
            {
              
                MessageBox.Show("Unsuccessful");
                /* do something */
            }
        }
    }
}

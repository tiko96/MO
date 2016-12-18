using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodsOfOpt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BisectionForm form = new BisectionForm();
            form.Owner = this;
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SecantForm form = new SecantForm();
            form.Owner = this;
            form.Show();
        }
    }
}

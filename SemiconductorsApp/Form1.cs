using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemiconductorsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var s1 = this.domainUpDown1.Text.ToString();
            var s2 = this.domainUpDown2.Text.ToString();
            SumCalculation sumCalc1 = new SumCalculation(s1,s2);
            this.textBox1.Text = sumCalc1.AddNumbers();
        }
    }
}

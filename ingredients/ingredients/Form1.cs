using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ingredients
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
        //This void is a click event for the next form of recipes ingredients//
        private void button1_Click(object sender, EventArgs e)
        {
            ButterChickenForm f2 = new ButterChickenForm();
            f2.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //This void is a click event for the next form of recipes ingredients//
        private void button2_Click(object sender, EventArgs e)
        {
            BarbequeRibsForm f3 = new BarbequeRibsForm();
            f3.ShowDialog();
        }
        //This void is a click event for the next form of recipes ingredients//
        private void button3_Click(object sender, EventArgs e)
        {
            LambShoulderForm f4 = new LambShoulderForm();
            f4.ShowDialog();
        }
    }
}

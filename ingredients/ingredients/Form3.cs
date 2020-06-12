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
    public partial class BarbequeRibsForm : Form
    {
        public BarbequeRibsForm()
        {
            InitializeComponent();
        }

        private void BarbequeRibsForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //This void is a click event for the download/ save of the ingredients//

        private void button1_Click(object sender, EventArgs e)
        {
            TextWriter tw = new StreamWriter("C:/Users/Isaac Gannon/Desktop/Upskilled_Projects/Barbeque_Ribs.txt");

            tw.WriteLine(textBox2.Text);


            tw.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

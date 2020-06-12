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
using System.Xml.Serialization;

namespace ingredients
{
    public partial class ButterChickenForm : Form
    {
        public ButterChickenForm()
        {
            InitializeComponent();
        }

        private void ButterChickenForm_Load(object sender, EventArgs e)
        {

        }
        //This void is a click event for the download/ save of the ingredients//
        private void button1_Click(object sender, EventArgs e)
        {
            string projectLocation = @"C:/Users/Isaac Gannon/Desktop/Upskilled_Projects/";

            TextWriter tw = new StreamWriter(projectLocation + "Butter_Chicken.txt");
            tw.WriteLine(textBox2.Text);
            tw.Close();

            //Instead of writing the above 3 lines,
            //it would be better to use
            //File.WriteAllText(projectLocation + "Butter_Chicken.txt", textBox2.Text);

            SaveTextAsXML(textBox2.Text, projectLocation + "Butter_Chicken.xml");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveTextAsXML(string text, string XML_File_Path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(string));

            using (StringWriter writer = new StringWriter())
            {
                xs.Serialize(writer, text);
                File.WriteAllText(XML_File_Path, writer.ToString());
            }

            //To open the saved XML file after writing
            System.Diagnostics.Process.Start(XML_File_Path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                TextWriter tw = new StreamWriter("C:/Users/Isaac Gannon/Desktop/Upskilled_Projects/Barbeque_Ribs.txt");

                tw.WriteLine(textBox2.Text);


                tw.Close();

            }

        }
    }
}
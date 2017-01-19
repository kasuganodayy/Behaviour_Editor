using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Behaviour_Editor
{
    public partial class Form1 : Form
    {
        public string filePath = null;

        public Form1()
        {
            filePath = "xml/Objects.xml";
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataSet1.ReadXml(filePath);

            dataGridView1.DataSource = dataSet1;
            dataGridView1.DataMember = "Npc";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Click -= button1_Click;

            // Save XML
            System.IO.FileStream stream = new System.IO.FileStream(filePath, System.IO.FileMode.Create);
            dataSet1.WriteXml(stream);

            button1.Click += button1_Click;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Click -= button2_Click;

            // Serialize XML
            Class1 test = new Class1();
            test.SerializeTest("xml/test.xml");

            button2.Click += button2_Click;
        }
    }
}

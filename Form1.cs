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
        public string filePath = "xml/Objects.xml";
        public Objects objects = new Objects();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Click -= button2_Click;
            button2.Enabled = false;

            // Serialize XML
            XMLHelper test = new XMLHelper();
            test.SerializeXML(filePath, objects);
            
            button2.Click += button2_Click;
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Click -= button3_Click;
            button3.Enabled = false;

            // Load XML
            XMLHelper test = new XMLHelper();
            objects = test.DeserialzeXML(filePath, objects);

            button3.Click += button3_Click;
        }
    }
}

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
        public List<Npc> Npcs = new List<Npc>();

        public Form1()
        {
            filePath = "xml/Objects.xml";
            InitializeComponent();

            Npcs.Add(new Npc()
            {
                name = "JoeTheDayGuard",
                pos = new Vector2(-16, 25),
                facing = new Vector2(1, 0),
                colour = new Colour(0, 0, 0, 255),
                objectOwned = new List<worldObjects> { new worldObjects("bed", "JoeBed") },
                //objectOwned.Add(new worldObjects("bed", "JoeBed")),
                actionSchedule = new schedule("DayGuard")
            });
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
            button1.Enabled = false;

            // Save XML
            System.IO.FileStream stream = new System.IO.FileStream(filePath, System.IO.FileMode.Create);
            dataSet1.WriteXml(stream);
            
            button1.Click += button1_Click;
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Click -= button2_Click;
            button2.Enabled = false;

            // Serialize XML
            XMLHelper test = new XMLHelper();
            test.SerializeXML("xml/test.xml", Npcs);
            
            button2.Click += button2_Click;
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Click -= button3_Click;
            button3.Enabled = false;

            // Load XML
            XMLHelper test = new XMLHelper();
            test.DeserialzeXML("xml/test.xml", Npcs);

            button3.Click += button3_Click;
            button3.Enabled = true;
        }
    }
}

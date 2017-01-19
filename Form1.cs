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

        private void button_Save_Click(object sender, EventArgs e)
        {
            button_Save.Click -= button_Save_Click;
            button_Save.Enabled = false;

            // Serialize XML
            XMLHelper test = new XMLHelper();
            test.SerializeXML(filePath, objects);
            
            button_Save.Click += button_Save_Click;
            button_Save.Enabled = true;
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            button_Load.Click -= button_Load_Click;
            button_Load.Enabled = false;
            button_Save.Enabled = true; // Enable Save button only after loading a file

            // Load XML
            XMLHelper test = new XMLHelper();
            objects = test.DeserialzeXML(filePath, objects);

            list_npc.DataSource = objects.Npcs;
            list_npc.DisplayMember = "m_name";
            list_gameObj.DataSource = objects.GameObjects;
            list_gameObj.DisplayMember = "m_name";

            button_Load.Click += button_Load_Click;
        }

        private void list_npc_SelectedIndexChanged(object sender, EventArgs e)
        {
            box_name.Text = objects.Npcs[list_npc.SelectedIndex].m_name;
            box_schedule.Text = objects.Npcs[list_npc.SelectedIndex].m_actionSchedule.m_name;
            box_shapeX.Text = objects.Npcs[list_npc.SelectedIndex].m_pos.x.ToString();
            box_shapeY.Text = objects.Npcs[list_npc.SelectedIndex].m_pos.y.ToString();
            box_facingX.Text = objects.Npcs[list_npc.SelectedIndex].m_facing.x.ToString();
            box_facingY.Text = objects.Npcs[list_npc.SelectedIndex].m_facing.y.ToString();
            box_colourR.Text = objects.Npcs[list_npc.SelectedIndex].m_colour.r.ToString();
            box_colourG.Text = objects.Npcs[list_npc.SelectedIndex].m_colour.g.ToString();
            box_colourB.Text = objects.Npcs[list_npc.SelectedIndex].m_colour.b.ToString();
            box_colourA.Text = objects.Npcs[list_npc.SelectedIndex].m_colour.a.ToString();
        }

        private void CheckTextBox_Number(TextBox box)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(box.Text, "  ^ [0-9]"))
            {
                box.Text = "";
            }
        }
        private void CheckPressedKey_Number(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void box_name_TextChanged(object sender, EventArgs e)
        {
            objects.Npcs[list_npc.SelectedIndex].m_name = box_name.Text;
        }
        private void box_schedule_TextChanged(object sender, EventArgs e)
        {
            objects.Npcs[list_npc.SelectedIndex].m_actionSchedule.m_name = box_schedule.Text;
        }

        private void box_shapeX_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckPressedKey_Number(e);
        }
        private void box_shapeY_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckPressedKey_Number(e);
        }
        private void box_facingX_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckPressedKey_Number(e);
        }
        private void box_facingY_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckPressedKey_Number(e);
        }
        private void box_colourR_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckPressedKey_Number(e);
        }
        private void box_colourG_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckPressedKey_Number(e);
        }
        private void box_colourB_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckPressedKey_Number(e);
        }
        private void box_colourA_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckPressedKey_Number(e);
        }
    }
}

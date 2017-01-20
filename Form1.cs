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
            test.SerializeObjects(filePath, objects);

            list_npc.DataSource = null;
            list_npc.DataSource = objects.Npcs;
            list_npc.DisplayMember = "m_name";
            
            button_Save.Click += button_Save_Click;
            button_Save.Enabled = true;
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            button_Load.Click -= button_Load_Click;
            button_Load.Enabled = false;
            // Enable editor after loading a file
            button_NPCNew.Enabled = true;
            button_NPCDelete.Enabled = true;
            box_name.Enabled = true;
            box_schedule.Enabled = true;
            box_shapeX.Enabled = true;
            box_shapeY.Enabled = true;
            box_facingX.Enabled = true;
            box_facingY.Enabled = true;
            box_colourR.Enabled = true;
            box_colourG.Enabled = true;
            box_colourB.Enabled = true;
            box_colourA.Enabled = true;
            box_OwnershipAddKey.Enabled = true;
            box_OwnershipAddValue.Enabled = true;
            button_OwnershipAdd.Enabled = true;
            button_Save.Enabled = true;

            // Load XML
            XMLHelper test = new XMLHelper();
            objects = test.DeserialzeObjects(filePath, objects);

            list_npc.DataSource = objects.Npcs;
            list_npc.DisplayMember = "m_name";
            list_gameObj.DataSource = objects.GameObjects;
            list_gameObj.DisplayMember = "m_name";

            button_Load.Click += button_Load_Click;
        }

        private void list_npc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(list_npc.SelectedIndex < 0)
            {
                return;
            }
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

            try
            {
                ownershipGrid.DataSource = objects.Npcs[list_npc.SelectedIndex].m_objectOwned.m_attributes.ToList();
            }
            catch(Exception ex)
            {
                if(ex.GetType().ToString() == "System.NullReferenceException")
                {
                    ownershipGrid.DataSource = null;
                }
                else
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
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

        private void button_OwnershipAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(objects.Npcs[list_npc.SelectedIndex].m_objectOwned.m_attributes.ContainsKey(box_OwnershipAddKey.Text) == false &&
                    objects.Npcs[list_npc.SelectedIndex].m_objectOwned.m_attributes.ContainsValue(box_OwnershipAddValue.Text) == false)
                {
                    objects.Npcs[list_npc.SelectedIndex].m_objectOwned.m_attributes.Add(box_OwnershipAddKey.Text, box_OwnershipAddValue.Text);

                    ownershipGrid.DataSource = objects.Npcs[list_npc.SelectedIndex].m_objectOwned.m_attributes.ToList();
                }
                else
                {
                    MessageBox.Show("Key or Value already exists.", "Ownership duplicate");
                }
            }
            catch(Exception ex)
            {
                if(ex.GetType().ToString() == "System.NullReferenceException")
                {
                    objects.Npcs[list_npc.SelectedIndex].m_objectOwned = new OwnedObjects(box_OwnershipAddKey.Text, box_OwnershipAddValue.Text);

                    ownershipGrid.DataSource = objects.Npcs[list_npc.SelectedIndex].m_objectOwned.m_attributes.ToList();
                }
                else
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void button_NPCNew_Click(object sender, EventArgs e)
        {
            objects.Npcs.Add(new Npc() { m_name = "NewNPC",
                                         m_pos = new Vector2(0, 0),
                                         m_facing = new Vector2(0, 0),
                                         m_colour = new Colour(0, 0, 0, 255),
                                         m_actionSchedule = new ActionSchedule("null")});
            list_npc.DataSource = null;
            list_npc.DataSource = objects.Npcs;
            list_npc.DisplayMember = "m_name";
        }

        private void button_NPCDelete_Click(object sender, EventArgs e)
        {
            objects.Npcs.Remove(objects.Npcs[list_npc.SelectedIndex]);
            list_npc.DataSource = null;
            list_npc.DataSource = objects.Npcs;
            list_npc.DisplayMember = "m_name";
        }
    }
}

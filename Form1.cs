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
        public Objects objects;
        public Scheduling scheduling;

        public Form1()
        {
            InitializeComponent();
            EnableNpcsEditor(false);
            EnableSchedulingEditor(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void EnableNpcsEditor(bool flag)
        {
            button_NPCNew.Enabled = flag;
            button_NPCDelete.Enabled = flag;
            box_name.Enabled = flag;
            box_schedule.Enabled = flag;
            box_shapeX.Enabled = flag;
            box_shapeY.Enabled = flag;
            box_facingX.Enabled = flag;
            box_facingY.Enabled = flag;
            box_colourR.Enabled = flag;
            box_colourG.Enabled = flag;
            box_colourB.Enabled = flag;
            box_colourA.Enabled = flag;
            box_OwnershipAddKey.Enabled = flag;
            box_OwnershipAddValue.Enabled = flag;
            button_OwnershipAdd.Enabled = flag;
        }

        private void EnableSchedulingEditor(bool flag)
        {
            button_SchedulingSub_ActionAdd.Enabled = flag;
            button_SchedulingSub_ActionDelete.Enabled = flag;
            textBox_SchedulingSub_ActionName.Enabled = flag;
            textBox_SchedulingSub_ActionTarget.Enabled = flag;
            textBox_SchedulingSub_ActionMinDur.Enabled = flag;
            textBox_SchedulingSub_ActionMaxDur.Enabled = flag;
            textBox_SchedulingSub_TemplateName.Enabled = flag;
            textBox_SchedulingSub_TemplateType.Enabled = flag;
            dataGridView_SchedulingSub_TemplateActions.Enabled = flag;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            button_Save.Click -= button_Save_Click;
            button_Save.Enabled = false;

            // Serialize XML
            XMLHelper.SerializeObjects(filePath, objects);

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

            // Load XML
            objects = XMLHelper.DeserialzeObjects(filePath, objects);
            scheduling = XMLHelper.DeserializeSchedules("xml/Schedules.xml", scheduling);
            if(objects != null && scheduling != null)
            {
                // Enable editor after loading a file
                EnableNpcsEditor(true);
                EnableSchedulingEditor(true);


                button_Save.Enabled = true;

                list_npc.DataSource = objects.Npcs;
                list_npc.DisplayMember = "m_name";
                list_gameObj.DataSource = objects.GameObjects;
                list_gameObj.DisplayMember = "m_name";
            }
            else
            {
                // Enable Load button on fail
                button_Load.Enabled = true;
            }

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
        private void textBox_SchedulingSub_ActionMinDur_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckPressedKey_Number(e);
        }
        private void textBox_SchedulingSub_ActionMaxDur_KeyPress(object sender, KeyPressEventArgs e)
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

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Behaviour_Editor
{
    public partial class Form_EditorMain : Form
    {
        public string filePath = "xml/Objects.xml";
        public Objects objects;
        public Scheduling scheduling;
        private FileSystemWatcher watcher;

        public Form_EditorMain()
        {
            InitializeComponent();
            button_NPCAdd.m_menu = menu_NPCAdd;

            EnableNpcsEditor(false);
            EnableSchedulingEditor(false);

            watcher = new FileSystemWatcher();
            watcher.Path = Path.GetDirectoryName(filePath);
            watcher.Filter = Path.GetFileName(filePath);
            watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Changed += new FileSystemEventHandler(OnXMLChanged);
        }

        private void OnXMLChanged(object sender, FileSystemEventArgs e)
        {
            RefreshNpcs();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vecTxtBox_Pos.X_Validated += new EventHandler(pos_X_Validated);
            vecTxtBox_Pos.Y_Validated += new EventHandler(pos_Y_validated);
            vecTxtBox_Facing.X_Validated += new EventHandler(face_X_Validated);
            vecTxtBox_Facing.Y_Validated += new EventHandler(face_Y_validated);
        }

        private void RefreshNpcs()
        {
            objects = XMLHelper.DeserialzeObjects(filePath, objects);

            list_npc.DataSource = null;
            list_npc.DataSource = objects.Npcs;
            list_npc.DisplayMember = "m_name";
            list_gameObj.DataSource = null;
            list_gameObj.DataSource = objects.GameObjects;
            list_gameObj.DisplayMember = "m_name";
        }

        private void face_Y_validated(object sender, EventArgs e)
        {
            decimal result = 0;
            if (decimal.TryParse(vecTxtBox_Facing.decTxtBox_Y.Text(), out result))
            {
                objects.Npcs[list_npc.SelectedIndex].m_facing.y = result;
            }
        }
        private void face_X_Validated(object sender, EventArgs e)
        {
            decimal result = 0;
            if(decimal.TryParse(vecTxtBox_Facing.decTxtBox_X.Text(), out result))
            {
                objects.Npcs[list_npc.SelectedIndex].m_facing.x = result;
            }
        }
        private void pos_Y_validated(object sender, EventArgs e)
        {
            decimal result = 0;
            if(decimal.TryParse(vecTxtBox_Pos.decTxtBox_Y.Text(), out result))
            {
                objects.Npcs[list_npc.SelectedIndex].m_pos.y = result;
            }
        }
        private void pos_X_Validated(object sender, EventArgs e)
        {
            decimal result = 0;
            if (decimal.TryParse(vecTxtBox_Pos.decTxtBox_X.Text(), out result))
            {
                objects.Npcs[list_npc.SelectedIndex].m_pos.x = result;
            }
        }

        private void EnableNpcsEditor(bool flag)
        {
            button_NPCAdd.Enabled = flag;
            button_NPCDelete.Enabled = flag;
            box_name.Enabled = flag;
            box_schedule.Enabled = flag;
            box_colourR.Enabled = flag;
            box_colourG.Enabled = flag;
            box_colourB.Enabled = flag;
            box_colourA.Enabled = flag;
            box_OwnershipAddKey.Enabled = flag;
            box_OwnershipAddValue.Enabled = flag;
            button_OwnershipAdd.Enabled = flag;
            vecTxtBox_Facing.Enabled = flag;
            vecTxtBox_Pos.Enabled = flag;
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
            watcher.EnableRaisingEvents = false;

            // Serialize XML
            XMLHelper.SerializeObjects(filePath, objects);

            list_npc.DataSource = null;
            list_npc.DataSource = objects.Npcs;
            list_npc.DisplayMember = "m_name";
            
            button_Save.Click += button_Save_Click;
            button_Save.Enabled = true;
            watcher.EnableRaisingEvents = true;
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            button_Load.Click -= button_Load_Click;

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

            watcher.EnableRaisingEvents = true;

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
            vecTxtBox_Pos.SetVector2(objects.Npcs[list_npc.SelectedIndex].m_pos);
            vecTxtBox_Facing.SetVector2(objects.Npcs[list_npc.SelectedIndex].m_facing);
            box_colourR.Text = objects.Npcs[list_npc.SelectedIndex].m_colour.r.ToString();
            box_colourG.Text = objects.Npcs[list_npc.SelectedIndex].m_colour.g.ToString();
            box_colourB.Text = objects.Npcs[list_npc.SelectedIndex].m_colour.b.ToString();
            box_colourA.Text = objects.Npcs[list_npc.SelectedIndex].m_colour.a.ToString();

            ownershipGrid.DataSource = objects.Npcs[list_npc.SelectedIndex].m_objectOwned?.m_attributes.ToList();   // DataSource set to null if m_objectOwned throws null exception
        }
        private void list_gameObj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(list_gameObj.SelectedIndex < 0)
            {
                return;
            }
            textBox_GameObj_Name.Text = objects.GameObjects[list_gameObj.SelectedIndex].m_name;
            textBox_GameObj_Type.Text = objects.GameObjects[list_gameObj.SelectedIndex].m_type;
            vecTxtBox_GameObj_Pos.SetVector2(objects.GameObjects[list_gameObj.SelectedIndex].m_rect.x, objects.GameObjects[list_gameObj.SelectedIndex].m_rect.y);
            textBox_GameObj_R.Text = objects.GameObjects[list_gameObj.SelectedIndex].m_colour.r.ToString();
            textBox_GameObj_G.Text = objects.GameObjects[list_gameObj.SelectedIndex].m_colour.g.ToString();
            textBox_GameObj_B.Text = objects.GameObjects[list_gameObj.SelectedIndex].m_colour.b.ToString();
            textBox_GameObj_A.Text = objects.GameObjects[list_gameObj.SelectedIndex].m_colour.a.ToString();
        }

        private void CheckTextBox_Number(TextBox box)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(box.Text, "  ^ [0-9]"))
            {
                box.Text = "";
            }
        }
        private void CheckPressedKey_Number(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if((e.KeyChar == '-') && (sender.ToString().Count() - 36 > 0))
            {
                e.Handled = true;
            }
            else
            if(e.KeyChar == '.')
            {

            }
        }

        private void box_colourR_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckPressedKey_Number(sender, e);
        }
        private void box_colourG_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckPressedKey_Number(sender, e);
        }
        private void box_colourB_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckPressedKey_Number(sender, e);
        }
        private void box_colourA_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckPressedKey_Number(sender, e);
        }
        private void textBox_SchedulingSub_ActionMinDur_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckPressedKey_Number(sender, e);
        }
        private void textBox_SchedulingSub_ActionMaxDur_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckPressedKey_Number(sender, e);
        }

        private void box_name_TextChanged(object sender, EventArgs e)
        {
            objects.Npcs[list_npc.SelectedIndex].m_name = box_name.Text;
        }
        private void box_schedule_TextChanged(object sender, EventArgs e)
        {
            objects.Npcs[list_npc.SelectedIndex].m_actionSchedule.m_name = box_schedule.Text;
        }

        private void button_OwnershipAdd_Click(object sender, EventArgs e)
        {
            objects.Npcs[list_npc.SelectedIndex].AddOwnership(box_OwnershipAddKey.Text, box_OwnershipAddValue.Text);
            ownershipGrid.DataSource = objects.Npcs[list_npc.SelectedIndex].m_objectOwned?.m_attributes.ToList();
        }
        private void button_NPCDelete_Click(object sender, EventArgs e)
        {
            objects.Npcs.Remove(objects.Npcs[list_npc.SelectedIndex]);
            list_npc.DataSource = null;
            list_npc.DataSource = objects.Npcs;
            list_npc.DisplayMember = "m_name";
            if(list_npc.SelectedIndex == -1)
            {
                list_npc.SelectedIndex = objects.Npcs.Count() - 1;
            }
        }
        private void newNPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objects.Npcs.Add(new Npc()
            {
                m_name = "NewNPC",
                m_pos = new Vector2(0, 0),
                m_facing = new Vector2(0, 0),
                m_colour = new Colour(0, 0, 0, 255),
                m_actionSchedule = new ActionSchedule("null")
            });
            list_npc.DataSource = null;
            list_npc.DataSource = objects.Npcs;
            list_npc.DisplayMember = "m_name";
            list_npc.SelectedIndex = objects.Npcs.Count - 1;    // Bring SelectedIndex to new Npc
        }
        private void duplicateNPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objects.Npcs.Add(new Npc()
            {
                m_name = objects.Npcs[list_npc.SelectedIndex].m_name,
                m_pos = new Vector2(objects.Npcs[list_npc.SelectedIndex].m_pos.x, objects.Npcs[list_npc.SelectedIndex].m_pos.y),
                m_facing = new Vector2(objects.Npcs[list_npc.SelectedIndex].m_facing.x, objects.Npcs[list_npc.SelectedIndex].m_facing.y),
                m_colour = new Colour(objects.Npcs[list_npc.SelectedIndex].m_colour.r,
                                      objects.Npcs[list_npc.SelectedIndex].m_colour.g,
                                      objects.Npcs[list_npc.SelectedIndex].m_colour.b,
                                      objects.Npcs[list_npc.SelectedIndex].m_colour.a),
                m_actionSchedule = new ActionSchedule(objects.Npcs[list_npc.SelectedIndex].m_actionSchedule.m_name)
            });
            foreach (KeyValuePair<string, string> entry in objects.Npcs[list_npc.SelectedIndex].m_objectOwned.m_attributes)
            {
                objects.Npcs[objects.Npcs.Count - 1].AddOwnership(entry.Key, entry.Value);
            }
            list_npc.DataSource = null;
            list_npc.DataSource = objects.Npcs;
            list_npc.DisplayMember = "m_name";
            list_npc.SelectedIndex = objects.Npcs.Count - 1;    // Bring SelectedIndex to new Npc
        }

        private void box_colourR_TextChanged(object sender, EventArgs e)
        {
            objects.Npcs[list_npc.SelectedIndex].m_colour.r = int.Parse(box_colourR.Text);
        }

        private void box_colourG_TextChanged(object sender, EventArgs e)
        {
            objects.Npcs[list_npc.SelectedIndex].m_colour.g = int.Parse(box_colourG.Text);
        }

        private void box_colourB_TextChanged(object sender, EventArgs e)
        {
            objects.Npcs[list_npc.SelectedIndex].m_colour.b = int.Parse(box_colourB.Text);
        }

        private void box_colourA_TextChanged(object sender, EventArgs e)
        {
            objects.Npcs[list_npc.SelectedIndex].m_colour.a = int.Parse(box_colourA.Text);
        }
    }

    public class MenuButton : Button
    {
        [DefaultValue(null)]
        public ContextMenuStrip m_menu { get; set; }

        [DefaultValue(false)]
        public bool ShowMenuUnderCursor { get; set; }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);

            if(m_menu != null &&
                mevent.Button == MouseButtons.Left)
            {
                Point menuLocation;

                if (ShowMenuUnderCursor)
                {
                    menuLocation = mevent.Location;
                }
                else
                {
                    menuLocation = new Point(0, Height);
                }

                m_menu.Show(this, menuLocation);

            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            if(m_menu != null)
            {
                int arrow_x = ClientRectangle.Width - 14;
                int arrow_y = ClientRectangle.Height / 2 - 1;

                Brush brush = Enabled ? SystemBrushes.ControlText : SystemBrushes.ButtonShadow;
                Point[] arrows = new Point[]
                {
                    new Point(arrow_x, arrow_y),
                    new Point(arrow_x + 7, arrow_y),
                    new Point(arrow_x +3, arrow_y + 4)
                };
                pevent.Graphics.FillPolygon(brush, arrows);
            }
        }
    }
}

namespace Behaviour_Editor
{
    partial class Form_EditorMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Load = new System.Windows.Forms.Button();
            this.tabCon_Main = new System.Windows.Forms.TabControl();
            this.tab_Npcs = new System.Windows.Forms.TabPage();
            this.button_NPCDelete = new System.Windows.Forms.Button();
            this.list_npc = new System.Windows.Forms.ListBox();
            this.groupBox_Npc = new System.Windows.Forms.GroupBox();
            this.box_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.box_shapeX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.box_shapeY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.box_facingX = new System.Windows.Forms.TextBox();
            this.box_schedule = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.box_facingY = new System.Windows.Forms.TextBox();
            this.box_colourA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.box_colourB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.box_colourG = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.box_colourR = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.box_OwnershipAddValue = new System.Windows.Forms.TextBox();
            this.ownershipGrid = new System.Windows.Forms.DataGridView();
            this.button_OwnershipAdd = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.box_OwnershipAddKey = new System.Windows.Forms.TextBox();
            this.tab_GameObjects = new System.Windows.Forms.TabPage();
            this.list_gameObj = new System.Windows.Forms.ListBox();
            this.tab_Scheduling = new System.Windows.Forms.TabPage();
            this.tabCon_Scheduling = new System.Windows.Forms.TabControl();
            this.tab_SchedulingSub_Actions = new System.Windows.Forms.TabPage();
            this.button_SchedulingSub_ActionDelete = new System.Windows.Forms.Button();
            this.button_SchedulingSub_ActionAdd = new System.Windows.Forms.Button();
            this.textBox_SchedulingSub_ActionMaxDur = new System.Windows.Forms.TextBox();
            this.label_SchedulingSub_ActionMaxDur = new System.Windows.Forms.Label();
            this.textBox_SchedulingSub_ActionMinDur = new System.Windows.Forms.TextBox();
            this.label_SchedulingSub_ActionMinDur = new System.Windows.Forms.Label();
            this.textBox_SchedulingSub_ActionTarget = new System.Windows.Forms.TextBox();
            this.label_SchedulingSub_ActionTarget = new System.Windows.Forms.Label();
            this.textBox_SchedulingSub_ActionName = new System.Windows.Forms.TextBox();
            this.label_SchedulingSub_ActionsName = new System.Windows.Forms.Label();
            this.list_SchedulingSub_Actions = new System.Windows.Forms.ListBox();
            this.tab_SchedulingSub_Templates = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.dataGridView_SchedulingSub_TemplateActions = new System.Windows.Forms.DataGridView();
            this.textBox_SchedulingSub_TemplateType = new System.Windows.Forms.TextBox();
            this.textBox_SchedulingSub_TemplateName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.list_SchedulingSub_Templates = new System.Windows.Forms.ListBox();
            this.tab_SchedulingSub_Schedules = new System.Windows.Forms.TabPage();
            this.list_SchedulingSub_Schedules = new System.Windows.Forms.ListBox();
            this.menu_NPCAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newNPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateNPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_NPCAdd = new Behaviour_Editor.MenuButton();
            this.tabCon_Main.SuspendLayout();
            this.tab_Npcs.SuspendLayout();
            this.groupBox_Npc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownershipGrid)).BeginInit();
            this.tab_GameObjects.SuspendLayout();
            this.tab_Scheduling.SuspendLayout();
            this.tabCon_Scheduling.SuspendLayout();
            this.tab_SchedulingSub_Actions.SuspendLayout();
            this.tab_SchedulingSub_Templates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SchedulingSub_TemplateActions)).BeginInit();
            this.tab_SchedulingSub_Schedules.SuspendLayout();
            this.menu_NPCAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.Enabled = false;
            this.button_Save.Location = new System.Drawing.Point(675, 526);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(97, 23);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Load
            // 
            this.button_Load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Load.Location = new System.Drawing.Point(546, 526);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(97, 23);
            this.button_Load.TabIndex = 3;
            this.button_Load.Text = "Load";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // tabCon_Main
            // 
            this.tabCon_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCon_Main.Controls.Add(this.tab_Npcs);
            this.tabCon_Main.Controls.Add(this.tab_GameObjects);
            this.tabCon_Main.Controls.Add(this.tab_Scheduling);
            this.tabCon_Main.Location = new System.Drawing.Point(12, 12);
            this.tabCon_Main.Name = "tabCon_Main";
            this.tabCon_Main.SelectedIndex = 0;
            this.tabCon_Main.Size = new System.Drawing.Size(760, 507);
            this.tabCon_Main.TabIndex = 4;
            // 
            // tab_Npcs
            // 
            this.tab_Npcs.Controls.Add(this.button_NPCDelete);
            this.tab_Npcs.Controls.Add(this.button_NPCAdd);
            this.tab_Npcs.Controls.Add(this.list_npc);
            this.tab_Npcs.Controls.Add(this.groupBox_Npc);
            this.tab_Npcs.Location = new System.Drawing.Point(4, 22);
            this.tab_Npcs.Name = "tab_Npcs";
            this.tab_Npcs.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Npcs.Size = new System.Drawing.Size(752, 481);
            this.tab_Npcs.TabIndex = 0;
            this.tab_Npcs.Text = "Npcs";
            this.tab_Npcs.UseVisualStyleBackColor = true;
            // 
            // button_NPCDelete
            // 
            this.button_NPCDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_NPCDelete.Enabled = false;
            this.button_NPCDelete.Location = new System.Drawing.Point(160, 442);
            this.button_NPCDelete.Name = "button_NPCDelete";
            this.button_NPCDelete.Size = new System.Drawing.Size(97, 23);
            this.button_NPCDelete.TabIndex = 33;
            this.button_NPCDelete.Text = "Delete NPC";
            this.button_NPCDelete.UseVisualStyleBackColor = true;
            this.button_NPCDelete.Click += new System.EventHandler(this.button_NPCDelete_Click);
            // 
            // list_npc
            // 
            this.list_npc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_npc.FormattingEnabled = true;
            this.list_npc.ItemHeight = 12;
            this.list_npc.Location = new System.Drawing.Point(7, 7);
            this.list_npc.Name = "list_npc";
            this.list_npc.Size = new System.Drawing.Size(250, 424);
            this.list_npc.TabIndex = 0;
            this.list_npc.SelectedIndexChanged += new System.EventHandler(this.list_npc_SelectedIndexChanged);
            // 
            // groupBox_Npc
            // 
            this.groupBox_Npc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Npc.Controls.Add(this.box_name);
            this.groupBox_Npc.Controls.Add(this.label1);
            this.groupBox_Npc.Controls.Add(this.label2);
            this.groupBox_Npc.Controls.Add(this.label3);
            this.groupBox_Npc.Controls.Add(this.box_shapeX);
            this.groupBox_Npc.Controls.Add(this.label4);
            this.groupBox_Npc.Controls.Add(this.box_shapeY);
            this.groupBox_Npc.Controls.Add(this.label5);
            this.groupBox_Npc.Controls.Add(this.label6);
            this.groupBox_Npc.Controls.Add(this.box_facingX);
            this.groupBox_Npc.Controls.Add(this.box_schedule);
            this.groupBox_Npc.Controls.Add(this.label7);
            this.groupBox_Npc.Controls.Add(this.label13);
            this.groupBox_Npc.Controls.Add(this.box_facingY);
            this.groupBox_Npc.Controls.Add(this.box_colourA);
            this.groupBox_Npc.Controls.Add(this.label8);
            this.groupBox_Npc.Controls.Add(this.box_colourB);
            this.groupBox_Npc.Controls.Add(this.label9);
            this.groupBox_Npc.Controls.Add(this.box_colourG);
            this.groupBox_Npc.Controls.Add(this.label10);
            this.groupBox_Npc.Controls.Add(this.box_colourR);
            this.groupBox_Npc.Controls.Add(this.label11);
            this.groupBox_Npc.Controls.Add(this.label12);
            this.groupBox_Npc.Controls.Add(this.groupBox1);
            this.groupBox_Npc.Location = new System.Drawing.Point(264, 7);
            this.groupBox_Npc.Name = "groupBox_Npc";
            this.groupBox_Npc.Size = new System.Drawing.Size(482, 468);
            this.groupBox_Npc.TabIndex = 34;
            this.groupBox_Npc.TabStop = false;
            this.groupBox_Npc.Text = "Npc";
            // 
            // box_name
            // 
            this.box_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_name.Enabled = false;
            this.box_name.Location = new System.Drawing.Point(15, 38);
            this.box_name.Name = "box_name";
            this.box_name.Size = new System.Drawing.Size(176, 19);
            this.box_name.TabIndex = 2;
            this.box_name.TextChanged += new System.EventHandler(this.box_name_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shape (Position)";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "x";
            // 
            // box_shapeX
            // 
            this.box_shapeX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_shapeX.Enabled = false;
            this.box_shapeX.Location = new System.Drawing.Point(272, 38);
            this.box_shapeX.Name = "box_shapeX";
            this.box_shapeX.Size = new System.Drawing.Size(31, 19);
            this.box_shapeX.TabIndex = 5;
            this.box_shapeX.TextChanged += new System.EventHandler(this.box_shapeX_TextChanged);
            this.box_shapeX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_shapeX_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "y";
            // 
            // box_shapeY
            // 
            this.box_shapeY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_shapeY.Enabled = false;
            this.box_shapeY.Location = new System.Drawing.Point(326, 38);
            this.box_shapeY.Name = "box_shapeY";
            this.box_shapeY.Size = new System.Drawing.Size(31, 19);
            this.box_shapeY.TabIndex = 7;
            this.box_shapeY.TextChanged += new System.EventHandler(this.box_shapeY_TextChanged);
            this.box_shapeY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_shapeY_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Facing";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "x";
            // 
            // box_facingX
            // 
            this.box_facingX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_facingX.Enabled = false;
            this.box_facingX.Location = new System.Drawing.Point(272, 75);
            this.box_facingX.Name = "box_facingX";
            this.box_facingX.Size = new System.Drawing.Size(31, 19);
            this.box_facingX.TabIndex = 10;
            this.box_facingX.TextChanged += new System.EventHandler(this.box_facingX_TextChanged);
            this.box_facingX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_facingX_KeyPress);
            // 
            // box_schedule
            // 
            this.box_schedule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_schedule.Enabled = false;
            this.box_schedule.Location = new System.Drawing.Point(15, 87);
            this.box_schedule.Name = "box_schedule";
            this.box_schedule.Size = new System.Drawing.Size(176, 19);
            this.box_schedule.TabIndex = 23;
            this.box_schedule.TextChanged += new System.EventHandler(this.box_schedule_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "y";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 12);
            this.label13.TabIndex = 22;
            this.label13.Text = "Initial Schedule";
            // 
            // box_facingY
            // 
            this.box_facingY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_facingY.Enabled = false;
            this.box_facingY.Location = new System.Drawing.Point(326, 75);
            this.box_facingY.Name = "box_facingY";
            this.box_facingY.Size = new System.Drawing.Size(31, 19);
            this.box_facingY.TabIndex = 12;
            this.box_facingY.TextChanged += new System.EventHandler(this.box_facingY_TextChanged);
            this.box_facingY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_facingY_KeyPress);
            // 
            // box_colourA
            // 
            this.box_colourA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_colourA.Enabled = false;
            this.box_colourA.Location = new System.Drawing.Point(434, 112);
            this.box_colourA.Name = "box_colourA";
            this.box_colourA.Size = new System.Drawing.Size(31, 19);
            this.box_colourA.TabIndex = 21;
            this.box_colourA.TextChanged += new System.EventHandler(this.box_colourA_TextChanged);
            this.box_colourA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_colourA_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "Color";
            // 
            // box_colourB
            // 
            this.box_colourB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_colourB.Enabled = false;
            this.box_colourB.Location = new System.Drawing.Point(380, 112);
            this.box_colourB.Name = "box_colourB";
            this.box_colourB.Size = new System.Drawing.Size(31, 19);
            this.box_colourB.TabIndex = 20;
            this.box_colourB.TextChanged += new System.EventHandler(this.box_colourB_TextChanged);
            this.box_colourB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_colourB_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(257, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(9, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "r";
            // 
            // box_colourG
            // 
            this.box_colourG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_colourG.Enabled = false;
            this.box_colourG.Location = new System.Drawing.Point(326, 112);
            this.box_colourG.Name = "box_colourG";
            this.box_colourG.Size = new System.Drawing.Size(31, 19);
            this.box_colourG.TabIndex = 19;
            this.box_colourG.TextChanged += new System.EventHandler(this.box_colourG_TextChanged);
            this.box_colourG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_colourG_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(309, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "g";
            // 
            // box_colourR
            // 
            this.box_colourR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_colourR.Enabled = false;
            this.box_colourR.Location = new System.Drawing.Point(272, 112);
            this.box_colourR.Name = "box_colourR";
            this.box_colourR.Size = new System.Drawing.Size(31, 19);
            this.box_colourR.TabIndex = 18;
            this.box_colourR.TextChanged += new System.EventHandler(this.box_colourR_TextChanged);
            this.box_colourR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_colourR_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(363, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "b";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(417, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 12);
            this.label12.TabIndex = 17;
            this.label12.Text = "a";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.box_OwnershipAddValue);
            this.groupBox1.Controls.Add(this.ownershipGrid);
            this.groupBox1.Controls.Add(this.button_OwnershipAdd);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.box_OwnershipAddKey);
            this.groupBox1.Location = new System.Drawing.Point(6, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 307);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object Ownership";
            // 
            // box_OwnershipAddValue
            // 
            this.box_OwnershipAddValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.box_OwnershipAddValue.Enabled = false;
            this.box_OwnershipAddValue.Location = new System.Drawing.Point(280, 238);
            this.box_OwnershipAddValue.Name = "box_OwnershipAddValue";
            this.box_OwnershipAddValue.Size = new System.Drawing.Size(151, 19);
            this.box_OwnershipAddValue.TabIndex = 30;
            // 
            // ownershipGrid
            // 
            this.ownershipGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ownershipGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownershipGrid.Location = new System.Drawing.Point(11, 20);
            this.ownershipGrid.Name = "ownershipGrid";
            this.ownershipGrid.RowTemplate.Height = 21;
            this.ownershipGrid.Size = new System.Drawing.Size(448, 191);
            this.ownershipGrid.TabIndex = 24;
            // 
            // button_OwnershipAdd
            // 
            this.button_OwnershipAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_OwnershipAdd.Enabled = false;
            this.button_OwnershipAdd.Location = new System.Drawing.Point(320, 263);
            this.button_OwnershipAdd.Name = "button_OwnershipAdd";
            this.button_OwnershipAdd.Size = new System.Drawing.Size(132, 23);
            this.button_OwnershipAdd.TabIndex = 31;
            this.button_OwnershipAdd.Text = "Add Object Ownership";
            this.button_OwnershipAdd.UseVisualStyleBackColor = true;
            this.button_OwnershipAdd.Click += new System.EventHandler(this.button_OwnershipAdd_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 12);
            this.label15.TabIndex = 26;
            this.label15.Text = "Add Object Ownership";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(53, 241);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 12);
            this.label16.TabIndex = 27;
            this.label16.Text = "Key";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(240, 241);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 12);
            this.label17.TabIndex = 28;
            this.label17.Text = "Value";
            // 
            // box_OwnershipAddKey
            // 
            this.box_OwnershipAddKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.box_OwnershipAddKey.Enabled = false;
            this.box_OwnershipAddKey.Location = new System.Drawing.Point(83, 238);
            this.box_OwnershipAddKey.Name = "box_OwnershipAddKey";
            this.box_OwnershipAddKey.Size = new System.Drawing.Size(151, 19);
            this.box_OwnershipAddKey.TabIndex = 29;
            // 
            // tab_GameObjects
            // 
            this.tab_GameObjects.Controls.Add(this.list_gameObj);
            this.tab_GameObjects.Location = new System.Drawing.Point(4, 22);
            this.tab_GameObjects.Name = "tab_GameObjects";
            this.tab_GameObjects.Padding = new System.Windows.Forms.Padding(3);
            this.tab_GameObjects.Size = new System.Drawing.Size(752, 481);
            this.tab_GameObjects.TabIndex = 1;
            this.tab_GameObjects.Text = "GameObjects";
            this.tab_GameObjects.UseVisualStyleBackColor = true;
            // 
            // list_gameObj
            // 
            this.list_gameObj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_gameObj.FormattingEnabled = true;
            this.list_gameObj.ItemHeight = 12;
            this.list_gameObj.Location = new System.Drawing.Point(7, 7);
            this.list_gameObj.Name = "list_gameObj";
            this.list_gameObj.Size = new System.Drawing.Size(250, 460);
            this.list_gameObj.TabIndex = 0;
            // 
            // tab_Scheduling
            // 
            this.tab_Scheduling.Controls.Add(this.tabCon_Scheduling);
            this.tab_Scheduling.Location = new System.Drawing.Point(4, 22);
            this.tab_Scheduling.Name = "tab_Scheduling";
            this.tab_Scheduling.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Scheduling.Size = new System.Drawing.Size(752, 481);
            this.tab_Scheduling.TabIndex = 2;
            this.tab_Scheduling.Text = "Scheduling";
            this.tab_Scheduling.UseVisualStyleBackColor = true;
            // 
            // tabCon_Scheduling
            // 
            this.tabCon_Scheduling.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCon_Scheduling.Controls.Add(this.tab_SchedulingSub_Actions);
            this.tabCon_Scheduling.Controls.Add(this.tab_SchedulingSub_Templates);
            this.tabCon_Scheduling.Controls.Add(this.tab_SchedulingSub_Schedules);
            this.tabCon_Scheduling.Location = new System.Drawing.Point(6, 3);
            this.tabCon_Scheduling.Name = "tabCon_Scheduling";
            this.tabCon_Scheduling.SelectedIndex = 0;
            this.tabCon_Scheduling.Size = new System.Drawing.Size(721, 333);
            this.tabCon_Scheduling.TabIndex = 0;
            // 
            // tab_SchedulingSub_Actions
            // 
            this.tab_SchedulingSub_Actions.Controls.Add(this.button_SchedulingSub_ActionDelete);
            this.tab_SchedulingSub_Actions.Controls.Add(this.button_SchedulingSub_ActionAdd);
            this.tab_SchedulingSub_Actions.Controls.Add(this.textBox_SchedulingSub_ActionMaxDur);
            this.tab_SchedulingSub_Actions.Controls.Add(this.label_SchedulingSub_ActionMaxDur);
            this.tab_SchedulingSub_Actions.Controls.Add(this.textBox_SchedulingSub_ActionMinDur);
            this.tab_SchedulingSub_Actions.Controls.Add(this.label_SchedulingSub_ActionMinDur);
            this.tab_SchedulingSub_Actions.Controls.Add(this.textBox_SchedulingSub_ActionTarget);
            this.tab_SchedulingSub_Actions.Controls.Add(this.label_SchedulingSub_ActionTarget);
            this.tab_SchedulingSub_Actions.Controls.Add(this.textBox_SchedulingSub_ActionName);
            this.tab_SchedulingSub_Actions.Controls.Add(this.label_SchedulingSub_ActionsName);
            this.tab_SchedulingSub_Actions.Controls.Add(this.list_SchedulingSub_Actions);
            this.tab_SchedulingSub_Actions.Location = new System.Drawing.Point(4, 22);
            this.tab_SchedulingSub_Actions.Name = "tab_SchedulingSub_Actions";
            this.tab_SchedulingSub_Actions.Padding = new System.Windows.Forms.Padding(3);
            this.tab_SchedulingSub_Actions.Size = new System.Drawing.Size(713, 307);
            this.tab_SchedulingSub_Actions.TabIndex = 0;
            this.tab_SchedulingSub_Actions.Text = "Actions";
            this.tab_SchedulingSub_Actions.UseVisualStyleBackColor = true;
            // 
            // button_SchedulingSub_ActionDelete
            // 
            this.button_SchedulingSub_ActionDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SchedulingSub_ActionDelete.Enabled = false;
            this.button_SchedulingSub_ActionDelete.Location = new System.Drawing.Point(225, 35);
            this.button_SchedulingSub_ActionDelete.Name = "button_SchedulingSub_ActionDelete";
            this.button_SchedulingSub_ActionDelete.Size = new System.Drawing.Size(119, 23);
            this.button_SchedulingSub_ActionDelete.TabIndex = 34;
            this.button_SchedulingSub_ActionDelete.Text = "Delete Action";
            this.button_SchedulingSub_ActionDelete.UseVisualStyleBackColor = true;
            // 
            // button_SchedulingSub_ActionAdd
            // 
            this.button_SchedulingSub_ActionAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SchedulingSub_ActionAdd.Enabled = false;
            this.button_SchedulingSub_ActionAdd.Location = new System.Drawing.Point(225, 6);
            this.button_SchedulingSub_ActionAdd.Name = "button_SchedulingSub_ActionAdd";
            this.button_SchedulingSub_ActionAdd.Size = new System.Drawing.Size(119, 23);
            this.button_SchedulingSub_ActionAdd.TabIndex = 33;
            this.button_SchedulingSub_ActionAdd.Text = "New Action";
            this.button_SchedulingSub_ActionAdd.UseVisualStyleBackColor = true;
            // 
            // textBox_SchedulingSub_ActionMaxDur
            // 
            this.textBox_SchedulingSub_ActionMaxDur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_SchedulingSub_ActionMaxDur.Enabled = false;
            this.textBox_SchedulingSub_ActionMaxDur.Location = new System.Drawing.Point(403, 200);
            this.textBox_SchedulingSub_ActionMaxDur.Name = "textBox_SchedulingSub_ActionMaxDur";
            this.textBox_SchedulingSub_ActionMaxDur.Size = new System.Drawing.Size(119, 19);
            this.textBox_SchedulingSub_ActionMaxDur.TabIndex = 8;
            this.textBox_SchedulingSub_ActionMaxDur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_SchedulingSub_ActionMaxDur_KeyPress);
            // 
            // label_SchedulingSub_ActionMaxDur
            // 
            this.label_SchedulingSub_ActionMaxDur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_SchedulingSub_ActionMaxDur.AutoSize = true;
            this.label_SchedulingSub_ActionMaxDur.Location = new System.Drawing.Point(401, 185);
            this.label_SchedulingSub_ActionMaxDur.Name = "label_SchedulingSub_ActionMaxDur";
            this.label_SchedulingSub_ActionMaxDur.Size = new System.Drawing.Size(100, 12);
            this.label_SchedulingSub_ActionMaxDur.TabIndex = 7;
            this.label_SchedulingSub_ActionMaxDur.Text = "Maximum Duration";
            // 
            // textBox_SchedulingSub_ActionMinDur
            // 
            this.textBox_SchedulingSub_ActionMinDur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_SchedulingSub_ActionMinDur.Enabled = false;
            this.textBox_SchedulingSub_ActionMinDur.Location = new System.Drawing.Point(225, 200);
            this.textBox_SchedulingSub_ActionMinDur.Name = "textBox_SchedulingSub_ActionMinDur";
            this.textBox_SchedulingSub_ActionMinDur.Size = new System.Drawing.Size(119, 19);
            this.textBox_SchedulingSub_ActionMinDur.TabIndex = 6;
            this.textBox_SchedulingSub_ActionMinDur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_SchedulingSub_ActionMinDur_KeyPress);
            // 
            // label_SchedulingSub_ActionMinDur
            // 
            this.label_SchedulingSub_ActionMinDur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_SchedulingSub_ActionMinDur.AutoSize = true;
            this.label_SchedulingSub_ActionMinDur.Location = new System.Drawing.Point(223, 185);
            this.label_SchedulingSub_ActionMinDur.Name = "label_SchedulingSub_ActionMinDur";
            this.label_SchedulingSub_ActionMinDur.Size = new System.Drawing.Size(97, 12);
            this.label_SchedulingSub_ActionMinDur.TabIndex = 5;
            this.label_SchedulingSub_ActionMinDur.Text = "Minimum Duration";
            // 
            // textBox_SchedulingSub_ActionTarget
            // 
            this.textBox_SchedulingSub_ActionTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_SchedulingSub_ActionTarget.Enabled = false;
            this.textBox_SchedulingSub_ActionTarget.Location = new System.Drawing.Point(225, 149);
            this.textBox_SchedulingSub_ActionTarget.Name = "textBox_SchedulingSub_ActionTarget";
            this.textBox_SchedulingSub_ActionTarget.Size = new System.Drawing.Size(176, 19);
            this.textBox_SchedulingSub_ActionTarget.TabIndex = 4;
            // 
            // label_SchedulingSub_ActionTarget
            // 
            this.label_SchedulingSub_ActionTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_SchedulingSub_ActionTarget.AutoSize = true;
            this.label_SchedulingSub_ActionTarget.Location = new System.Drawing.Point(223, 134);
            this.label_SchedulingSub_ActionTarget.Name = "label_SchedulingSub_ActionTarget";
            this.label_SchedulingSub_ActionTarget.Size = new System.Drawing.Size(38, 12);
            this.label_SchedulingSub_ActionTarget.TabIndex = 3;
            this.label_SchedulingSub_ActionTarget.Text = "Target";
            // 
            // textBox_SchedulingSub_ActionName
            // 
            this.textBox_SchedulingSub_ActionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_SchedulingSub_ActionName.Enabled = false;
            this.textBox_SchedulingSub_ActionName.Location = new System.Drawing.Point(225, 99);
            this.textBox_SchedulingSub_ActionName.Name = "textBox_SchedulingSub_ActionName";
            this.textBox_SchedulingSub_ActionName.Size = new System.Drawing.Size(176, 19);
            this.textBox_SchedulingSub_ActionName.TabIndex = 2;
            // 
            // label_SchedulingSub_ActionsName
            // 
            this.label_SchedulingSub_ActionsName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_SchedulingSub_ActionsName.AutoSize = true;
            this.label_SchedulingSub_ActionsName.Location = new System.Drawing.Point(223, 83);
            this.label_SchedulingSub_ActionsName.Name = "label_SchedulingSub_ActionsName";
            this.label_SchedulingSub_ActionsName.Size = new System.Drawing.Size(34, 12);
            this.label_SchedulingSub_ActionsName.TabIndex = 1;
            this.label_SchedulingSub_ActionsName.Text = "Name";
            // 
            // list_SchedulingSub_Actions
            // 
            this.list_SchedulingSub_Actions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_SchedulingSub_Actions.FormattingEnabled = true;
            this.list_SchedulingSub_Actions.ItemHeight = 12;
            this.list_SchedulingSub_Actions.Location = new System.Drawing.Point(6, 6);
            this.list_SchedulingSub_Actions.Name = "list_SchedulingSub_Actions";
            this.list_SchedulingSub_Actions.Size = new System.Drawing.Size(213, 292);
            this.list_SchedulingSub_Actions.TabIndex = 0;
            // 
            // tab_SchedulingSub_Templates
            // 
            this.tab_SchedulingSub_Templates.Controls.Add(this.label20);
            this.tab_SchedulingSub_Templates.Controls.Add(this.dataGridView_SchedulingSub_TemplateActions);
            this.tab_SchedulingSub_Templates.Controls.Add(this.textBox_SchedulingSub_TemplateType);
            this.tab_SchedulingSub_Templates.Controls.Add(this.textBox_SchedulingSub_TemplateName);
            this.tab_SchedulingSub_Templates.Controls.Add(this.label19);
            this.tab_SchedulingSub_Templates.Controls.Add(this.label18);
            this.tab_SchedulingSub_Templates.Controls.Add(this.list_SchedulingSub_Templates);
            this.tab_SchedulingSub_Templates.Location = new System.Drawing.Point(4, 22);
            this.tab_SchedulingSub_Templates.Name = "tab_SchedulingSub_Templates";
            this.tab_SchedulingSub_Templates.Padding = new System.Windows.Forms.Padding(3);
            this.tab_SchedulingSub_Templates.Size = new System.Drawing.Size(713, 307);
            this.tab_SchedulingSub_Templates.TabIndex = 1;
            this.tab_SchedulingSub_Templates.Text = "Templates";
            this.tab_SchedulingSub_Templates.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(225, 43);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 12);
            this.label20.TabIndex = 7;
            this.label20.Text = "Actions";
            // 
            // dataGridView_SchedulingSub_TemplateActions
            // 
            this.dataGridView_SchedulingSub_TemplateActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_SchedulingSub_TemplateActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SchedulingSub_TemplateActions.Enabled = false;
            this.dataGridView_SchedulingSub_TemplateActions.Location = new System.Drawing.Point(225, 58);
            this.dataGridView_SchedulingSub_TemplateActions.Name = "dataGridView_SchedulingSub_TemplateActions";
            this.dataGridView_SchedulingSub_TemplateActions.RowTemplate.Height = 21;
            this.dataGridView_SchedulingSub_TemplateActions.Size = new System.Drawing.Size(482, 240);
            this.dataGridView_SchedulingSub_TemplateActions.TabIndex = 6;
            // 
            // textBox_SchedulingSub_TemplateType
            // 
            this.textBox_SchedulingSub_TemplateType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_SchedulingSub_TemplateType.Enabled = false;
            this.textBox_SchedulingSub_TemplateType.Location = new System.Drawing.Point(476, 21);
            this.textBox_SchedulingSub_TemplateType.Name = "textBox_SchedulingSub_TemplateType";
            this.textBox_SchedulingSub_TemplateType.Size = new System.Drawing.Size(207, 19);
            this.textBox_SchedulingSub_TemplateType.TabIndex = 5;
            // 
            // textBox_SchedulingSub_TemplateName
            // 
            this.textBox_SchedulingSub_TemplateName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_SchedulingSub_TemplateName.Enabled = false;
            this.textBox_SchedulingSub_TemplateName.Location = new System.Drawing.Point(225, 21);
            this.textBox_SchedulingSub_TemplateName.Name = "textBox_SchedulingSub_TemplateName";
            this.textBox_SchedulingSub_TemplateName.Size = new System.Drawing.Size(207, 19);
            this.textBox_SchedulingSub_TemplateName.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(474, 6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 12);
            this.label19.TabIndex = 3;
            this.label19.Text = "Type";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(225, 6);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 12);
            this.label18.TabIndex = 2;
            this.label18.Text = "Name";
            // 
            // list_SchedulingSub_Templates
            // 
            this.list_SchedulingSub_Templates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_SchedulingSub_Templates.FormattingEnabled = true;
            this.list_SchedulingSub_Templates.ItemHeight = 12;
            this.list_SchedulingSub_Templates.Location = new System.Drawing.Point(6, 6);
            this.list_SchedulingSub_Templates.Name = "list_SchedulingSub_Templates";
            this.list_SchedulingSub_Templates.Size = new System.Drawing.Size(213, 292);
            this.list_SchedulingSub_Templates.TabIndex = 1;
            // 
            // tab_SchedulingSub_Schedules
            // 
            this.tab_SchedulingSub_Schedules.Controls.Add(this.list_SchedulingSub_Schedules);
            this.tab_SchedulingSub_Schedules.Location = new System.Drawing.Point(4, 22);
            this.tab_SchedulingSub_Schedules.Name = "tab_SchedulingSub_Schedules";
            this.tab_SchedulingSub_Schedules.Padding = new System.Windows.Forms.Padding(3);
            this.tab_SchedulingSub_Schedules.Size = new System.Drawing.Size(713, 307);
            this.tab_SchedulingSub_Schedules.TabIndex = 2;
            this.tab_SchedulingSub_Schedules.Text = "Schedules";
            this.tab_SchedulingSub_Schedules.UseVisualStyleBackColor = true;
            // 
            // list_SchedulingSub_Schedules
            // 
            this.list_SchedulingSub_Schedules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_SchedulingSub_Schedules.FormattingEnabled = true;
            this.list_SchedulingSub_Schedules.ItemHeight = 12;
            this.list_SchedulingSub_Schedules.Location = new System.Drawing.Point(6, 6);
            this.list_SchedulingSub_Schedules.Name = "list_SchedulingSub_Schedules";
            this.list_SchedulingSub_Schedules.Size = new System.Drawing.Size(213, 292);
            this.list_SchedulingSub_Schedules.TabIndex = 1;
            // 
            // menu_NPCAdd
            // 
            this.menu_NPCAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNPCToolStripMenuItem,
            this.duplicateNPCToolStripMenuItem});
            this.menu_NPCAdd.Name = "contextMenuStrip1";
            this.menu_NPCAdd.Size = new System.Drawing.Size(151, 48);
            // 
            // newNPCToolStripMenuItem
            // 
            this.newNPCToolStripMenuItem.Name = "newNPCToolStripMenuItem";
            this.newNPCToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.newNPCToolStripMenuItem.Text = "New NPC";
            this.newNPCToolStripMenuItem.Click += new System.EventHandler(this.newNPCToolStripMenuItem_Click);
            // 
            // duplicateNPCToolStripMenuItem
            // 
            this.duplicateNPCToolStripMenuItem.Name = "duplicateNPCToolStripMenuItem";
            this.duplicateNPCToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.duplicateNPCToolStripMenuItem.Text = "Duplicate NPC";
            this.duplicateNPCToolStripMenuItem.Click += new System.EventHandler(this.duplicateNPCToolStripMenuItem_Click);
            // 
            // button_NPCAdd
            // 
            this.button_NPCAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_NPCAdd.Enabled = false;
            this.button_NPCAdd.Location = new System.Drawing.Point(7, 442);
            this.button_NPCAdd.Name = "button_NPCAdd";
            this.button_NPCAdd.Size = new System.Drawing.Size(97, 23);
            this.button_NPCAdd.TabIndex = 32;
            this.button_NPCAdd.Text = "Add NPC";
            this.button_NPCAdd.UseVisualStyleBackColor = true;
            // 
            // Form_EditorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabCon_Main);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.button_Save);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form_EditorMain";
            this.Text = "Background AI Behaviour editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabCon_Main.ResumeLayout(false);
            this.tab_Npcs.ResumeLayout(false);
            this.groupBox_Npc.ResumeLayout(false);
            this.groupBox_Npc.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownershipGrid)).EndInit();
            this.tab_GameObjects.ResumeLayout(false);
            this.tab_Scheduling.ResumeLayout(false);
            this.tabCon_Scheduling.ResumeLayout(false);
            this.tab_SchedulingSub_Actions.ResumeLayout(false);
            this.tab_SchedulingSub_Actions.PerformLayout();
            this.tab_SchedulingSub_Templates.ResumeLayout(false);
            this.tab_SchedulingSub_Templates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SchedulingSub_TemplateActions)).EndInit();
            this.tab_SchedulingSub_Schedules.ResumeLayout(false);
            this.menu_NPCAdd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.TabControl tabCon_Main;
        private System.Windows.Forms.TabPage tab_Npcs;
        private System.Windows.Forms.TabPage tab_GameObjects;
        private System.Windows.Forms.ListBox list_npc;
        private System.Windows.Forms.ListBox list_gameObj;
        private System.Windows.Forms.TextBox box_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box_shapeX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_shapeY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox box_facingY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox box_facingX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox box_colourA;
        private System.Windows.Forms.TextBox box_colourB;
        private System.Windows.Forms.TextBox box_colourG;
        private System.Windows.Forms.TextBox box_colourR;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox box_schedule;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView ownershipGrid;
        private System.Windows.Forms.Button button_OwnershipAdd;
        private System.Windows.Forms.TextBox box_OwnershipAddValue;
        private System.Windows.Forms.TextBox box_OwnershipAddKey;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button_NPCDelete;
        private System.Windows.Forms.TabPage tab_Scheduling;
        private System.Windows.Forms.TabControl tabCon_Scheduling;
        private System.Windows.Forms.TabPage tab_SchedulingSub_Actions;
        private System.Windows.Forms.TabPage tab_SchedulingSub_Templates;
        private System.Windows.Forms.TabPage tab_SchedulingSub_Schedules;
        private System.Windows.Forms.ListBox list_SchedulingSub_Actions;
        private System.Windows.Forms.Button button_SchedulingSub_ActionDelete;
        private System.Windows.Forms.Button button_SchedulingSub_ActionAdd;
        private System.Windows.Forms.TextBox textBox_SchedulingSub_ActionMaxDur;
        private System.Windows.Forms.Label label_SchedulingSub_ActionMaxDur;
        private System.Windows.Forms.TextBox textBox_SchedulingSub_ActionMinDur;
        private System.Windows.Forms.Label label_SchedulingSub_ActionMinDur;
        private System.Windows.Forms.TextBox textBox_SchedulingSub_ActionTarget;
        private System.Windows.Forms.Label label_SchedulingSub_ActionTarget;
        private System.Windows.Forms.TextBox textBox_SchedulingSub_ActionName;
        private System.Windows.Forms.Label label_SchedulingSub_ActionsName;
        private System.Windows.Forms.ListBox list_SchedulingSub_Templates;
        private System.Windows.Forms.ListBox list_SchedulingSub_Schedules;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dataGridView_SchedulingSub_TemplateActions;
        private System.Windows.Forms.TextBox textBox_SchedulingSub_TemplateType;
        private System.Windows.Forms.TextBox textBox_SchedulingSub_TemplateName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox_Npc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip menu_NPCAdd;
        private System.Windows.Forms.ToolStripMenuItem newNPCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateNPCToolStripMenuItem;
        private MenuButton button_NPCAdd;
    }
}


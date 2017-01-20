namespace Behaviour_Editor
{
    partial class Form1
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
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Load = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.ownershipGrid = new System.Windows.Forms.DataGridView();
            this.box_schedule = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.box_colourA = new System.Windows.Forms.TextBox();
            this.box_colourB = new System.Windows.Forms.TextBox();
            this.box_colourG = new System.Windows.Forms.TextBox();
            this.box_colourR = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.box_facingY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.box_facingX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.box_shapeY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.box_shapeX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.box_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.list_npc = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.list_gameObj = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.box_OwnershipAddKey = new System.Windows.Forms.TextBox();
            this.box_OwnershipAddValue = new System.Windows.Forms.TextBox();
            this.button_OwnershipAdd = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownershipGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.Enabled = false;
            this.button_Save.Location = new System.Drawing.Point(656, 387);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(97, 23);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Load
            // 
            this.button_Load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Load.Location = new System.Drawing.Point(527, 387);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(97, 23);
            this.button_Load.TabIndex = 3;
            this.button_Load.Text = "Load";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(741, 368);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_OwnershipAdd);
            this.tabPage1.Controls.Add(this.box_OwnershipAddValue);
            this.tabPage1.Controls.Add(this.box_OwnershipAddKey);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.ownershipGrid);
            this.tabPage1.Controls.Add(this.box_schedule);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.box_colourA);
            this.tabPage1.Controls.Add(this.box_colourB);
            this.tabPage1.Controls.Add(this.box_colourG);
            this.tabPage1.Controls.Add(this.box_colourR);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.box_facingY);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.box_facingX);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.box_shapeY);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.box_shapeX);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.box_name);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.list_npc);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(733, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Npcs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(244, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 12);
            this.label14.TabIndex = 25;
            this.label14.Text = "Objects Ownership";
            // 
            // ownershipGrid
            // 
            this.ownershipGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ownershipGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownershipGrid.Location = new System.Drawing.Point(248, 173);
            this.ownershipGrid.Name = "ownershipGrid";
            this.ownershipGrid.RowTemplate.Height = 21;
            this.ownershipGrid.Size = new System.Drawing.Size(479, 76);
            this.ownershipGrid.TabIndex = 24;
            // 
            // box_schedule
            // 
            this.box_schedule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_schedule.Location = new System.Drawing.Point(511, 18);
            this.box_schedule.Name = "box_schedule";
            this.box_schedule.Size = new System.Drawing.Size(176, 19);
            this.box_schedule.TabIndex = 23;
            this.box_schedule.TextChanged += new System.EventHandler(this.box_schedule_TextChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(509, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 12);
            this.label13.TabIndex = 22;
            this.label13.Text = "Initial Schedule";
            // 
            // box_colourA
            // 
            this.box_colourA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_colourA.Location = new System.Drawing.Point(423, 129);
            this.box_colourA.Name = "box_colourA";
            this.box_colourA.Size = new System.Drawing.Size(31, 19);
            this.box_colourA.TabIndex = 21;
            this.box_colourA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_colourA_KeyPress);
            // 
            // box_colourB
            // 
            this.box_colourB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_colourB.Location = new System.Drawing.Point(369, 129);
            this.box_colourB.Name = "box_colourB";
            this.box_colourB.Size = new System.Drawing.Size(31, 19);
            this.box_colourB.TabIndex = 20;
            this.box_colourB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_colourB_KeyPress);
            // 
            // box_colourG
            // 
            this.box_colourG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_colourG.Location = new System.Drawing.Point(315, 129);
            this.box_colourG.Name = "box_colourG";
            this.box_colourG.Size = new System.Drawing.Size(31, 19);
            this.box_colourG.TabIndex = 19;
            this.box_colourG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_colourG_KeyPress);
            // 
            // box_colourR
            // 
            this.box_colourR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_colourR.Location = new System.Drawing.Point(261, 129);
            this.box_colourR.Name = "box_colourR";
            this.box_colourR.Size = new System.Drawing.Size(31, 19);
            this.box_colourR.TabIndex = 18;
            this.box_colourR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_colourR_KeyPress);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(406, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 12);
            this.label12.TabIndex = 17;
            this.label12.Text = "a";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(352, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "b";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(298, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "g";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(246, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(9, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "r";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "Color";
            // 
            // box_facingY
            // 
            this.box_facingY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_facingY.Location = new System.Drawing.Point(315, 92);
            this.box_facingY.Name = "box_facingY";
            this.box_facingY.Size = new System.Drawing.Size(31, 19);
            this.box_facingY.TabIndex = 12;
            this.box_facingY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_facingY_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "y";
            // 
            // box_facingX
            // 
            this.box_facingX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_facingX.Location = new System.Drawing.Point(261, 92);
            this.box_facingX.Name = "box_facingX";
            this.box_facingX.Size = new System.Drawing.Size(31, 19);
            this.box_facingX.TabIndex = 10;
            this.box_facingX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_facingX_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "x";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Facing";
            // 
            // box_shapeY
            // 
            this.box_shapeY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_shapeY.Location = new System.Drawing.Point(315, 55);
            this.box_shapeY.Name = "box_shapeY";
            this.box_shapeY.Size = new System.Drawing.Size(31, 19);
            this.box_shapeY.TabIndex = 7;
            this.box_shapeY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_shapeY_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "y";
            // 
            // box_shapeX
            // 
            this.box_shapeX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_shapeX.Location = new System.Drawing.Point(261, 55);
            this.box_shapeX.Name = "box_shapeX";
            this.box_shapeX.Size = new System.Drawing.Size(31, 19);
            this.box_shapeX.TabIndex = 5;
            this.box_shapeX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_shapeX_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "x";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shape (Position)";
            // 
            // box_name
            // 
            this.box_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_name.Location = new System.Drawing.Point(246, 18);
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
            this.label1.Location = new System.Drawing.Point(244, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
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
            this.list_npc.Size = new System.Drawing.Size(231, 328);
            this.list_npc.TabIndex = 0;
            this.list_npc.SelectedIndexChanged += new System.EventHandler(this.list_npc_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.list_gameObj);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(733, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GameObjects";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.list_gameObj.Size = new System.Drawing.Size(231, 328);
            this.list_gameObj.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(298, 252);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 12);
            this.label15.TabIndex = 26;
            this.label15.Text = "Add Object Ownership";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(322, 272);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 12);
            this.label16.TabIndex = 27;
            this.label16.Text = "Key";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(509, 272);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 12);
            this.label17.TabIndex = 28;
            this.label17.Text = "Value";
            // 
            // box_OwnershipAddKey
            // 
            this.box_OwnershipAddKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.box_OwnershipAddKey.Location = new System.Drawing.Point(352, 269);
            this.box_OwnershipAddKey.Name = "box_OwnershipAddKey";
            this.box_OwnershipAddKey.Size = new System.Drawing.Size(151, 19);
            this.box_OwnershipAddKey.TabIndex = 29;
            // 
            // box_OwnershipAddValue
            // 
            this.box_OwnershipAddValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.box_OwnershipAddValue.Location = new System.Drawing.Point(549, 269);
            this.box_OwnershipAddValue.Name = "box_OwnershipAddValue";
            this.box_OwnershipAddValue.Size = new System.Drawing.Size(151, 19);
            this.box_OwnershipAddValue.TabIndex = 30;
            // 
            // button_OwnershipAdd
            // 
            this.button_OwnershipAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_OwnershipAdd.Location = new System.Drawing.Point(568, 303);
            this.button_OwnershipAdd.Name = "button_OwnershipAdd";
            this.button_OwnershipAdd.Size = new System.Drawing.Size(132, 23);
            this.button_OwnershipAdd.TabIndex = 31;
            this.button_OwnershipAdd.Text = "Add Object Ownership";
            this.button_OwnershipAdd.UseVisualStyleBackColor = true;
            this.button_OwnershipAdd.Click += new System.EventHandler(this.button_OwnershipAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 422);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.button_Save);
            this.Name = "Form1";
            this.Text = "Background AI Behaviour editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownershipGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView ownershipGrid;
        private System.Windows.Forms.Button button_OwnershipAdd;
        private System.Windows.Forms.TextBox box_OwnershipAddValue;
        private System.Windows.Forms.TextBox box_OwnershipAddKey;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}


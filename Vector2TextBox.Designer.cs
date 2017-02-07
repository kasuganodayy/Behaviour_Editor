namespace Behaviour_Editor
{
    partial class Vector2TextBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_X = new System.Windows.Forms.Label();
            this.label_Y = new System.Windows.Forms.Label();
            this.decTxtBox_X = new Behaviour_Editor.DecimalTextBox();
            this.decTxtBox_Y = new Behaviour_Editor.DecimalTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.decTxtBox_X, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.decTxtBox_Y, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_X, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Y, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(245, 23);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_X.Location = new System.Drawing.Point(3, 0);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(12, 23);
            this.label_X.TabIndex = 2;
            this.label_X.Text = "X";
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_Y.Location = new System.Drawing.Point(125, 0);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(12, 23);
            this.label_Y.TabIndex = 3;
            this.label_Y.Text = "Y";
            // 
            // decTxtBox_X
            // 
            this.decTxtBox_X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decTxtBox_X.Location = new System.Drawing.Point(21, 3);
            this.decTxtBox_X.Name = "decTxtBox_X";
            this.decTxtBox_X.Size = new System.Drawing.Size(98, 17);
            this.decTxtBox_X.TabIndex = 0;
            // 
            // decTxtBox_Y
            // 
            this.decTxtBox_Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decTxtBox_Y.Location = new System.Drawing.Point(143, 3);
            this.decTxtBox_Y.Name = "decTxtBox_Y";
            this.decTxtBox_Y.Size = new System.Drawing.Size(99, 17);
            this.decTxtBox_Y.TabIndex = 1;
            // 
            // Vector2TextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Vector2TextBox";
            this.Size = new System.Drawing.Size(252, 30);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DecimalTextBox decTxtBox_X;
        private DecimalTextBox decTxtBox_Y;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Label label_Y;
    }
}

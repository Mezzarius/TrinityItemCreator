namespace TrinityItemCreator.Dialog_Forms
{
    partial class Form_Armor_Sets_Creator
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonSelectAll = new System.Windows.Forms.Button();
            this.ButtonFinish = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.page1ArmorSetCreator1 = new TrinityItemCreator.Dialog_Forms.Page1ArmorSetCreator();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.ButtonSelectAll);
            this.panel3.Controls.Add(this.ButtonFinish);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 485);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(675, 42);
            this.panel3.TabIndex = 153;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(211, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 27);
            this.button1.TabIndex = 156;
            this.button1.Text = "Copy to Clipboard";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ButtonSelectAll
            // 
            this.ButtonSelectAll.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ButtonSelectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSelectAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonSelectAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.ButtonSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSelectAll.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSelectAll.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonSelectAll.Location = new System.Drawing.Point(26, 8);
            this.ButtonSelectAll.Name = "ButtonSelectAll";
            this.ButtonSelectAll.Size = new System.Drawing.Size(164, 27);
            this.ButtonSelectAll.TabIndex = 155;
            this.ButtonSelectAll.Text = "Export as *SQL";
            this.ButtonSelectAll.UseVisualStyleBackColor = false;
            // 
            // ButtonFinish
            // 
            this.ButtonFinish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonFinish.BackColor = System.Drawing.Color.DarkGray;
            this.ButtonFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonFinish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonFinish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.ButtonFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFinish.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFinish.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonFinish.Location = new System.Drawing.Point(533, 8);
            this.ButtonFinish.Name = "ButtonFinish";
            this.ButtonFinish.Size = new System.Drawing.Size(117, 27);
            this.ButtonFinish.TabIndex = 154;
            this.ButtonFinish.Text = "EXIT (ESC)";
            this.ButtonFinish.UseVisualStyleBackColor = false;
            this.ButtonFinish.Click += new System.EventHandler(this.ButtonFinish_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 42);
            this.panel1.TabIndex = 152;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(209, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(342, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Armor Sets Creator (Database Connection Mandatory)";
            // 
            // button2
            // 
            this.button2.Image = global::TrinityItemCreator.Properties.Resources.icon_arrow_next_step;
            this.button2.Location = new System.Drawing.Point(12, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 39);
            this.button2.TabIndex = 155;
            this.button2.Text = "Step 1";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // page1ArmorSetCreator1
            // 
            this.page1ArmorSetCreator1.BackColor = System.Drawing.Color.Gainsboro;
            this.page1ArmorSetCreator1.Dock = System.Windows.Forms.DockStyle.Right;
            this.page1ArmorSetCreator1.Location = new System.Drawing.Point(140, 42);
            this.page1ArmorSetCreator1.Name = "page1ArmorSetCreator1";
            this.page1ArmorSetCreator1.Size = new System.Drawing.Size(535, 443);
            this.page1ArmorSetCreator1.TabIndex = 156;
            // 
            // Form_Armor_Sets_Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(675, 527);
            this.ControlBox = false;
            this.Controls.Add(this.page1ArmorSetCreator1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Armor_Sets_Creator";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Window_FlagMask";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Armor_Sets_Creator_FormClosed);
            this.Load += new System.EventHandler(this.Form_Armor_Sets_Creator_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Armor_Sets_Creator_KeyDown);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button ButtonSelectAll;
        private System.Windows.Forms.Button ButtonFinish;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Page1ArmorSetCreator page1ArmorSetCreator1;
    }
}
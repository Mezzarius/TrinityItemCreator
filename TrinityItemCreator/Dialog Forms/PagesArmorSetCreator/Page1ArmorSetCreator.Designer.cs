namespace TrinityItemCreator.Dialog_Forms
{
    partial class Page1ArmorSetCreator
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
            this.components = new System.ComponentModel.Container();
            this.Title = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckEntriesAvailability = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.entryto = new MyTextBox();
            this.entryfrom = new MyTextBox();
            this.myTextBox2 = new MyTextBox();
            this.myTextBox1 = new MyTextBox();
            this.TextBoxPrefix = new MyTextBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(502, 20);
            this.Title.TabIndex = 0;
            this.Title.Text = "Ok, let\'s begin with something basic";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(17, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 163;
            this.label1.Text = "Chose a suffix";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 17);
            this.label2.TabIndex = 161;
            this.label2.Text = "Chose a prefix for your new items";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(17, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(397, 17);
            this.label3.TabIndex = 165;
            this.label3.Text = "Tell me which itemsets you want to duplicate, separate by space";
            // 
            // CheckEntriesAvailability
            // 
            this.CheckEntriesAvailability.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckEntriesAvailability.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CheckEntriesAvailability.Location = new System.Drawing.Point(302, 220);
            this.CheckEntriesAvailability.Name = "CheckEntriesAvailability";
            this.CheckEntriesAvailability.Size = new System.Drawing.Size(132, 23);
            this.CheckEntriesAvailability.TabIndex = 166;
            this.CheckEntriesAvailability.Text = "Check";
            this.CheckEntriesAvailability.UseVisualStyleBackColor = true;
            this.CheckEntriesAvailability.Click += new System.EventHandler(this.CheckEntriesAvailability_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(17, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(417, 17);
            this.label4.TabIndex = 168;
            this.label4.Text = "New items start entry from and end to (I recommend between 100)";
            // 
            // entryto
            // 
            this.entryto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entryto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryto.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.entryto.Location = new System.Drawing.Point(161, 224);
            this.entryto.Name = "entryto";
            this.entryto.Size = new System.Drawing.Size(135, 18);
            this.entryto.TabIndex = 169;
            this.entryto.Tag = "";
            this.entryto.Text = "100200";
            this.entryto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // entryfrom
            // 
            this.entryfrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entryfrom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryfrom.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.entryfrom.Location = new System.Drawing.Point(20, 224);
            this.entryfrom.Name = "entryfrom";
            this.entryfrom.Size = new System.Drawing.Size(135, 18);
            this.entryfrom.TabIndex = 167;
            this.entryfrom.Tag = "";
            this.entryfrom.Text = "100100";
            this.entryfrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // myTextBox2
            // 
            this.myTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myTextBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myTextBox2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.myTextBox2.Location = new System.Drawing.Point(20, 171);
            this.myTextBox2.Name = "myTextBox2";
            this.myTextBox2.Size = new System.Drawing.Size(414, 18);
            this.myTextBox2.TabIndex = 164;
            this.myTextBox2.Tag = "";
            // 
            // myTextBox1
            // 
            this.myTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myTextBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.myTextBox1.Location = new System.Drawing.Point(20, 121);
            this.myTextBox1.Name = "myTextBox1";
            this.myTextBox1.Size = new System.Drawing.Size(414, 18);
            this.myTextBox1.TabIndex = 162;
            this.myTextBox1.Tag = "";
            // 
            // TextBoxPrefix
            // 
            this.TextBoxPrefix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPrefix.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPrefix.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.TextBoxPrefix.Location = new System.Drawing.Point(20, 70);
            this.TextBoxPrefix.Name = "TextBoxPrefix";
            this.TextBoxPrefix.Size = new System.Drawing.Size(414, 18);
            this.TextBoxPrefix.TabIndex = 160;
            this.TextBoxPrefix.Tag = "";
            // 
            // Page1ArmorSetCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.entryto);
            this.Controls.Add(this.entryfrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CheckEntriesAvailability);
            this.Controls.Add(this.myTextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.myTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxPrefix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Title);
            this.Name = "Page1ArmorSetCreator";
            this.Size = new System.Drawing.Size(502, 343);
            this.Load += new System.EventHandler(this.Page1ArmorSetCreator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Timer timer1;
        public MyTextBox myTextBox1;
        private System.Windows.Forms.Label label1;
        public MyTextBox TextBoxPrefix;
        private System.Windows.Forms.Label label2;
        public MyTextBox myTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CheckEntriesAvailability;
        public MyTextBox entryfrom;
        private System.Windows.Forms.Label label4;
        public MyTextBox entryto;
    }
}

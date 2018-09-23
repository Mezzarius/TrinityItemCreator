using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityItemCreator.MyClass;

namespace TrinityItemCreator
{
    public partial class Form3 : Form
    {
        private Form1 mainForm;

        public Form3(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000;  // Turn off WS_CLIPCHILDREN
                return parms;
            }
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void Watermark_myTextBox_Leave(object sender, EventArgs e)
        {
            MyTextBox mTextBox = (MyTextBox)sender;
            if (mTextBox.Text.Length == 0)
            {
                mTextBox.Text = "Required!";
                mTextBox.ForeColor = Color.Red;
            }
        }
        private void Watermark_myTextBox_Enter(object sender, EventArgs e)
        {
            MyTextBox mTextBox = (MyTextBox)sender;
            if (mTextBox.Text == "Required!")
            {
                mTextBox.Text = "";
                mTextBox.ForeColor = Color.DimGray;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            MyData myData = new MyData();
            string path = "templates";

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            string filepath = string.Format(path + @"\{0}.txt", myTextBox2.Text);
            if (myTextBox2.Text != "Required!")
            {
                if (!File.Exists(filepath))
                {
                    using (TextWriter tw = new StreamWriter(filepath))
                    {
                        tw.Write(myData.GetTemplateDataAsString());
                        tw.Close();
                    }
                    Close();
                }
                else
                {
                    LabelWarning.Text = "Name already in use!";
                    LabelWarning.ForeColor = Color.Red;
                }
            }
            else
                LabelWarning.Text = "Please use a valid name!";
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

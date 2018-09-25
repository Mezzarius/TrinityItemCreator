using System;
using System.Drawing;
using System.IO;
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

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            mainForm = form1;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
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

            if (myTextBox2.Text != "Required!")
            {
                if (!myData.SaveNewTemplateAsXML(myTextBox2.Text))
                {
                    LabelWarning.Text = "Name already in use!";
                    LabelWarning.ForeColor = Color.Red;
                }
                else
                    Close();
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

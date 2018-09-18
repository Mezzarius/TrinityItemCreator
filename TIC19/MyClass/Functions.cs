using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TIC19.MyClass
{
    class Functions
    {
        private Form1 mainForm;

        public Functions(Form1 form1)
        {
            mainForm = form1;
        }

        public void UnBlurMainForm()
        {
            mainForm.panel1.BackColor = Color.DarkCyan;
        }

        public string SpliceText(string text, int lineLength)
        {
            return Regex.Replace(text, "(.{" + lineLength + "})", "$1" + Environment.NewLine);
        }

        public void LoadTextBoxWaterMarks()
        {
            string placeHolder = "Required!";

            mainForm.myTextBox1.Text = placeHolder; // Textbox ENTRY
            mainForm.myTextBox2.Text = placeHolder; // Textbox NAME
            mainForm.myTextBox4.Text = placeHolder; // Textbox DISPLAY ID
        }

        public void SelectComboBoxIndexes()
        {
            foreach (var comboBox in mainForm.Controls.OfType<ComboBox>()) comboBox.SelectedIndex = 0;
        }

        public void EnableButtons()
        {
            foreach (var menuStrip in mainForm.Controls.OfType<MenuStrip>()) menuStrip.Enabled = true;
            foreach (var mtextBox in mainForm.Controls.OfType<MyTextBox>()) mtextBox.Enabled = true;
            foreach (var comboBox in mainForm.Controls.OfType<ComboBox>()) comboBox.Enabled = true;
            foreach (var button in mainForm.Controls.OfType<Button>()) button.Enabled = true;
            foreach (var picBox in mainForm.Controls.OfType<PictureBox>()) picBox.Enabled = true;
        }
    }
}

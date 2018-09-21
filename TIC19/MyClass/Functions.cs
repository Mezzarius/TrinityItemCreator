using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Reflection;

namespace TIC19.MyClass
{
    class Functions
    {
        private Form1 mainForm;

        public Functions() { }

        public Functions(Form1 form1)
        {
            mainForm = form1;
        }

        public void UnBlurMainForm()
        {
            foreach (var menuStrip in mainForm.Controls.OfType<MenuStrip>()) menuStrip.Enabled = true;
            foreach (var mtextBox in mainForm.Controls.OfType<MyTextBox>()) mtextBox.Enabled = true;
            foreach (var comboBox in mainForm.Controls.OfType<ComboBox>()) comboBox.Enabled = true;
            foreach (var button in mainForm.Controls.OfType<Button>()) button.Enabled = true;
            foreach (var picBox in mainForm.Controls.OfType<PictureBox>()) picBox.Enabled = true;

            mainForm.panel1.BackColor = Color.DarkSlateGray;
        }

        public void StartupSetComboBoxIndexes()
        {
            foreach (var comboBox in mainForm.Controls.OfType<ComboBox>())
            {
                if (comboBox.Name == "comboBox20") // exception because -1 Consumable
                    comboBox.SelectedIndex = 1;
                else
                    comboBox.SelectedIndex = 0;
            }
        }
    }
}

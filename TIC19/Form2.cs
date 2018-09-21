using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIC19
{
    public partial class Form2 : Form
    {
        private Form1 mainForm;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            var myCF = new MyClass.Functions(mainForm);
            myCF.StartupSetComboBoxIndexes();

            Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            var myCF = new MyClass.Functions(mainForm);
            myCF.UnBlurMainForm();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                Close();
        }
    }
}

using System;
using System.Windows.Forms;
using TIC19.MyClass;

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
            Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            var myCF = new Functions(mainForm);
            myCF.UnBlurMainForm();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(0);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(1);
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(2);
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(3);
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(4);
            Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(5);
            Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(6);
            Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(7);
            Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(8);
            Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(9);
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(10);
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(11);
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(13);
            Close();
        }
    }
}

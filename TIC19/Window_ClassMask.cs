﻿using System;
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
    public partial class Window_ClassMask : Form
    {
        private Form1 mainForm;

        public Window_ClassMask(Form1 form1)
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

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

        private void Window_ClassMask_Load(object sender, EventArgs e)
        {
            var myCF = new MyClass.Functions(mainForm);
            myCF.BlurMainFormEffect();
        }

        private void Window_ClassMask_FormClosed(object sender, FormClosedEventArgs e)
        {
            var myCF = new MyClass.Functions(mainForm);
            myCF.UnBlurMainForm();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
            mainForm.panel1.BackColor = Color.Silver;
        }
    }
}

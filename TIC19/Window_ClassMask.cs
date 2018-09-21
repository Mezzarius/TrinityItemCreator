using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIC19.MyClass;

namespace TIC19
{
    public partial class Window_ClassMask : Form
    {
        private Form1 mainForm;
        private static bool mIsChecked = false;
        private static bool[] mCheckBoxesSate = new bool[1025];

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

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            foreach (var chkBox in Controls.OfType<CheckBox>()) chkBox.Checked = mIsChecked ? false : true;
            mIsChecked = mIsChecked ? false : true;
        }

        private void Window_ClassMask_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void Window_ClassMask_FormClosed(object sender, FormClosedEventArgs e)
        {
            int classMask = -1;

            foreach (var chkBox in Controls.OfType<CheckBox>())
            {
                int mTAG = (Convert.ToInt32(chkBox.Tag));

                classMask += chkBox.Checked ? mTAG : 0;
                // save checkbox checked state by index
                mCheckBoxesSate[mTAG] = chkBox.Checked;
            }
            QueryHandler.column_AllowableRace = classMask;
        }

        private void Window_ClassMask_Load(object sender, EventArgs e)
        {
            foreach (var chkBox in Controls.OfType<CheckBox>())
            {
                int mTAG = Convert.ToInt32(chkBox.Tag);
                chkBox.Checked = mCheckBoxesSate[mTAG];
            }
        }
    }
}

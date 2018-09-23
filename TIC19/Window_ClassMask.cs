using System;
using System.Linq;
using System.Windows.Forms;
using TrinityItemCreator.MyClass;

namespace TrinityItemCreator
{
    public partial class Window_ClassMask : Form
    {
        private Form1 mainForm;
        private static bool mIsChecked = false;
        private static int classMaskHex = 0;

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
            int _mask = 0; // start from 0 not -1

            foreach (var chkBox in Controls.OfType<CheckBox>())
            {
                if (chkBox.Checked)
                    _mask += Convert.ToInt32(chkBox.Tag);
            }

            QueryHandler.column_AllowableClass = _mask == 1535 ? -1 : _mask;
            classMaskHex = _mask;
        }

        private void Window_ClassMask_Load(object sender, EventArgs e)
        {
            classMaskHex = QueryHandler.column_AllowableClass == -1 ? 1535 : QueryHandler.column_AllowableClass;
            foreach (var chkBox in Controls.OfType<CheckBox>())
            {
                if ((classMaskHex & Convert.ToInt32(chkBox.Tag)) != 0)
                    chkBox.Checked = true;
            }
        }
    }
}

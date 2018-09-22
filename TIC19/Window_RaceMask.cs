using System;
using System.Linq;
using System.Windows.Forms;
using TIC19.MyClass;

namespace TIC19
{
    public partial class Window_RaceMask : Form
    {
        private Form1 mainForm;
        private static bool mIsChecked = false;
        private static int raceMaskHex = 0;

        public Window_RaceMask(Form1 form1)
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
            foreach (var chkBox in Controls.OfType<CheckBox>())
                chkBox.Checked = mIsChecked ? false : true;

            mIsChecked = mIsChecked ? false : true;
        }

        private void Window_RaceMask_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void Window_RaceMask_FormClosed(object sender, FormClosedEventArgs e)
        {
            int _mask = 0; // start from 0 not -1

            foreach (var chkBox in Controls.OfType<CheckBox>())
            {
                if (chkBox.Checked)
                    _mask += Convert.ToInt32(chkBox.Tag);
            }

            QueryHandler.column_AllowableRace = _mask == 1791 ? -1 : _mask;
            raceMaskHex = _mask;
        }

        private void Window_RaceMask_Load(object sender, EventArgs e)
        {
            raceMaskHex = QueryHandler.column_AllowableRace == -1 ? 1791 : QueryHandler.column_AllowableRace;
            foreach (var chkBox in Controls.OfType<CheckBox>())
            {
                if ((raceMaskHex & Convert.ToInt32(chkBox.Tag)) != 0)
                    chkBox.Checked = true;
            }
        }
    }
}

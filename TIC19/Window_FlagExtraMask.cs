using System;
using System.Windows.Forms;
using TrinityItemCreator.MyClass;

namespace TrinityItemCreator
{
    public partial class Window_FlagExtraMask : Form
    {
        private Form1 mainForm;
        private static bool mIsChecked;
        private static int checkedListHex = 0;

        public Window_FlagExtraMask(Form1 form1)
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
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, mIsChecked ? false : true);

            mIsChecked = mIsChecked ? false : true;
        }

        private void Window_FlagExtraMask_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void Window_FlagExtraMask_FormClosed(object sender, FormClosedEventArgs e)
        {
            int extraFlagMask = 0;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    string s = checkedListBox1.Items[i].ToString();
                    extraFlagMask += Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
                }
            }

            QueryHandler.column_FlagsExtra = extraFlagMask;
            checkedListHex = extraFlagMask;
        }

        private void Window_FlagExtraMask_Load(object sender, EventArgs e)
        {
            checkedListHex = QueryHandler.column_FlagsExtra;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                string s = checkedListBox1.Items[i].ToString();
                if ((checkedListHex & Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1))) != 0)
                    checkedListBox1.SetItemChecked(i, true);
            }
        }
    }
}

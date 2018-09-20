using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIC19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
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

        private bool mouseDown;
        private Point lastLocation;

        private void Form1_Shown(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var myCF = new MyClass.Functions(this);
            myCF.LoadTextBoxWaterMarks();
        }

        private void Watermark_myTextBox_Leave(object sender, EventArgs e)
        {
            MyTextBox mTextBox = (MyTextBox)sender;
            if (mTextBox.Text.Length == 0)
            {
                mTextBox.Text = "Required!";
                mTextBox.ForeColor = Color.Red;
            }
        }

        private void Watermark_myTextBox_Enter(object sender, EventArgs e)
        {
            MyTextBox mTextBox = (MyTextBox)sender;
            if (mTextBox.Text == "Required!")
            {
                mTextBox.Text = "";
                mTextBox.ForeColor = Color.DimGray;
            }
        }

        private void Watermark_myTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point( (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y );
                Update();
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            var wr = new Window_Resistances(this);
            wr.ShowDialog();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            var woO = new Window_Other_Options(this);
            woO.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var wcM = new Window_ClassMask(this);
            wcM.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var wbF = new Window_BagFamilyMask(this);
            wbF.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var wrM = new Window_RaceMask(this);
            wrM.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var wfM = new Window_FlagMask(this);
            wfM.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            var wfEM = new Window_FlagExtraMask(this);
            wfEM.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            var wfCM = new Window_FlagCustomMask(this);
            wfCM.ShowDialog();
        }

        private void CopyToClipboardCTRLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // copy to clipboard
        }

        private void SQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // save as *.sql
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (ModifierKeys.HasFlag(Keys.Control) && e.KeyCode == Keys.D1)
            {
                var wcM = new Window_ClassMask(this);
                wcM.ShowDialog();
            }
            else if (ModifierKeys.HasFlag(Keys.Control) && e.KeyCode == Keys.D2)
            {
                var wrM = new Window_RaceMask(this);
                wrM.ShowDialog();
            }
            else if (ModifierKeys.HasFlag(Keys.Control) && e.KeyCode == Keys.D3)
            {
                var wbF = new Window_BagFamilyMask(this);
                wbF.ShowDialog();
            }
            else if (ModifierKeys.HasFlag(Keys.Shift) && e.KeyCode == Keys.D1)
            {
                var wfM = new Window_FlagMask(this);
                wfM.ShowDialog();
            }
            else if (ModifierKeys.HasFlag(Keys.Shift) && e.KeyCode == Keys.D2)
            {
                var wfEM = new Window_FlagExtraMask(this);
                wfEM.ShowDialog();
            }
            else if (ModifierKeys.HasFlag(Keys.Shift) && e.KeyCode == Keys.D3)
            {
                var wfCM = new Window_FlagCustomMask(this);
                wfCM.ShowDialog();
            }
            else if (ModifierKeys.HasFlag(Keys.Control) && e.KeyCode == Keys.R)
            {
                var wr = new Window_Resistances(this);
                wr.ShowDialog();
            }
            else if (ModifierKeys.HasFlag(Keys.Control) && e.KeyCode == Keys.O)
            {
                var woO = new Window_Other_Options(this);
                woO.ShowDialog();
            }
        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application developer: [artister.hd@gmail.com] All Rights Reservered!");
        }
    }
}

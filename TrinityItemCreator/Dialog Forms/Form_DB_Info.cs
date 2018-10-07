using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrinityItemCreator.Dialog_Forms
{
    public partial class Form_DB_Info : Form
    {
        public Form_DB_Info()
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void Watermark_myTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void TextBoxAddress_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.db_hostname = TextBoxAddress.Text;
        }

        private void TextBoxPort_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.db_port = TextBoxPort.Text;
        }

        private void TextBoxUser_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.db_user = TextBoxUser.Text;
        }

        private void TextBoxPass_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.db_pass = TextBoxPass.Text;
        }

        private void TextBoxDB_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.db_name = TextBoxDB.Text;
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            Close();
        }

        private void Form_DB_Info_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                ButtonCancel_Click(sender, e);
            else if (e.KeyCode == Keys.Enter)
                ButtonApply_Click(sender, e);
        }

        private void Form_DB_Info_Load(object sender, EventArgs e)
        {
            TextBoxAddress.Text = Properties.Settings.Default.db_hostname;
            TextBoxPort.Text = Properties.Settings.Default.db_port;
            TextBoxUser.Text = Properties.Settings.Default.db_user;
            TextBoxPass.Text = Properties.Settings.Default.db_pass;
            TextBoxDB.Text = Properties.Settings.Default.db_name;
        }
    }
}

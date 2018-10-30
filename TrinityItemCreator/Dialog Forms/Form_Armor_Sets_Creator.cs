using MySql.Data.MySqlClient;
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
    public partial class Form_Armor_Sets_Creator : Form
    {
        private Form_Main mainForm;

        public Form_Armor_Sets_Creator(Form_Main form1)
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            mainForm = form1;
        }

        private static MySqlConnection conn = null;
        public static MySqlConnection SQLConnection { get => conn; set => conn = value; }

        public static string SQLConnInfo = $"SERVER={Properties.Settings.Default.db_hostname};PORT={Properties.Settings.Default.db_port}" +
        $";DATABASE={Properties.Settings.Default.db_name};UID={Properties.Settings.Default.db_user}" +
        $";PASSWORD={Properties.Settings.Default.db_pass};SSLMODE=NONE;";

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void Watermark_MyTextBox_Leave(object sender, EventArgs e)
        {
            MyTextBox mTextBox = (MyTextBox)sender;
            if (mTextBox.Text.Length == 0)
                mTextBox.Text = "0";
        }

        private void Watermark_MyTextBox_Enter(object sender, EventArgs e)
        {
            MyTextBox mTextBox = (MyTextBox)sender;
            if (mTextBox.Text == "0")
                mTextBox.Text = "";
        }

        private void Watermark_MyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Form_Armor_Sets_Creator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void ButtonFinish_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Armor_Sets_Creator_Load(object sender, EventArgs e)
        {
            SQLConnection = new MySqlConnection(SQLConnInfo);
            SQLConnection.Open();
        }

        private void Form_Armor_Sets_Creator_FormClosed(object sender, FormClosedEventArgs e)
        {
            SQLConnection.Close();
            SQLConnection.Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityItemCreator.MyClass;

namespace TrinityItemCreator.Dialog_Forms
{
    public partial class Form_ItemTemplate : Form
    {
        private Form_Main mainForm;

        public Form_ItemTemplate(Form_Main form1)
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            mainForm = form1;
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

        private void Form_ItemTemplate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_ItemTemplate_Load(object sender, EventArgs e)
        {
            ListBoxItemTemplate.SelectedIndex = Properties.Settings.Default.item_template_selected;
        }

        private void Form_ItemTemplate_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.item_template_selected = ListBoxItemTemplate.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Stats_Generator fsts = new Form_Stats_Generator(mainForm);
            fsts.ShowDialog();
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            
        }
    }
}

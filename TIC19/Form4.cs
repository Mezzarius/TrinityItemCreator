using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityItemCreator.MyClass;

namespace TrinityItemCreator
{
    public partial class Form4 : Form
    {
        private Form1 mainForm;

        public Form4(Form1 form1)
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

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            else if (e.KeyCode == Keys.Space)
            {
                DoTheLoadTemplate();
                Close();
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(@"Templates", "*.txt", SearchOption.TopDirectoryOnly).Select(file => Path.GetFileNameWithoutExtension(file)).ToArray();
            listBox1.Items.AddRange(files);

            if (files == null || files.Length == 0)
                button15.Enabled = false;
            else
                listBox1.SelectedIndex = 0;
        }
        
        private void Button15_Click(object sender, EventArgs e)
        {
            DoTheLoadTemplate();
            Close();
        }

        private void DoTheLoadTemplate()
        {
            Functions mCF = new Functions(mainForm);
            mCF.LoadDefaultTemplate(14, File.ReadAllLines(string.Format(@"Templates\{0}.txt", listBox1.SelectedItem.ToString())));
        }
    }
}

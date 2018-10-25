using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TrinityItemCreator.Dialog_Forms;
using TrinityItemCreator.MyClass;

namespace TrinityItemCreator
{
    public partial class Form_Main : Form
    {
        public Form_Main()
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

        private bool mouseDown;
        private Point lastLocation;

        private void Form1_Shown(object sender, EventArgs e)
        {
            Form_Default_Templates form2 = new Form_Default_Templates(this);
            form2.ShowDialog();
        }

        private void Watermark_myTextBox_Leave(object sender, EventArgs e)
        {
            MyTextBox mTextBox = (MyTextBox)sender;
            if (mTextBox.Text.Length == 0)
                mTextBox.Text = "0";
        }

        private void Watermark_myTextBox_Enter(object sender, EventArgs e)
        {
            MyTextBox mTextBox = (MyTextBox)sender;
            if (mTextBox.Text == "0")
                mTextBox.Text = "";
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
                Location = new Point((Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            var wr = new Form_Resistances(this);
            wr.ShowDialog();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            var woO = new Form_Other_Columns(this);
            woO.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var wcM = new Form_Allowable_Class(this);
            wcM.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var wbF = new Form_Bag_Family_Mask(this);
            wbF.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var wrM = new Form_Allowable_Race(this);
            wrM.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var wfM = new Form_Flags(this);
            wfM.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            var wfEM = new Form_Flags_Extra(this);
            wfEM.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            var wfCM = new Form_Flags_Custom(this);
            wfCM.ShowDialog();
        }

        private void CopyToClipboardCTRLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(QueryHandler.GetExportQuery());
            MessageBox.Show("Copied to clipboard!");
        }

        private void SQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog
            {
                FileName = MyData.Field_entry.ToString() + "_" + MyData.Field_name,
                Filter = "SQL File | *.sql"
            };

            if (sd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sd.FileName))
                {
                    sw.Write(QueryHandler.GetExportQuery());
                    sw.Flush();
                    sw.Close();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control) && e.KeyCode == Keys.R)
            {
                var wr = new Form_Resistances(this);
                wr.ShowDialog();
            }
            else if (ModifierKeys.HasFlag(Keys.Control) && e.KeyCode == Keys.O)
            {
                var woO = new Form_Other_Columns(this);
                woO.ShowDialog();
            }
        }

        private void ABOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Application developer: [artister.hd@gmail.com]\n"
                +"\n"
                +"CONTRIBUTORS:\n \n"
                + " Sdyees (Code Cleanup), Freddan962 (Item.dbc Converter)"
                );
        }

        private void MyTextBoxValue_Changed(object sender, EventArgs e) => MyData.ItemTemplateValues[int.Parse(((MyTextBox)sender).Tag.ToString())] = ((MyTextBox)sender).Text;

        private void MyComboBoxValue_Changed(object sender, EventArgs e)
        {
            ComboBox combobox = (ComboBox)sender;
            string s = combobox.SelectedItem.ToString();
            if (combobox.Name == "ComboBoxClass")
            {
                MyData.ItemTemplateValues[int.Parse((combobox.Tag.ToString()))] = s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1);

                ComboBoxSubclass.Items.Clear();
                ComboBoxSubclass.Items.AddRange(MyData.SubClassArray[ComboBoxClass.SelectedIndex]);

                if (Functions.PreLoadSubClassMenu)
                    Functions.PreLoadSubClassMenu = false;
                else
                    ComboBoxSubclass.SelectedIndex = 0;
            }
            else
            {
                MyData.ItemTemplateValues[int.Parse((combobox.Tag.ToString()))] = s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Functions myF = new Functions(this);
            myF.DelayMainFormPainting();
            myF.SetFlagsMasksButtonCurrentValue();

            toolStripComboBox1.SelectedIndex = toolStripComboBox1.FindStringExact(Properties.Settings.Default.SQLPrefix);

            // This is happening before closing form2
            if (!Functions.preLoadTemplate)
                myF.LoadDefaultTemplate(99999);

            string dbConnection = "Database Connection: ";
            LabelDBConnection.Text = dbConnection + (Functions.IsDBConnected() ? "Yes" : "None");
            LabelDBConnection.ForeColor = Functions.IsDBConnected() ? Color.LimeGreen : Color.IndianRed;
        }

        private void SaveCurrentTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Save_Custom_Template form3 = new Form_Save_Custom_Template(this);
            form3.ShowDialog();
        }

        private void LoadCustomTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Load_Custom_Template form4 = new Form_Load_Custom_Template(this);
            form4.ShowDialog();
        }

        private void LoadDefaultTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Default_Templates form2 = new Form_Default_Templates(this);
            form2.ShowDialog();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Functions myF = new Functions(this);
            myF.DelayMainFormPainting();
        }

        private void RandomStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Stats_Generator wgs = new Form_Stats_Generator(this);
            wgs.ShowDialog();
        }

        private void DisplayIDFinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DisplayID_Finder wdf = new Form_DisplayID_Finder(this);
            wdf.ShowDialog();
        }

        private void ToolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SQLPrefix = toolStripComboBox1.SelectedItem.ToString();
            Properties.Settings.Default.Save();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;
            var dragFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (dragFiles.Length == 1)
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (var file in files)
                {
                    var ext = Path.GetExtension(file);
                    if (ext.Equals(".xml", StringComparison.CurrentCultureIgnoreCase))
                    {
                        e.Effect = DragDropEffects.Copy;

                        Panel MyDragOverPanel = new Panel();

                        MyDragOverPanel.BackColor = SystemColors.ControlLight;
                        MyDragOverPanel.BackgroundImage = Properties.Resources.Copy_File_512;
                        MyDragOverPanel.BackgroundImageLayout = ImageLayout.Center;
                        MyDragOverPanel.Location = new Point(0, 0);
                        MyDragOverPanel.Dock = DockStyle.Fill;
                        MyDragOverPanel.Tag = "dragOverPanel";

                        Controls.Add(MyDragOverPanel);
                        MyDragOverPanel.BringToFront();
                    }
                    else
                        e.Effect = DragDropEffects.None;
                }
            }
        }

        private void Form1_DragLeave(object sender, EventArgs e)
        {
            RemoveDragOverPanel();
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            RemoveDragOverPanel();

            Functions fs = new Functions(this);
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string File in FileList)
                fs.LoadMyCustomTemplate(File, true);

            MessageBox.Show("Loaded an XML template.");
        }

        private void RemoveDragOverPanel()
        {
            foreach (Control item in Controls.OfType<Control>())
            {
                if (item.Tag.ToString() == "dragOverPanel")
                {
                    Controls.Remove(item);
                    break; // appears to be necesary
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form_Item_Description wed = new Form_Item_Description(this);
            wed.ShowDialog();
        }

        private void ResetAllFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to reset all fields??", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Functions mF = new Functions(this);
                mF.DoResetAllFields();
            }
        }

        private void mySQLConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DB_Info Fdbi = new Form_DB_Info(this);
            Fdbi.ShowDialog();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Do you want to import this item in your database?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Functions mF = new Functions(this);
                mF.ImportSQLItem();
            }
        }

        private void makeItemdbcToolStripMenuItem_Click(object sender, EventArgs e)
        { DialogResult result = MessageBox.Show("This feature will use database connection to receive items list!\n\n" +
            $"Do you want to generate Item.dbc?\n\n" +
            $"Check this application's folder after conversion is complete", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Functions myf = new Functions();
                if (myf.LoadItems())
                    myf.ItemsToDBC();
            }
        }

        private void TableItemtemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ItemTemplate Fitt = new Form_ItemTemplate(this);
            Fitt.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TrinityItemCreator.Dialog_Forms
{
    public partial class Page1ArmorSetCreator : UserControl
    {
        public Page1ArmorSetCreator()
        {
            InitializeComponent();
        }

        private void Page1ArmorSetCreator_Load(object sender, EventArgs e)
        {
            Title.ForeColor = BackColor;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int fadingSpeed = 2;
            Title.ForeColor = Color.FromArgb(Title.ForeColor.R - fadingSpeed, Title.ForeColor.G - fadingSpeed, Title.ForeColor.B - fadingSpeed);

            if (Title.ForeColor.R <= Color.DarkSlateGray.R)
            {
                timer1.Stop();
                timer1.Dispose();
                Title.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CheckEntriesAvailability_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM item_template WHERE entry BETWEEN {entryfrom.Text} AND {entryto.Text}";
            MySqlCommand cmd = new MySqlCommand(sql, connection: Form_Armor_Sets_Creator.SQLConnection);
            if (cmd.ExecuteScalar() == null) // these entries are free
            {
                CheckEntriesAvailability.Text = "Available";
            }
            else
            {
                CheckEntriesAvailability.Text = "Unavailable";
            }
        }
    }
}

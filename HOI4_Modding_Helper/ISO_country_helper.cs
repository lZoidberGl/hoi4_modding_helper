using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOI4_Modding_Helper
{
    public partial class ISO_country_helper : Form
    {
        public ISO_country_helper()
        {
            InitializeComponent();
        }

        private void ISO_country_helper_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] txt = textBox2.Text.Split( Environment.NewLine.ToCharArray() , StringSplitOptions.RemoveEmptyEntries);

            foreach (string t in txt)
            {
                dataGridView1.Rows.Add(t.Substring(0,3), t.Remove(0,4));
            }
        }


    }
}

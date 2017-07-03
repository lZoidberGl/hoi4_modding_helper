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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Form GFXHLP = new GFX_Helper();
        Form FocusHelp = new EasyFocusTree();
        Form StateHelp = new state_helper_form();
        Form ISO_helper = new ISO_country_helper();

        private void to_GFX_Click(object sender, EventArgs e)
        {
            GFXHLP.Show();
        }

        private void toEasyFocus_Click(object sender, EventArgs e)
        {
            FocusHelp.Show();
        }

        private void to_state_helper_Click(object sender, EventArgs e)
        {
            StateHelp.Show();
        }

        private void to_ISO_Helper_Click(object sender, EventArgs e)
        {
            ISO_helper.Show();
        }
    }
}

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

        private void to_GFX_Click(object sender, EventArgs e)
        {
            GFXHLP.Show();
        }

        private void toEasyFocus_Click(object sender, EventArgs e)
        {
            FocusHelp.Show();
        }

        private void to_hz_helper_Click(object sender, EventArgs e)
        {
            StateHelp.Show();
        }
    }
}

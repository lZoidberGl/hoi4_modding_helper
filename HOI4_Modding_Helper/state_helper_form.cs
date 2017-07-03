using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HOI4_Modding_Helper
{
    public partial class state_helper_form : Form
    {
        public state_helper_form()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        bool DebugMode = false;


        private void state_helper_form_Load(object sender, EventArgs e)
        {
            if (Application.StartupPath.Contains("Debug"))
            {
                debug_button.Show();
            }

            read_last_session();
        }

        private void read_last_session()
        {
            if (File.Exists("savedsession.txt"))
            {
                var answ = MessageBox.Show("Хотите ли подгрузить сохраненную сессию?", "Сохраненная сессия", MessageBoxButtons.YesNo);
                


                if (answ == DialogResult.Yes)
                {

                    string[] session = File.ReadAllLines("savedsession.txt");

                    foreach (string sl in session)
                    {
                        if (sl.Length >= 3)
                        {
                            try
                            {
                                if (sl.Contains('-'))
                                {
                                    dataGridView1.Rows.Add(noSpaces(sl).Substring(0, 3), noSpaces(sl).Substring(noSpaces(sl).IndexOf('-') + 1, noSpaces(sl).Length - 4));
                                }
                                else
                                {
                                    dataGridView1.Rows.Add(noSpaces(sl).Substring(0, 3));
                                }
                            }
                            catch (Exception /*ex*/) { /*MessageBox.Show(ex.Message);*/ }
                        }                        
                    }
                }
                findTags.BackColor = Color.LimeGreen;
            }

        }

        private void state_helper_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void findTags_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            MessageBox.Show(ofd.FileName);
            if (ofd.FileName.Contains("countries.txt") || ofd.FileName.Contains("country_tags"))
            {
                string[] text = File.ReadAllLines(ofd.FileName);

                progressBar1.Maximum = text.Length;

                foreach (string s in text)
                {
                    if (!s.Substring(0, 3).Contains("#"))
                    {
                        dataGridView1.Rows.Add(s.Substring(0, 3));
                    }
                    progressBar1.Value++;
                }

                findTags.BackColor = Color.LimeGreen;
            }
            else
                findTags.BackColor = Color.Red;
        }

        private void states_dir_Click(object sender, EventArgs e)
        {
            fbd.SelectedPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Paradox Interactive", "Hearts of Iron IV", "mod");       

            fbd.ShowDialog();


            if (fbd.SelectedPath.Contains("\\history\\states"))
            {
                states_dir.BackColor = Color.LimeGreen;
            }
            else
            {
                states_dir.BackColor = Color.Red;
            }

        }

        private void christianityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = "christianity";
        }

        private void islamicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = "islam";
        }

        private void buddhisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = "buddhism";
        }

        private void judaisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = "judaism";
        }

        private void hinduisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = "hinduism";
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && dataGridView1.CurrentCell.ColumnIndex == 1)
            {
                contextMenuStrip1.Show(dataGridView1,e.Location);
               //MessageBox.Show(dataGridView1.CurrentCell.RowIndex.ToString());
            }
            //else
                //MessageBox.Show(dataGridView1.CurrentCell.RowIndex.ToString());
        }

        string log = "";

        private void start_Click(object sender, EventArgs e)
        {

            int fc = 0;

            if (DebugMode == true || (states_dir.BackColor == Color.LimeGreen && findTags.BackColor == Color.LimeGreen))
            {

                states_dir.Enabled = false;
                findTags.Enabled = false;

                StringBuilder strbldr = new StringBuilder();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {

                        strbldr.Append(cell.Value);
                        strbldr.Append("-");

                    }
                    strbldr.Remove(strbldr.Length - 1, 1);
                    strbldr.AppendLine();

                }
                // MessageBox.Show(strbldr.ToString());

                MessageBox.Show(String.Join(Environment.NewLine,strbldr.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)));

                log = "Starting logging";

                strbldr.Remove(strbldr.Length - 1, 1);
                progressBar1.Value = 0;
                progressBar1.Maximum = countMax(fbd.SelectedPath);
                

                foreach (String f in Directory.GetFiles(fbd.SelectedPath))
                {
                   // log = log + Environment.NewLine + "Checking file: " + f;

                    bool readFrom = false;
                    string[] fileText = File.ReadAllLines(f);
                    
                    foreach (string l in fileText)
                    {
                        if (readFrom == true)
                        {
                            if (l.Contains("owner"))
                            {

                                //DEBUG
                                    //noSpaces(l);
                                    //MessageBox.Show(noSpaces(l));
                                foreach (string s in strbldr.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
                                {

                                    if (s.Length >= 3 && s.Substring(0, 3) == noSpaces(l).Substring(noSpaces(l).Length - 3, 3))
                                    {
                                        //DEBUG
                                            //MessageBox.Show(s.Substring(0, 3) + " = " +  noSpaces(l).Substring(noSpaces(l).Length - 3, 3), "PASSED");
                                            //log = log + Environment.NewLine + s.Substring(0, 3) + " = " + noSpaces(l).Substring(noSpaces(l).Length - 3, 3) + " PASSED";

                                       if (s.Remove(0,3).Length > 3)
                                        {
                                            RewriteFile(f, fileText, s);
                                            if (log != "")
                                                log = log + Environment.NewLine + f;
                                            else
                                                log = f;
                                        }

                                        /*   if (!File.ReadAllLines("Edited.txt").Any(i => i == f))
                                           {
                                               MessageBox.Show("Edited contains: " + f);

                                               if (log != "")
                                                   log = log + Environment.NewLine + f;
                                               else
                                                   log = f;
                                           }
                                           */
                                    }
                                    else
                                    {
                                        //DEBUG

                                            //MessageBox.Show(s.Substring(0, 3) + " = " + noSpaces(l).Substring(noSpaces(l).Length - 3, 3), "ELSE");
                                            //log = log + Environment.NewLine + s.Substring(0, 3) + " = " + noSpaces(l).Substring(noSpaces(l).Length - 3, 3) + " NOTPASSED";
                                    }
                                }
                            }


                        }

                        if (l.Contains("history={"))
                        {
                            readFrom = true;
                        }
                        progressBar1.Value++;
                    }
                    progressBar1.Value++;
                    fc++;
                }
            }

            states_dir.Enabled = true;
            findTags.Enabled = true;

            debug_output.Text = log + Environment.NewLine + "Total checked files: " + fc.ToString();
            File.WriteAllText("Edited.txt", log); //Записывает в файл обработанные путь к обработанным файлам, дабы не использовать по новой!
        }

        private void RewriteFile(string file, string[] fileText, string tagNreligion)
        {
            List<string> txtPt1 = new List<string>();
            List<string> txtPt2 = new List<string>();

            bool first = true;
            bool startRead = false;
            int flags = 0;


            foreach (string s in fileText)
            {
                if (s.Contains("		set_state_flag"))
                {
                    flags++;
                    //log = log + Environment.NewLine + " [int] flags increased";
                }
            }

            if (flags == 0)
            {
                foreach (string s in fileText)
                {
                    if (s.Contains("owner"))
                    {
                        if (first == true)
                        {
                            txtPt1.Add(s);
                            first = false;
                            break;
                        }

                    }
                    txtPt1.Add(s);
                }

                foreach (string s in fileText)
                {
                    if (startRead == true)
                    {
                        txtPt2.Add(s);
                    }
                    if (s.Contains("owner"))
                    {
                        startRead = true;
                    }
                }

                txtPt1.Add("		set_state_flag = " + tagNreligion.Remove(0, 4));
                txtPt1.AddRange(txtPt2);
            }
            else if (flags > 1)
            {
                foreach (string s in fileText)
                {
                    if (s.Contains("		set_state_flag"))
                    {
                        if (flags == 1)
                        {
                            txtPt1.Add(s);
                        }
                        else
                        {
                            flags--;
                        }

                    }
                    else
                    {
                        txtPt1.Add(s);
                    }

                }

            }
            //MessageBox.Show(string.Join(Environment.NewLine,txtPt1.ToArray()));

            var UTF8NoBom = new UTF8Encoding(false);

            File.Delete(file);
            File.WriteAllLines(file, txtPt1, UTF8NoBom);
        }

        private int countMax(string fileFolder)
        {
            int finishedValue;

            finishedValue = Directory.GetFiles(fbd.SelectedPath).Length;

            foreach (String f in Directory.GetFiles(fbd.SelectedPath))
            {
                finishedValue = finishedValue + File.ReadAllLines(f).Length;
            }
            

                return finishedValue;
        }

        private string noSpaces(string input)
        {

            foreach (char c in input)
            {
                if (c == ' ')
                {
                    input = input.Remove(input.IndexOf(c), 1);
                }
            }

            return input;

        }

        private void debug_button_Click(object sender, EventArgs e)
        {
            if (DebugMode == false)
            {
                DebugMode = true;
                debug_button.BackColor = Color.LimeGreen;
            }
            else
            {
                DebugMode = false;
                debug_button.BackColor = Color.Red;
            }
        }


        private void SaveSession_Click(object sender, EventArgs e)
        {
            Save_Session();
        }

        private void Save_Session()
        {
            StringBuilder strbldr = new StringBuilder();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.FormattedValue.ToString().Length >= 3)
                    {
                        strbldr.Append(cell.Value);
                        strbldr.Append(" - ");
                    }
                    else
                    {
                        strbldr.Append(" ");
                    }
                }

                strbldr.Remove(strbldr.Length - 3, 3);
                strbldr.AppendLine();

            }
            var UTF8NoBom = new UTF8Encoding(false);
            File.WriteAllText("savedsession.txt", strbldr.ToString(), UTF8NoBom);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (autoSave.Checked == true)
            {
                Save_Session();
            }
        }

    }
}

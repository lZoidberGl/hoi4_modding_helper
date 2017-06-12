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

namespace HOI4_Modding_Helper
{
    public partial class GFX_Helper : Form
    {
        public GFX_Helper()
        {
            InitializeComponent();
        }

        ToolTip tp = new ToolTip();

        OpenFileDialog toYML = new OpenFileDialog();
        FolderBrowserDialog toDDS = new FolderBrowserDialog();
        String[] fileArray;
        String[] stringArray;
        String[] splittedPath;
        String pth;

        List<string> nameList = new List<string>();

        private void path_to_yml_Click(object sender, EventArgs e)
        {
            toYML.ShowDialog();
            if (toYML.FileName.ToString() != "")
            {
                path_to_yml_txt.Text = toYML.FileName.ToString();
                path_to_yml.BackColor = Color.LimeGreen;
            }
            else
            {
                path_to_yml_txt.Text = "Путь к yml файлу отсутствует";
                path_to_yml.BackColor = Color.Red;
            }

        }

        private void path_to_dds_folder_Click(object sender, EventArgs e)
        {
            if (path_to_dds_txt.Text == "")
            {
                toDDS.ShowDialog();
                path_to_dds_txt.Text = toDDS.SelectedPath;

                CheckPath();
            }
            else
            {
                try
                {
                    toDDS.SelectedPath = path_to_dds_txt.Text;
                    toDDS.ShowDialog();

                    path_to_dds_txt.Text = toDDS.SelectedPath;

                    CheckPath();
                }
                catch (Exception)
                {
                    MessageBox.Show("неудалось найти путь");
                    toDDS.SelectedPath = "";
                    toDDS.ShowDialog();

                    path_to_dds_txt.Text = toDDS.SelectedPath;

                    CheckPath();
                }

            }


        }

        private void CheckPath()
        {
            if (toDDS.SelectedPath.ToString() != "")
            {
                fileArray = Directory.GetFiles(toDDS.SelectedPath);

                foreach (String f in fileArray)
                {
                    if (f.Contains(".dds"))
                    {
                        path_to_dds_txt.Text = toDDS.SelectedPath.ToString();
                        path_to_dds_folder.BackColor = Color.LimeGreen;

                        break;
                    }
                }

                Array.Clear(fileArray, 0, fileArray.Length);

                //MessageBox.Show(string.Join(Environment.NewLine, fileArray));
            }
            else
            {
                //path_to_dds_folder.Text = "Путь к папке с dds файлами отсутствует";
                path_to_dds_folder.BackColor = Color.Red;
            }
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            if (path_to_dds_txt.Text != "" && path_to_yml_txt.Text != "" && path_to_yml_txt.Text != "Путь к yml файлу отсутствует")
            {
                try
                {
                    stringArray = File.ReadAllLines(path_to_yml_txt.Text);

                    foreach (String s in stringArray)
                    {
                        if (s.Contains(":0"))
                        {
                            if (generated_gfx_text_box.Text == "")
                            {
                                //generated_gfx_text_box.Text = s.Substring(0, s.IndexOf(":"));
                                nameList.Add(s.Substring(0, s.IndexOf(":")));
                            }
                            else
                            {
                                //generated_gfx_text_box.Text = generated_gfx_text_box.Text + Environment.NewLine + s.Substring(0, s.IndexOf(":"));
                                nameList.Add(s.Substring(0, s.IndexOf(":")));
                            }
                        }

                    }

                    fileArray = Directory.GetFiles(path_to_dds_txt.Text);

                    generatePathPart();

                    foreach (String i in nameList.ToArray())
                    {
                        if ((i.Contains("_hog") || i.Contains("_ecm") || i.Contains("_fgm")) && EC2013_check.Checked)
                        {
                            generated_gfx_text_box.Text = generated_gfx_text_box.Text + Environment.NewLine + Environment.NewLine + "	spriteType = {" + Environment.NewLine + "		name = \"GFX_idea_" + i + "\"" + Environment.NewLine + "		texturefile = " + pth  + i.Substring(0,i.Length - 4) + ".dds" + "\"" + Environment.NewLine + "	}";
                        }
                        else if ((i.Contains("_ssch") || i.Contains("_defm")) && EC2013_check.Checked)
                        {
                            generated_gfx_text_box.Text = generated_gfx_text_box.Text + Environment.NewLine + Environment.NewLine + "	spriteType = {" + Environment.NewLine + "		name = \"GFX_idea_" + i + "\"" + Environment.NewLine + "		texturefile = " + pth + i.Substring(0, i.Length - 5) + ".dds" + "\"" + Environment.NewLine + "	}";
                        }
                        else
                        {
                            generated_gfx_text_box.Text = generated_gfx_text_box.Text + Environment.NewLine + Environment.NewLine + "	spriteType = {" + Environment.NewLine + "		name = \"GFX_idea_" + i + "\"" + Environment.NewLine + "		texturefile = " + "\"" + pth + i + ".dds" + "\"" + Environment.NewLine + "	}";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("RAZRAB DEBIL: " + ex.Message);
                }

                Array.Clear(fileArray, 0, fileArray.Length);
                Array.Clear(stringArray, 0, stringArray.Length);
            }
        }

        private void generatePathPart()
        {
            Char[] sep =  "\\".ToCharArray();
            splittedPath = path_to_dds_txt.Text.Split(sep);

            bool usenext = false;

            foreach (String p in splittedPath)
            {
                if (p == "gfx")
                {
                    usenext = true;
                }

                if (usenext == true)
                {
                    pth = pth + p + "/";
                }
            }
        }

        private void path_to_yml_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(path_to_yml_txt.Text) == true && path_to_yml_txt.Text.Contains(".yml"))
                {
                    path_to_yml.BackColor = Color.LimeGreen;
                }
                else
                {
                    path_to_yml.BackColor = Color.Red;
                }
            }
            catch (Exception) { }
        }

        private void path_to_dds_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(path_to_dds_txt.Text) == true)
                {
                    path_to_dds_folder.BackColor = Color.Yellow;                    
                    tp.Show("Путь существует, но не удалось определить его пригодность (нет файлов .dds )", path_to_dds_folder,2000);
                }
                else
                {
                    path_to_dds_folder.BackColor = Color.Red;
                }
            }
            catch (Exception) { }

        }

        private void GFX_Helper_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}

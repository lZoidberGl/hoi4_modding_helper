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
        string[] postFixes = { "_hog" , "_ecm" , "_fgm" , "_ssch" , "_isch", "_defm" , "_chogs" , "_chogf" , "_chognf" , "_chogaf" };

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
                toDDS.SelectedPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Paradox Interactive", "Hearts of Iron IV", "mod" , "ec" , "gfx" , "interface" , "ideas" , "Poland");
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
                int equal = 0;
                int uniq = 0;
                try
                {
                    stringArray = File.ReadAllLines(path_to_yml_txt.Text);

                    foreach (String s in stringArray)
                    {
                        if (s.Contains(":0"))
                        {

                            nameList.Add(nospaces(s.Substring(0,s.IndexOf(":"))));
                            // else
                            // {
                            //generated_gfx_text_box.Text = generated_gfx_text_box.Text + Environment.NewLine + s.Substring(0, s.IndexOf(":"));
                            //     nameList.Add(s.Substring(0, s.IndexOf(":")));
                            // }
                        }

                    }

                    fileArray = Directory.GetFiles(path_to_dds_txt.Text);

                    generatePathPart();



                    string usednames = "";

                    foreach (String i in nameList.ToArray())
                    {
                        if ((i.Contains("_hog") || i.Contains("_ecm") || i.Contains("_fgm")) && EC2013_check.Checked && !usednames.Contains(i.Substring(0, i.Length - 4)))
                        {
                            generated_gfx_text_box.Text = generated_gfx_text_box.Text + Environment.NewLine + Environment.NewLine + "	spriteType = {" + Environment.NewLine + "		name = \"GFX_idea_" + i.Substring(0, i.Length - 4) + "\"" + Environment.NewLine + "		texturefile = " + "\"" + pth  + i.Substring(0,i.Length - 4) + ".dds" + "\"" + Environment.NewLine + "	}";
                            usednames = usednames + " " + i.Substring(0, i.Length - 4);
                            uniq++;
                        }
                        else if ((i.Contains("_ssch") || i.Contains("_defm") || i.Contains("_isch")) && EC2013_check.Checked && !usednames.Contains(i.Substring(0, i.Length - 5)))
                        {
                            generated_gfx_text_box.Text = generated_gfx_text_box.Text + Environment.NewLine + Environment.NewLine + "	spriteType = {" + Environment.NewLine + "		name = \"GFX_idea_" + i.Substring(0, i.Length - 5) + "\"" + Environment.NewLine + "		texturefile = " + "\"" + pth + i.Substring(0, i.Length - 5) + ".dds" + "\"" + Environment.NewLine + "	}";
                            usednames = usednames + " " + i.Substring(0, i.Length - 5);
                            uniq++;
                        }
                        else if ((i.Contains("_chogs") || i.Contains("_chogf")) && EC2013_check.Checked && !usednames.Contains(i.Substring(0, i.Length - 6)))
                        {
                            generated_gfx_text_box.Text = generated_gfx_text_box.Text + Environment.NewLine + Environment.NewLine + "	spriteType = {" + Environment.NewLine + "		name = \"GFX_idea_" + i.Substring(0, i.Length - 6) + "\"" + Environment.NewLine + "		texturefile = " + "\"" + pth + i.Substring(0, i.Length - 6) + ".dds" + "\"" + Environment.NewLine + "	}";
                            usednames = usednames + " " + i.Substring(0, i.Length - 7);
                            uniq++;
                        }
                        else if ((i.Contains("_chognf") || i.Contains("_chogaf")) && EC2013_check.Checked && !usednames.Contains(i.Substring(0, i.Length - 7)))
                        {
                            generated_gfx_text_box.Text = generated_gfx_text_box.Text + Environment.NewLine + Environment.NewLine + "	spriteType = {" + Environment.NewLine + "		name = \"GFX_idea_" + i.Substring(0, i.Length - 7) + "\"" + Environment.NewLine + "		texturefile = " + "\"" + pth + i.Substring(0, i.Length - 7) + ".dds" + "\"" + Environment.NewLine + "	}";
                            usednames = usednames + " " + i.Substring(0, i.Length - 7);
                            uniq++;
                        }
                        else if(!usednames.Contains(i) && !postFixes.Any(i.Contains))
                        {
                            generated_gfx_text_box.Text = generated_gfx_text_box.Text + Environment.NewLine + Environment.NewLine + "	spriteType = {" + Environment.NewLine + "		name = \"GFX_idea_" + i + "\"" + Environment.NewLine + "		texturefile = " + "\"" + pth + i + ".dds" + "\"" + Environment.NewLine + "	}";
                            usednames = usednames + " " + i;
                            uniq++;
                        }
                        else if (usednames.Contains(i.Substring(0, i.Length - 4)) || usednames.Contains(i.Substring(0, i.Length - 5)) || usednames.Contains(i.Substring(0, i.Length - 6)) || usednames.Contains(i.Substring(0, i.Length - 7)) || usednames.Contains(i))
                        {
                            equal++;
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("RAZRAB DEBIL: " + ex.Message);
                }

                Array.Clear(fileArray, 0, fileArray.Length);
                Array.Clear(stringArray, 0, stringArray.Length);
                equalcount.Text = "Одинаковые: " +  equal.ToString() + " Уникальные:" + uniq.ToString();
            }
        }

        public string nospaces(string text)
        {
            foreach(char c in text)
            {
                if (c == ' ')
                {
                    text = text.Remove(text.IndexOf(c), 1);
                }
            }

            return text;
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
                    if (Directory.GetFiles(path_to_dds_txt.Text).Any(s => s.Contains(".dds")))
                    {
                        tp.Show("Удалось обнаружить файлы .dds -- путь правильный", path_to_dds_folder, 4000);
                        compare_to_dds.Show();
                    }
                    else
                    {
                        tp.Show("Путь существует, но не удалось определить его пригодность (нет файлов .dds )", path_to_dds_folder, 4000);
                        compare_to_dds.Hide();
                    }

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

        private void compare_to_dds_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFileSystemEntries(path_to_dds_txt.Text);
            string[] namas = nameList.ToArray();
           //string check = "";
            int number = 0;
            List<string> check = new List<string>();
            List<string> uncheck = new List<string>();


            foreach (string file in files )
            {
                string filename = Path.GetFileName(file);

                if (namas.Any(filename.Substring(0, filename.Length - 4).Equals))
                {
                    check.Add(Path.GetFileName(file)); 
                    number++;
                }
            }

            MessageBox.Show(string.Join(Environment.NewLine, check), number.ToString());
            number = 0;
           foreach(string file in files)
           {
                string filename = Path.GetFileName(file);
                if (!check.Any(filename.Equals))
                {
                    uncheck.Add(filename);
                    number++;
                }
           }

            MessageBox.Show(string.Join(Environment.NewLine, uncheck) , number.ToString());

        }

    }
}

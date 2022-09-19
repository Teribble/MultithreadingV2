using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Module_03
{
    public partial class Task_5 : Form
    {
        private List<string> _files;

        private int counterFile;

        private string _result;

        public Task_5()
        {
            InitializeComponent();

            _files = new List<string>();

            counterFile = 0;

            _result = string.Empty;
        }

        private void OnTextChangedPathBox(object sender, EventArgs e)
        {
            if (Directory.Exists(pathBox.Text))
            {
                trueLabel.Visible = true;

                falseLabel.Visible = false;
            }
            else
            {
                trueLabel.Visible = false;

                falseLabel.Visible = true;
            }
        }

        private void OnButton1Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<string> GetRecursFiles(string start_path)
        {
            List<string> ls = new List<string>();
            try
            {
                string[] folders = Directory.GetDirectories(start_path);

                foreach (string folder in folders)
                {
                    ls.AddRange(GetRecursFiles(folder));
                }
                string[] files = Directory.GetFiles(start_path);

                foreach (string filename in files)
                {
                    if (filename.Contains(".txt"))
                        ls.Add(filename);
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ls;
        }


        private void OnButton2Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                _files = GetRecursFiles(pathBox.Text);

                fileLabel.Invoke(() =>
                {
                    fileLabel.Text = $"По вашей ссылке найдено {_files.Count().ToString()} файлов";
                });

                button3.Invoke(() =>
                {
                    button3.Enabled = true;
                });
            });
        }

        private void OnButton3Click(object sender, EventArgs e)
        {
            counterFile = 0;

            Task.Run(() =>
            {
                _files.ForEach(n =>
                {
                    using (StreamReader reader = new StreamReader(n))
                    {
                        string line = reader.ReadToEnd();

                        SearchText(line, textBox2.Text);
                    }
                });
            });

            button3.Enabled = false;
        }

        private void SearchText(string text, string str)
        {
            text = text.ToString().ToLower();

            str = str.ToLower();

            bool flag = false;

            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == str[0])
                {
                    counter = 0;

                    for (int j = 0; j < str.Length && i + j < text.Length; j++)
                    {
                        if (text[i + j] == str[j])
                        {
                            counter++;
                        }
                    }

                    if (counter == str.Length)
                    {
                        counterFile++;

                        Task.Run(new Action(() =>
                        {
                            stringLabel.Invoke(() =>
                            {
                                stringLabel.Text = counterFile.ToString();
                            });
                        }));
                    }
                }
            }
        }
    }
}

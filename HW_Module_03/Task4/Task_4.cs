using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Module_03
{
    public partial class Task_4 : Form
    {

        private string _result;

        private int _counter;

        public Task_4()
        {
            InitializeComponent();

            _result = string.Empty;

            _counter = 0;
        }

        private void OnTextChangeTextBox2(object sender, EventArgs e)
        {
            if (File.Exists(textBox2.Text))
            {
                label3.Visible = true;
                label4.Visible = false;
            }
            else
            {
                label3.Visible = false;
                label4.Visible = true;
            }
        }

        private void OnButton1Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnVisibleChangedLabe3(object sender, EventArgs e)
        {
            if (label3.Visible == true)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private async Task ReadCharacters()
        {
            using (StreamReader reader = File.OpenText(textBox2.Text))
            {
                _result = await reader.ReadToEndAsync();
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await ReadCharacters();

            SearchText(textBox1.Text);
        }

        private void SearchText(string str)
        {
            _result = _result.ToString().ToLower();

            str = str.ToLower();

            bool flag = false;

            int counter = 0;

            for (int i = 0; i < _result.Length; i++)
            {
                if (_result[i] == str[0])
                {
                    counter = 0;

                    for (int j = 0; j < str.Length; j++)
                    {
                        if (_result[i+j] == str[j])
                        {
                            counter++;
                        }
                    }

                    if (counter == str.Length)
                    {
                        _counter++;

                        Task.Run(new Action(() =>
                        {
                            label6.Invoke(() =>
                            {
                                label6.Text = _counter.ToString();
                            });
                        }));
                    }
                }
            }
        }
    }
}

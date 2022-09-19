using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Module_03
{
    public partial class Task_3 : Form
    {
        private bool flag;

        public Task_3()
        {
            InitializeComponent();

            flag = false;
        }

        private void OnButton1Click(object sender, EventArgs e)
        {
            flag = false;

            this.Close();
        }

        private void Fib()
        {
            flag = true;

            if (Int32.TryParse(textBox1.Text, out int max)) { }
            else max = int.MaxValue;

            int j = 1;

            for (int i = 1; i <= max && flag == true; i += j)
            {
                label2.Invoke(new Action(() => label2.Text = i.ToString()));

                j = i - j;

                Thread.Sleep(200);
            }
        }

        private void OnTextChangeTextBox1(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox1.Text, out int max))
                label1.Visible = false;
            else label1.Visible = true;
        }
        
        private async Task FibAsync()
        {
            await Task.Run(() => Fib());
        }

        private async void OnButton2Click(object sender, EventArgs e)
        {
            await FibAsync();
        }
    }
}

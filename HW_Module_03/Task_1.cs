using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Module_03
{
    public partial class Task_1 : Form
    {
        private List<ProgressBar>? _progressBarsList;

        private List<Task>? _tasks;

        private bool _flag;

        public Task_1()
        {
            InitializeComponent();

            label3.Text = trackBar1.Value.ToString();

            Initial();
        }

        private void Initial()
        {
            _progressBarsList = new List<ProgressBar>();

            _tasks = new List<Task>();

            _flag = true;

            foreach (var control in this.Controls)
            {
                if (control is ProgressBar)
                {
                    _progressBarsList.Add((ProgressBar)control);
                }
            }
        }

        private void OnButton1Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnScrollTrackBar1(object sender, EventArgs e)
        {
            label3.Text = trackBar1.Value.ToString();

            for (int i = 0; i < _progressBarsList?.Count; i++)
            {
                _progressBarsList[i].Visible = false;
            }

            for (int i = 0; i < trackBar1.Value; i++)
            {
                if (_progressBarsList?.Count > 0)
                {
                    _progressBarsList[i].Visible = true;
                }
            }
        }

        private void OnButton9Click(object sender, EventArgs e)
        {

            this._flag = true;

            button1.Enabled = false;

            label4.Visible = true;

            _progressBarsList?.Where(n => n.Visible == true).ToList().ForEach(n =>
            {
                n.Value = 0;

                _tasks?.Add(Task.Run(new Action(() =>
                {
                    for (int i = 0; i < 100 && this._flag == true; i++)
                    {
                        Thread.Sleep(new Random().Next(100, 1000));
                        n.Invoke(new Action(() => n.Value += 1));
                    }
                })));
            });

        }

        private void OnButton10Click(object sender, EventArgs e)
        {
            this._flag = false;

            Task.Run(() =>
            {
                Thread.Sleep(2000);

                button1.Invoke(new Action(() =>
                {
                    button1.Enabled = true;

                    _tasks?.Clear();
                }));
            });
        }
    }
}

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
    public partial class Task2 : Form
    {
        private List<ProgressBar> _progressBars;

        private List<Task> _tasks;

        private bool flag;

        private int place;

        #region ROFL
        private List<int> _bufferProgressBar1;

        private List<int> _bufferProgressBar2;

        private List<int> _bufferProgressBar3;

        private List<int> _bufferProgressBar4;

        private List<int> _bufferProgressBar5;
        #endregion


        public Task2()
        {
            InitializeComponent();

            _progressBars = new List<ProgressBar>();

            _tasks = new List<Task>();

            // Флаг - условие для остановки потоков, пока что ничего умнее не придумал
            flag = true;

            place = 1;

            Initital();

            #region ROLF INITITAL
            _bufferProgressBar1 = new List<int>();

            _bufferProgressBar2 = new List<int>();

            _bufferProgressBar3 = new List<int>();

            _bufferProgressBar4 = new List<int>();

            _bufferProgressBar5 = new List<int>();
            #endregion
        }

        private void OnButtonClick3(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnButtonClick1(object sender, EventArgs e)
        {
            label12.Visible = true;

            place = 1;

            button3.Enabled = false;

            flag = true;

            int bufferIndex = 0;

            _progressBars.ForEach(n =>
            {
                _tasks.Add(Task.Run(new Action(() =>
                {
                    for (int i = 0; i <= 100 && flag == true; i++)
                    {
                        if (i == 100 && place == 1)
                            listBox1.Invoke(() => listBox1.Items.Add($"{place++} место: {n.Name} Средняя скорость: {_bufferProgressBar1.Average()} Максимальная скорость: {_bufferProgressBar1.Max()}"));
                        else if (i == 100 && place == 2)
                            listBox1.Invoke(() => listBox1.Items.Add($"{place++} место: {n.Name} Средняя скорость: {_bufferProgressBar2.Average()} Максимальная скорость: {_bufferProgressBar2.Max()}"));
                        else if (i == 100 && place == 3)
                            listBox1.Invoke(() => listBox1.Items.Add($"{place++} место: {n.Name} Средняя скорость: {_bufferProgressBar3.Average()} Максимальная скорость: {_bufferProgressBar3.Max()}"));
                        else if (i == 100 && place == 4)
                            listBox1.Invoke(() => listBox1.Items.Add($"{place++} место: {n.Name} Средняя скорость: {_bufferProgressBar4.Average()} Максимальная скорость: {_bufferProgressBar4.Max()}"));
                        else if (i == 100 && place == 5)
                            listBox1.Invoke(() => listBox1.Items.Add($"{place++} место: {n.Name} Средняя скорость: {_bufferProgressBar5.Average()} Максимальная скорость: {_bufferProgressBar5.Max()}"));


                        int value = new Random().Next(10, 300);

                        if (bufferIndex == 0)
                        {
                            label7.Invoke(() => label7.Text = (value % 100).ToString() + "км/ч");

                            _bufferProgressBar1.Add(value % 100);
                        }
                        else if (bufferIndex == 1)
                        {
                            label8.Invoke(() => label8.Text = (value % 100).ToString() + "км/ч");

                            _bufferProgressBar2.Add(value % 100);
                        }
                        else if (bufferIndex == 2)
                        {
                            label9.Invoke(() => label9.Text = (value % 100).ToString() + "км/ч");

                            _bufferProgressBar3.Add(value % 100);
                        }
                        else if (bufferIndex == 3)
                        {
                            label10.Invoke(() => label10.Text = (value % 100).ToString() + "км/ч");

                            _bufferProgressBar4.Add(value % 100);
                        }
                        else if (bufferIndex == 4)
                        {
                            label11.Invoke(() => label11.Text = (value % 100).ToString() + "км/ч");

                            _bufferProgressBar5.Add(value % 100);
                        }

                        Thread.Sleep(value);

                        n.Invoke(() => n.Increment(1));

                        bufferIndex++;

                        if (bufferIndex == 5)
                            bufferIndex = 0;
                    }
                })));
            });

            if (place == 5)
            {
                OnButton2Click(null, null);
            }
        }

        private void Initital()
        {
            //Бля, ну это сильно сильно
            /// Я конечно мог по отдельности пристовить имена для каждого прогресс бара
            /// и далее пройтись через цикл по контролам группы, если это progressBar то добавь в список
            /// Но почему-то решил так
            _progressBars.Add(progressBar1);
            _progressBars.Add(progressBar2);
            _progressBars.Add(progressBar3);
            _progressBars.Add(progressBar4);
            _progressBars.Add(progressBar5);
        }

        private void OnButton2Click(object sender, EventArgs e)
        {
            flag = false;

            Task.Run(() =>
            {
                Thread.Sleep(2000);

                button3.Invoke(() => button3.Enabled = true);
            });

            label12.Visible = false;
        }
    }
}

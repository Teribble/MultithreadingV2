namespace HW_Module_03
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnButton1Click(object sender, EventArgs e)
        {
            Task_1 windows = new Task_1();

            windows.Show();
        }

        private void OnClickButton2(object sender, EventArgs e)
        {
            Task_2 windows = new Task_2();

            windows.Show();
        }

        private void OnButton3Click(object sender, EventArgs e)
        {
            Task_3 windows = new Task_3();

            windows.Show();
        }

        private void OnButton4Click(object sender, EventArgs e)
        {
            Task_4 windows = new Task_4();

            windows.Show();
        }

        private void OnButton5Click(object sender, EventArgs e)
        {
            Task_5 windows = new Task_5();

            windows.Show();
        }
    }
}
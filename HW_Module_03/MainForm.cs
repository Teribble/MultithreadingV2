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
            Task2 windows = new Task2();

            windows.Show();
        }
    }
}
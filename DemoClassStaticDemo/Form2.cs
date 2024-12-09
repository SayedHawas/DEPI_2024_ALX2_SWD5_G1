namespace DemoClassStaticDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HelperStatic.CleanForm(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
        }
    }
}

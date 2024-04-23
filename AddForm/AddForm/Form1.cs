namespace AddForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text); 
            int num2 = Convert.ToInt32(textBox2.Text);
            int sum = num1 + num2;
            textBox3.Text = sum.ToString();
        }
    }
}

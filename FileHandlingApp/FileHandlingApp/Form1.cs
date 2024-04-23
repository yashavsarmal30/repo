namespace FileHandlingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string rtl = richTextBox1.Text;
            FileStream fo = new FileStream("e:\\fileform.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fo);
            Console.WriteLine("Enter the string. null for termination");

            while (true)
            {
                rtl = Console.ReadLine();
                if (string.IsNullOrEmpty(rtl))
                    break;
                sw.WriteLine(rtl);
            }
            sw.Flush();
            fo.Close();
        }
    }
}

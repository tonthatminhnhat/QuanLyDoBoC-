namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            var str = $"Xin chao ban: {name}";
            MessageBox.Show(str);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a=  int.Parse(textBox2.Text);
                 var b = int.Parse(textBox3.Text);
            var c = a + b;
            var str = $"{a}+{b}={c}";
            MessageBox.Show(str);
        }
    }
}
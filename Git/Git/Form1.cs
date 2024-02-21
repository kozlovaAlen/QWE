namespace Git
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textToDisplay = textBox1.Text;

            Form newForm = new Form();
            TextBox textBox = new TextBox();
            textBox.Text = textToDisplay;
            textBox.Dock = DockStyle.Fill;
            newForm.Controls.Add(textBox);
            newForm.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
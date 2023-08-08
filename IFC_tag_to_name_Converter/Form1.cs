namespace IFC_tag_to_name_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void brouse_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path_textBox.Text = openFileDialog1.FileName;
            }
        }

        private void convert_button_Click(object sender, EventArgs e)
        {
            if (IFCConverter.PutTagInIFCName(path_textBox.Text) == true)
            {
                MessageBox.Show($"File {path_textBox.Text} converted.");
            }
            else
            {
                MessageBox.Show($"Error, conversion failed!");
            }
        }
    }
}
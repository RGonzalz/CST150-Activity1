namespace CST150_Activity1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Hello_Click(object sender, EventArgs e)
        {
            lbl_info.Text = "Hello World";
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            lbl_info.Text = "My name is Roberto GonzalezRamirez";
        }

        private void btn_instructions_Click(object sender, EventArgs e)
        {
            lbl_info.Text = "Please chack all that apply below. Thank you.";
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            lbl_info.Text = "...";
            MessageBox.Show("Good Bye!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
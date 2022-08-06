namespace pharmacy_manegment_practice
{
    public partial class Form1 : Form
    {
        public object MessageBoxIcons { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(txtusername.Text=="btechdays"  &&  txtpassword.Text=="pass")
            {
                Administrator am = new Administrator();
                am.Show();
                this.Hide();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Wrong  Username OR Password " ,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
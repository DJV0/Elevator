namespace Elevator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(label1);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
        }
    }
}
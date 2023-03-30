namespace Elevator
{
    public partial class Form1 : Form
    {
        int level;
        int maxLevel;

        public Form1()
        {
            InitializeComponent();
            maxLevel = tableLayoutPanel1.RowCount;
            level = 1;
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (level > 1)
            {
                tableLayoutPanel1.Controls.Remove(label1);
                level--;
                tableLayoutPanel1.Controls.Add(label1, 0, Math.Abs(level - maxLevel));
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (level < maxLevel)
            {
                tableLayoutPanel1.Controls.Remove(label1);
                level++;
                tableLayoutPanel1.Controls.Add(label1, 0, Math.Abs(level - maxLevel));
            }
        }
    }
}
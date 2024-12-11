namespace FormCseresznye
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlLoad usercontrol = new UserControlLoad();
            panel1.Controls.Add(usercontrol);
            usercontrol.Dock = DockStyle.Fill;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlDelete usercontrol = new UserControlDelete();
            panel1.Controls.Add(usercontrol);
            usercontrol.Dock = DockStyle.Fill;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlAdd usercontrol = new UserControlAdd();
            panel1.Controls.Add(usercontrol);
            usercontrol.Dock = DockStyle.Fill;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Biztosan be szeretnéd zárni az ablakot?",
                "Bezárás megerõsítése",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
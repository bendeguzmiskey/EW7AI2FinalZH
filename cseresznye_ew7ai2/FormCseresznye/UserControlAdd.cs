using FormCseresznye.F1Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCseresznye
{
    public partial class UserControlAdd : UserControl
    {
        Forma1Context context = new Forma1Context();

        public UserControlAdd()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("A csapatnév mező kitöltése kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Csapat r = new Csapat();
            r.Nev = textBox1.Text;
            int m;
            if (!int.TryParse(textBox2.Text, out m)) return;
            r.AlapitasiEv = m;
            r.Szponzor = textBox3.Text;
            context.Csapat.Add(r);
            context.SaveChanges();
            MessageBox.Show("Adatok mentve!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

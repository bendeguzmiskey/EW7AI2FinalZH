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
    public partial class UserControlLoad : UserControl
    {
        Forma1Context context = new Forma1Context();
        public UserControlLoad()
        {
            InitializeComponent();
        }

        private void UserControlLoad_Load(object sender, EventArgs e)
        {
            Listazas();
        }

        private void Listazas()
        {
            bindingSource1.DataSource = (from x in context.Pilota
                                         where x.Nev.Contains(textBox1.Text)
                                         select x).ToList();
            listBox1.DataSource = bindingSource1;
            listBox1.DisplayMember = "Nev";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Listazas();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            VersenyListazas();
        }

        private void VersenyListazas()
        {
            if (bindingSource1.Current != null)
            {
                var id = ((Pilota)bindingSource1.Current).PilotaId;

                var versenyek = from x in context.Eredmeny
                                where id == x.PilotaId
                                select new Verseny
                                {
                                    PilotaNev = x.Pilota.Nev,
                                    CsapatId = x.CsapatId,
                                    Szponzor = x.Csapat.Szponzor,
                                    Nemzetiseg = x.Pilota.Nemzetiseg
                                };
                versenyBindingSource.DataSource = versenyek.ToList();
            }
        }


    }
    public class Verseny
    {
        public string PilotaNev { get; set; }
        public int? CsapatId { get; set; }

        public string Szponzor { get; set; }

        public string Nemzetiseg { get; set; }

    }
}

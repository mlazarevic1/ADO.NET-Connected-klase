using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugiDeoProjekta
{
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            clsCRUD cc = new clsCRUD();

            int Ret = cc.klijent_Insert(txtNaziv.Text, txtKontakt.Text, txtGrad.Text, txtZemlja.Text);

            MessageBox.Show(Ret.ToString());
            
            if(Ret == 0)
            {
                MessageBox.Show("Uspesno ste dodali korisnika. Refresujte bazu na dugme da bi ste videli rezultat", "Unos");

            }




        }
    }
}

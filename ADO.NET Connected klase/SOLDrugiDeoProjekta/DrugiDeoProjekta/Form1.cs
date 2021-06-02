using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace DrugiDeoProjekta
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clsCRUD cc = new clsCRUD();
            cc.refreshKlijent(dgKlijenti);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var insert = new Insert();
            insert.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int sel = (int)dgKlijenti.SelectedRows[0].Cells[0].Value;
            var update = new UpdateForm(sel);
            update.ShowDialog();
        }

        


        private void btnDelete_Click(object sender, EventArgs e)
        {

            clsCRUD cc = new clsCRUD();
            int sel = (int)dgKlijenti.SelectedRows[0].Cells[0].Value;
            if (MessageBox.Show("Da li ste sigruni da zelite da obrisete klijenta iz tabele sa id-em:" + sel.ToString(),"Brisanje reda", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                int ret = cc.Klient_Delete(sel);
                MessageBox.Show(ret.ToString());
            }
            else
            {
                MessageBox.Show("Red nije izbrisan", "Brisanje reda", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clsCRUD cc = new clsCRUD();
            cc.refreshKlijent(dgKlijenti);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

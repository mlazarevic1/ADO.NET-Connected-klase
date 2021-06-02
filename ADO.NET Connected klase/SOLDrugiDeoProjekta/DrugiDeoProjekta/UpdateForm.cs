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
    public partial class UpdateForm : Form
    {
        

        public UpdateForm(int sel)
        {
            InitializeComponent();

            txtKlijentID.Text = Convert.ToString(sel);
            this.value = sel.ToString();
            txtKlijentID.Enabled = false;
            
        }

        public string value { get; set; }

        public void btnUpdate_Click(object sender, EventArgs e)
        {
            clsCRUD cc = new clsCRUD();

            txtKlijentID.Text = value;
            int Ret = cc.updateKlijent(Convert.ToInt32(value),txtNaziv.Text, txtKontakt.Text, txtGrad.Text, txtZemlja.Text);

            MessageBox.Show(Ret.ToString());

            if (Ret == 0)
            {
                MessageBox.Show("Uspesno ste izmenili podatke o korisniku", "Unos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            string connection = System.Configuration.ConfigurationManager.ConnectionStrings["test"].ConnectionString;
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = connection;

            SqlCommand cm = new SqlCommand();

            cm.Connection = cn;

            cm.CommandType = CommandType.StoredProcedure;

            cm.CommandText = "Dbo.PrikazKlijentTxt";

            //parametri
            cm.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Current, null));

            cm.Parameters.AddWithValue("@klijentid", this.value);

            cm.Parameters.Add(new SqlParameter("@naziv", SqlDbType.NVarChar, 40, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Current, ""));

            cm.Parameters.Add(new SqlParameter("@kontakt", SqlDbType.NVarChar, 30, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Current, ""));

            cm.Parameters.Add(new SqlParameter("@grad", SqlDbType.NVarChar, 15, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Current, ""));

            cm.Parameters.Add(new SqlParameter("@zemlja", SqlDbType.NVarChar, 15, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Current, ""));
            try
            {
                if (cn.State == ConnectionState.Closed) cn.Open();
                cm.ExecuteNonQuery();
                txtNaziv.Text = cm.Parameters["@naziv"].Value.ToString();
                txtKontakt.Text = cm.Parameters["@kontakt"].Value.ToString();
                txtGrad.Text = cm.Parameters["@grad"].Value.ToString();
                txtZemlja.Text = cm.Parameters["@zemlja"].Value.ToString();
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

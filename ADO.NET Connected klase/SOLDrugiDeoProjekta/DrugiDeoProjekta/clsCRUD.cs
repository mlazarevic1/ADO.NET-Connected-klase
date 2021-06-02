using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DrugiDeoProjekta
{
    public class clsCRUD
    {
        string connection = System.Configuration.ConfigurationManager.ConnectionStrings["test"].ConnectionString;

        //Insert klijenta
        public int klijent_Insert(string naziv, string kontakt, string grad, string zemlja)
        {
            int RetValue = 0; //Povratna vrednost store procedure

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = connection;

            SqlCommand cm = new SqlCommand();

            cm.Connection = cn;
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "Dbo.KlijentInsert";

            //Parametri za insert
           if(!(naziv.Trim() == "" || kontakt.Trim() == "" || grad.Trim() == "" || zemlja.Trim() == ""))
            {

                cm.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Current, null));
                cm.Parameters.Add(new SqlParameter("@naziv", SqlDbType.NVarChar, 40, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, naziv));
                cm.Parameters.Add(new SqlParameter("@kontakt", SqlDbType.NVarChar, 30, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, kontakt));
                cm.Parameters.Add(new SqlParameter("@grad", SqlDbType.NVarChar, 15, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, grad));
                cm.Parameters.Add(new SqlParameter("@zemlja", SqlDbType.NVarChar, 15, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, zemlja));

                try
                {
                    if (cn.State == ConnectionState.Closed) cn.Open();

                    cm.ExecuteNonQuery();

                    RetValue = (int)cm.Parameters["@RETURN_VALUE"].Value; 
                    cn.Close();

                    return RetValue;

                }
                catch
                {
                    return -10;
                }
            }
            else
            {
                return -25;
            }



        }

        //Brisanje klijenta
        public int Klient_Delete(int id)
        {

            int RetValue = 0; //Povratna vrednost store procedure

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = connection;

            SqlCommand cm = new SqlCommand();

            cm.Connection = cn;
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "Dbo.KlijentDelete";
            cm.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Current, null));//bice 0 ako je sve ako nije onda je(onaj return iz sp)

            cm.Parameters.Add(new SqlParameter("@klijentid", SqlDbType.NVarChar, 40, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, id));


            try
            {
                if (cn.State == ConnectionState.Closed) cn.Open();
                //RetValue = (int)cm.Parameters["@RETURN_VALUE"].Value;
                cm.ExecuteNonQuery();
                cn.Close();

                return RetValue;

            }
            catch 
            {
                return -11;
            }

        }

        //Klijent update f-ja

        public int updateKlijent(int id, string naziv, string kontakt, string grad, string zemlja)
        {
            int RetValue = 0; 

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = connection;

            SqlCommand cm = new SqlCommand();

            cm.Connection = cn;
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "dbo.KlijentUpdate";

            //Parametri za update

            cm.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Current, null));
            cm.Parameters.Add(new SqlParameter("@klijentid", SqlDbType.NVarChar, 40, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, id));
            cm.Parameters.Add(new SqlParameter("@naziv", SqlDbType.NVarChar, 40, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, naziv));
            cm.Parameters.Add(new SqlParameter("@kontakt", SqlDbType.NVarChar, 30, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, kontakt));
            cm.Parameters.Add(new SqlParameter("@grad", SqlDbType.NVarChar, 15, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, grad));
            cm.Parameters.Add(new SqlParameter("@zemlja", SqlDbType.NVarChar, 15, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, zemlja));
            try
            {
                if (cn.State == ConnectionState.Closed) cn.Open();

                cm.ExecuteNonQuery();

                RetValue = (int)cm.Parameters["@RETURN_VALUE"].Value;
                cn.Close();

                return RetValue;

            }
            catch
            {
                return -10;
            }


        }



        //Rafresh klijenta TODO
        public void refreshKlijent(System.Windows.Forms.DataGridView dg)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = connection;

            SqlCommand cm = new SqlCommand();

            cm.Connection = cn;
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "dbo.SviKlijenti";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;

            DataSet ds = new DataSet();

            da.Fill(ds);

            dg.DataSource = ds.Tables[0];
           

        }

      


    }
}

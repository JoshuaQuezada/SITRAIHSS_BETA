using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SITRAIHSS_BETA.Class
{
    public class Cls_Utilitarios
    {
        SqlConnection con = new SqlConnection();
        Cls_Connection DB = new Cls_Connection();

        public DataSet ObtenerConexion(string squery, string Table)
        {
            con = DB.ObtenerConexion();
            DataSet dsObtenerDataSet = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(squery, con);

            dataAdapter.Fill(dsObtenerDataSet, Table);
            con.Close();

            return dsObtenerDataSet;
        }
    }
}
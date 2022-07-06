using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SITRAIHSS_BETA.Class
{
    public class Cls_Connection
    {
        SITRAIHSSEntities SE = new SITRAIHSSEntities();
        SqlConnection Conexionsql = new SqlConnection();

        public SqlConnection ObtenerConexion()
        {
            string sConexion = ConfigurationManager.ConnectionStrings["SITRAIHSSEntities"].ToString();
            string sprovider = new EntityConnectionStringBuilder(sConexion).ProviderConnectionString;
            SqlConnection Conexion = new SqlConnection(sprovider);

            return Conexion;

        }
    }
}
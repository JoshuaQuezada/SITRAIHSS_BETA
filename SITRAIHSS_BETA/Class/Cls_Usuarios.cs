using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SITRAIHSS_BETA.Class
{
    public class Cls_Usuarios
    {
        SITRAIHSSEntities SE = new SITRAIHSSEntities();
        tbUser Usuario = new tbUser();

        public void InsertarNuevoRegistro(string sUsuario, string sContraseña)
        {
             string sUsuarioCrea = HttpContext.Current.Session["username"].ToString();
             SE.INSERT_MANT_tbUser(sUsuario, sContraseña, true, sUsuarioCrea, DateTime.Now);
        }
        public void ActualizarRegistrousuario(string sUsuario, string sContraseña)
        {
            try
            {
                string sUsuarioModifica = HttpContext.Current.Session["username"].ToString();
                int iId_Usuario = Convert.ToInt16(HttpContext.Current.Session["Codigo_usuario"].ToString());
                SE.PA_EDIT_USER(iId_Usuario,sUsuario, sContraseña, sUsuarioModifica, DateTime.Now);
            }
            catch (Exception ex)
            {
                string msj = ex.Message;
            }
        }
    }
}
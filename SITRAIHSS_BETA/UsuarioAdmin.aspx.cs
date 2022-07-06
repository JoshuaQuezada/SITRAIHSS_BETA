using SITRAIHSS_BETA.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SITRAIHSS_BETA
{
    public partial class UsuarioAdmin : System.Web.UI.Page
    {
        Cls_Utilitarios util = new Cls_Utilitarios();
        int Iid_usuario = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Codigo_usuario"] != null)
                {
                    btnEditar.Visible = true;
                    btnGuardar.Visible = false;

                    Iid_usuario = Convert.ToInt16(Session["Codigo_Usuario"].ToString());

                    DataSet ds = new DataSet();
                    ds = util.ObtenerConexion("SELECT Usu_UserName, Usu_Password FROM MANT.tbUser WHERE Usu_Id = " + Iid_usuario + "", "T");
                    txtNombreUsuario.Value = ds.Tables["T"].Rows[0]["Usu_UserName"].ToString();
                    txtContraseña.Value = ds.Tables["T"].Rows[0]["Usu_Password"].ToString();
                }
                else
                {
                    btnEditar.Visible = false;
                    btnGuardar.Visible = true;
                }
            }   
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
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
    public partial class Login : System.Web.UI.Page
    {
        Cls_Utilitarios util = new Cls_Utilitarios();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string Susername = txtUsername.Value;
            string Spassword = txtPassword.Value;
            ds = util.ObtenerConexion("SELECT COUNT(*) AS DATO FROM MANT.tbUser WHERE Usu_UserName = '"+ Susername +"' AND Usu_Password = '"+ Spassword +"'", "T");
            string Sconteo  = ds.Tables["T"].Rows[0]["DATO"].ToString();
            if (Susername.Contains("'") && Spassword.Contains("'") || Susername.Contains("or") && Spassword.Contains("or") || Susername.Contains("OR") && Spassword.Contains("OR"))
            {
                Error.Visible = true;
            }
            else if (Sconteo == "0")
            {
                Error.Visible = true;
                Response.Redirect("Login.aspx");
            }
            else
            {
                Error.Visible = false;
                ds = util.ObtenerConexion("SELECT Usu_UserName AS USERNAME FROM MANT.tbUser", "NOMBRE");
                Session["username"] = ds.Tables["NOMBRE"].Rows[0]["USERNAME"].ToString();
            }
            Response.Redirect("Index.aspx");
        }
    }
}
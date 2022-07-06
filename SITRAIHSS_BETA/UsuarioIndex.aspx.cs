using SITRAIHSS_BETA.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SITRAIHSS_BETA
{
    public partial class UsuarioIndex : System.Web.UI.Page
    {
        Cls_Utilitarios util = new Cls_Utilitarios();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarTabla();
            }
            else
            {
                string EventTarget = Request["__EVENTTARGET"];
                string x = Request["__EVENTARGUMENT"];
                if ((EventTarget != null) && (EventTarget == "Editar"))
                {
                    Editar(x);
                }
            }
        }

        public void ListarTabla()
        {
            ds = util.ObtenerConexion("SELECT Id_User, Username FROM MANT.VW_LISTUSER", "T");

            StringBuilder html = new StringBuilder();

            Literal msj = new Literal();
            foreach (DataRow row in ds.Tables["T"].Rows)
            {
                html.Append(
                    "<tr>" +
                    "<td>" + row["Id_User"] + "</td>" +
                    "<td>" + row["Username"] + "</td>" +
                    "<td><a href='#' class='btn btn-info' Onclick='Editar(\"" + row["Id_User"] + "\");'><i class='fas fa-edit'></i></a></td>" +
                    "</tr>"
                    );
            }
            msj.Text = html.ToString();
            TablaUsuario.Controls.Add(msj);
        }

        public void Editar(string id)
        {
            Session["Codigo_usuario"] = id;
            Response.Redirect("UsuarioAdmin.aspx");
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Session["Codigo_usuario"] = null;
            Response.Redirect("UsuarioAdmin.aspx");
        }
    }
}
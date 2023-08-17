using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tienda_online.models;

namespace Tienda_online
{
    public partial class login2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void alertas(String texto)
        {
            string message = texto;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());

        }
        protected void bingresar_Click(object sender, EventArgs e)
        {
            if (ClsUsuario.ConsultarUsuario(tusuario.Text, tclave.Text) > 0)
            {
                Response.Redirect("https://localhost:44318/views/Admin/Productos");
            }
            else
            {
                alertas("Usuario no existe");
            }
        }

        protected void tclave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
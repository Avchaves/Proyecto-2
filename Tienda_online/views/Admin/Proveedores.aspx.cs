using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tienda_online.views.Admin
{
    public partial class Marca : System.Web.UI.Page
    {
        models.Functions con;
                                
        protected void Page_Load(object sender, EventArgs e)
        {
            con= new models.Functions();
            ShowProveedor();

        }

        private void ShowProveedor()
        {
            string Query = "select * from Proveedores";
            ListaProveedores.DataSource = con.GetData(Query);
            ListaProveedores.DataBind();
        }

        protected void GUARDARBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(nombreTb.Value == "" || tipoCb.SelectedIndex == -1 || ciudadCb.SelectedIndex == -1)
                {
                    ErrMsg.Text = "Missing Data";
                }
                else
                {
                    string Cnombre = nombreTb.Value;
                    string Ctipo = tipoCb.SelectedItem.ToString();
                    string Cciudad = ciudadCb.SelectedItem.ToString();

                    string Query = "insert into Proveedores values ('{0}','{1}','{2}')";
                    Query= string.Format(Query, Cnombre, Ctipo, Cciudad);
                    con.SetDaTa(Query);
                    ShowProveedor();
                    ErrMsg.Text = " Proveedor Agregado";
                    nombreTb.Value = "";
                    tipoCb.SelectedIndex = -1;
                    ciudadCb.SelectedIndex = -1;


                }
            }
            catch (Exception ex) 
            {
                ErrMsg.Text = ex.Message;
            }
        }
    }
}
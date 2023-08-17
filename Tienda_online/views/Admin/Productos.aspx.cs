using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tienda_online.views.Admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        models.Functions con;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new models.Functions();
            
            if (!IsPostBack)
            {
                ShowProductos();
               
                
            }
            
        }
        private void ShowProductos()
        {
            string Query = "select * from productos";
            ListaProductos.DataSource = con.GetData(Query);
            ListaProductos.DataBind();
        }

        
        
        

        protected void GUARDARBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nombreTb.Value == "" || precioTb.Value == "" || cantidadTb.Value=="" ||categoriaTb.SelectedIndex==-1 || proveedorTb.SelectedIndex==-1)

                {
                    ErrMsg.Text = "Missing Data";
                }
                else
                {
                    string Bnombre = nombreTb.Value;
                    string Bprecio = precioTb.Value;
                    string Bcantidad = cantidadTb.Value;
                    string Bcategoria = categoriaTb.SelectedItem.ToString();
                    string Bproveedor =proveedorTb.SelectedItem.ToString();

                    string Query = "insert into categoria values('{0}','{1}')";
                    Query = string.Format(Query, Bnombre, Bprecio,Bcantidad,Bcategoria,Bproveedor);
                    con.SetDaTa(Query);
                    ShowProductos();
                    ErrMsg.Text = "Producto Insertado";
                    precioTb.Value = "";
                    nombreTb.Value = "";
                    cantidadTb.Value = "";
                    categoriaTb.SelectedIndex = -1;
                    proveedorTb.SelectedIndex= -1;  


                }

            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;

            }

        }
        int key = 0;

        protected void ListaProductos_selectedIndexChanged(object sender, EventArgs e)
        {
            nombreTb.Value = ListaProductos.SelectedRow.Cells[2].Text;
            categoriaTb.SelectedItem.Value = ListaProductos.SelectedRow.Cells[3].Text;
            precioTb.Value = ListaProductos.SelectedRow.Cells[4].Text;
            cantidadTb.Value = ListaProductos.SelectedRow.Cells[5].Text;
            proveedorTb.SelectedItem.Value = ListaProductos.SelectedRow.Cells[6].Text;
            if (nombreTb.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ListaProductos.SelectedRow.Cells[1].Text.ToString());
            }

        }

        protected void ACTUALIZARBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nombreTb.Value == "" || precioTb.Value == "" || cantidadTb.Value == "" || categoriaTb.SelectedIndex == -1 || proveedorTb.SelectedIndex == -1)

                {
                    ErrMsg.Text = "Missing Data";
                }
                else
                {
                    string Bnombre = nombreTb.Value;
                    string Bprecio = precioTb.Value;
                    string Bcantidad = cantidadTb.Value;
                    string Bcategoria = categoriaTb.SelectedItem.ToString();
                    string Bproveedor = proveedorTb.SelectedItem.ToString();

                    string Query = "update  categoria set nombre ='{0}', precio='{1}' cantidad'{2},categoria'{3}',proveedor'{4}";
                    Query = string.Format(Query, Bnombre, Bprecio,Bcantidad,Bcategoria,Bproveedor, ListaProductos.SelectedRow.Cells[6].Text);
                    con.SetDaTa(Query);
                    ShowProductos();
                    ErrMsg.Text = "Producto Actualizado";
                    precioTb.Value = "";
                    nombreTb.Value = "";
                    cantidadTb.Value = "";
                    categoriaTb.SelectedIndex = -1;
                    proveedorTb.SelectedIndex = -1;



                }

            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;

            }

        }
    }
}
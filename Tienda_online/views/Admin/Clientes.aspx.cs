using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tienda_online.views.Admin
{
    public partial class Clientes : System.Web.UI.Page
    {
        models.Functions con;


        protected void Page_Load(object sender, EventArgs e)
        {
            con = new models.Functions();
            showCliente();
        }

        private void showCliente()
        {
            string Query = "select * from clientes";
            ListaClientes.DataSource = con.GetData(Query);
            ListaClientes.DataBind();
        }
        protected void GUARDARBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nombreTb.Value == "" || apellidoTb.Value == "" || direccionTb.Value == "" || telefonoTb.Value == "")

                {
                    ErrMsg.Text = "Missing Data";

                }
                else
                {
                    string Cnombre = nombreTb.Value;
                    string Capellido = apellidoTb.Value;
                    string Cdireccion = direccionTb.Value;
                    string Ctelefono = telefonoTb.Value;

                    string Query = "insert into clientes values('{0}','{1}','{2}','{3}')";
                    Query = string.Format(Query, Cnombre, Capellido, Cdireccion, Ctelefono);
                    con.SetDaTa(Query);
                    showCliente();
                    ErrMsg.Text = "Cliente agregado";
                    nombreTb.Value = "";
                    apellidoTb.Value = "";
                    direccionTb.Value = "";
                    telefonoTb.Value = "";
                }

            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;

            }

        }



        int key = 0;


        protected void ListaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            nombreTb.Value = ListaClientes.SelectedRow.Cells[2].Text;
            apellidoTb.Value = ListaClientes.SelectedRow.Cells[3].Text;
            direccionTb.Value = ListaClientes.SelectedRow.Cells[3].Text;
            telefonoTb.Value = ListaClientes.SelectedRow.Cells[3].Text;
            if (nombreTb.Value == "")
            {
                key = 0;

            }
            else
            {
                key = Convert.ToInt32(ListaClientes.SelectedRow.Cells[1].Text);

            }
        }

        protected void ACTUALIZARBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nombreTb.Value == "" || apellidoTb.Value == "" || direccionTb.Value == "" || telefonoTb.Value == "")

                {
                    ErrMsg.Text = "Missing Data";
                }
                else
                {
                    string Cnombre = nombreTb.Value;
                    string Capellido = apellidoTb.Value;
                    string Cdireccion = direccionTb.Value;
                    string Ctelefono = telefonoTb.Value;

                    string Query = "update into clientes set nombre= '{0}', apellido ='{1}' direccion='{2}' telefono='{3}' where id_categoria= {2}";
                    Query = string.Format(Query, Cnombre, Capellido, Cdireccion, Ctelefono, ListaClientes.SelectedRow.Cells[2].Text);
                    con.SetDaTa(Query);
                    showCliente();
                    ErrMsg.Text = "Cliente Actualizado";
                    nombreTb.Value = "";
                    apellidoTb.Value = "";
                    direccionTb.Value = "";
                    telefonoTb.Value = "";


                }

            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;

            }
        }

        protected void ELIMINARBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nombreTb.Value == "" || apellidoTb.Value == "" || direccionTb.Value == "" || telefonoTb.Value == "")

                {
                    ErrMsg.Text = "Missing Data";
                }
                else
                {
                    string Cnombre = nombreTb.Value;
                    string Capellido = apellidoTb.Value;
                    string Cdireccion = direccionTb.Value;
                    string Ctelefono = telefonoTb.Value;


                    string Query = "delete from clientes where id_cliente= {0}";
                    Query = string.Format(Query, ListaClientes.SelectedRow.Cells[1].Text);
                    con.SetDaTa(Query);
                    showCliente();
                    ErrMsg.Text = "Categoria Eliminada";
                    nombreTb.Value = "";
                    apellidoTb.Value = "";
                    direccionTb.Value = "";
                    telefonoTb.Value = "";

                }

            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;

            }
        }
    }
}

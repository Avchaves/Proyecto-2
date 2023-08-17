using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace Tienda_online.views.Admin
{
    public partial class Categorias : System.Web.UI.Page
    {
        models.Functions con;


        protected void Page_Load(object sender, EventArgs e)
        {
            con = new models.Functions();
            showcategoria();
        }

        private void showcategoria()
        {
            string Query = "select * from categoria";
            ListaCategorias.DataSource = con.GetData(Query);
            ListaCategorias.DataBind();
        }
        protected void GUARDARBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nombreCat.Value == "" || descripcionCat.Value=="")

                {
                    ErrMsg.Text = "Missing Data";
                }
                else
                {
                    string nombre = nombreCat.Value;
                    string descripcion = descripcionCat.Value;

                    string Query = "insert into categoria values('{0}','{1}')";
                    Query = string.Format(Query, nombre, descripcion);
                    con.SetDaTa(Query);
                    showcategoria();
                    ErrMsg.Text = "Categoria Insertada";
                    nombreCat.Value = "";
                    descripcionCat.Value = "";
                  


                }

            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;

            }

        }
        int key = 0;


        protected void ListaCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            nombreCat.Value = ListaCategorias.SelectedRow.Cells[2].Text;
            descripcionCat.Value = ListaCategorias.SelectedRow.Cells[3].Text;
            
            if (nombreCat.Value == "")
            {
                key = 0;

            }
            else
            {
                key= Convert.ToInt32(ListaCategorias.SelectedRow.Cells[1].Text);

            }
        }

        protected void ACTUALIZARBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nombreCat.Value == "" || descripcionCat.Value == "")

                {
                    ErrMsg.Text = "Missing Data";
                }
                else
                {
                    string nombre = nombreCat.Value;
                    string descripcion = descripcionCat.Value;

                    string Query = "update into categoria set nombre= '{0}', descripcion ='{1}' where id_categoria= {2}";
                    Query = string.Format(Query, nombre, descripcion, ListaCategorias.SelectedRow.Cells[2].Text);
                    con.SetDaTa(Query);
                    showcategoria();
                    ErrMsg.Text = "Categoria Actualizada";
                    nombreCat.Value = "";
                    descripcionCat.Value = "";


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
                if (nombreCat.Value == "" || descripcionCat.Value == "")

                {
                    ErrMsg.Text = "Missing Data";
                }
                else
                {
                    string nombre = nombreCat.Value;
                    string descripcion = descripcionCat.Value;

                    string Query = "delete from categoria where id_categoria= {0}";
                    Query = string.Format(Query, ListaCategorias.SelectedRow.Cells[1].Text);
                    con.SetDaTa(Query);
                    showcategoria();
                    ErrMsg.Text = "Categoria Eliminada";
                    nombreCat.Value = "";
                    descripcionCat.Value = "";


                }

            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;

            }
        }
    }
}
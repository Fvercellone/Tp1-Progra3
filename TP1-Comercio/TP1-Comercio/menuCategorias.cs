using Conexion;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_Comercio
{
    public partial class menuCategorias : Form
    {

        public menuCategorias()
        {
            InitializeComponent();

            CBOFiltros.Items.Add("ID");
            CBOFiltros.Items.Add("Nombre");
            CBOFiltros.SelectedIndex = 0;

            Cargar();
        }

        private void BTNAccesoProcductos_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        List<Categoria> ListaCategorias = new List<Categoria>();
        private void Cargar()
        {
            ManejadorCategorias conexion = new ManejadorCategorias();
            try
            {
                ListaCategorias = conexion.Listar();
                DGVProductos.DataSource = ListaCategorias;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void TXBBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Categoria> listaFiltrada;
            string Filtro = CBOFiltros.SelectedItem.ToString();

            if (Filtro == "Nombre" && TXBBusqueda.Text != "")
            {
                listaFiltrada = ListaCategorias.FindAll(x => x.Nombre.ToUpper().Contains(TXBBusqueda.Text.ToUpper()));
            }
            else if (Filtro == "ID" && TXBBusqueda.Text != "")
            {
                listaFiltrada = ListaCategorias.FindAll(x => x.idCategoria.ToString().Contains(TXBBusqueda.Text));
            }
            else
            {
                listaFiltrada = ListaCategorias;
            }

            DGVProductos.DataSource = null;
            DGVProductos.DataSource = listaFiltrada;
        }

        private void CBOFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = CBOFiltros.SelectedItem.ToString();
            if (opcion == "ID")
            {
                string seleccionado = CBOFiltros.SelectedItem.ToString();
            }
            else if (opcion == "Nombre")
            {
                string Seleccionado = CBOFiltros.SelectedItem.ToString();
            }
        }

        private void BTAceptar_Click(object sender, EventArgs e)
        {
            ManejadorCategorias conexion = new ManejadorCategorias();
            try
            {

                Categoria categoria = new Categoria();

                categoria.Nombre = TBNombre.Text;

                if (ValidacionExisten(categoria.Nombre) == true)
                {
                    MessageBox.Show("No se puede agregar la categoría porque ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("Desea Agregar la categoría?", "Categoría Agregada", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    conexion.Agregar(categoria);
                    MessageBox.Show("Categoría agregada con éxito");
                }
                else
                {
                    MessageBox.Show("Categoría no agregada");
                    TBNombre.Text = "";
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("No puedes agregar un Nombre Vacio");
            }
            finally
            {
                TBNombre.Text = "";
                Cargar();
            }
        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {
            BTAceptar.Enabled = !string.IsNullOrEmpty(TBNombre.Text);
        }

        private void BTEliminar_Click(object sender, EventArgs e)
        {
            ManejadorCategorias conexion = new ManejadorCategorias();
            Producto producto = new Producto();
            Categoria Seleccionada = (Categoria)DGVProductos.CurrentRow.DataBoundItem;
            try
            {
                if (ValidacionExisten(Seleccionada.idCategoria) == true)
                {
                    MessageBox.Show("No se puede eliminar la categoría porque hay productos asociados a ella.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult result = MessageBox.Show("Desea eliminar la categoría seleccionada?", "Categoría Eliminada", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    conexion.Eliminar(Seleccionada.idCategoria);
                    Cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public bool ValidacionExisten(int idCategoria)
        {
            {
                manjadorProductos conexion = new manjadorProductos();
                List<Producto> listaProductos = conexion.listar();
                foreach (Producto producto in listaProductos)
                {
                    if (producto.Categoria != null && producto.Categoria.idCategoria == idCategoria)
                    {
                        return true;
                    }
                }
                return false;

            }
        }

        public bool ValidacionExisten(string Nombre)
        {
            ManejadorCategorias conexion = new ManejadorCategorias();
            List<Categoria> Lista = conexion.Listar();
            foreach (Categoria categoria in Lista)
            {
                if (categoria != null && categoria.Nombre.ToUpperInvariant() == Nombre.ToUpperInvariant())
                {
                    return true;
                }
            }
            return false;
        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {

            groupBox2.Enabled = true;

            Categoria Seleccionada = (Categoria)DGVProductos.CurrentRow.DataBoundItem;
            try
            {
               if (ValidacionExisten(Seleccionada.idCategoria) == true)
                {
                    MessageBox.Show("No se puede Modificar la Categoria porque hay productos asociados a ella.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                TBNombre2.Text = Seleccionada.Nombre;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void BTNAcepModificacion_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria Seleccionada = (Categoria)DGVProductos.CurrentRow.DataBoundItem;
                ManejadorCategorias conexion = new ManejadorCategorias();
                Seleccionada.Nombre = TBNombre2.Text;


                if (ValidacionExisten(Seleccionada.Nombre) == true)
                {
                    MessageBox.Show("No se puede modificar la Categoría porque ya existe una con ese nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                conexion.Modificar(Seleccionada);

                MessageBox.Show("Categoria modificada con éxito");
                Cargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                TBNombre2.Text = "";
                groupBox2.Enabled = false;
            }
        }

        private void TBNombre2_TextChanged(object sender, EventArgs e)
        {
            BTNAcepModificacion.Enabled = !string.IsNullOrEmpty(TBNombre2.Text);
        }


        private void BTNCancelar_Click_1(object sender, EventArgs e)
        {
            TBNombre2.Text = "";
            groupBox2.Enabled = false;
        }
    }
}

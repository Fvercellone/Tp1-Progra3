using Conexion;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_Comercio
{
    public partial class MenuMarcas : Form
    {

        private Marca marca = null;
        public MenuMarcas()
        {
            InitializeComponent();

            CBOFiltros.Items.Add("ID");
            CBOFiltros.Items.Add("Nombre");
            CBOFiltros.SelectedIndex = 0;

            cargar();

        }

        private void BTNAccesoProcductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*
        private void BTNAccesoCategoria_Click(object sender, EventArgs e)
        {
            MenuCategorias categorias = new MenuCategorias();
            categorias.Show();
            this.Hide();
        }*/


        // -------------------------------


        List<Marca> listaMarca = new List<Marca>();

        private void cargar()
        {
            ManejadorMarca conexion = new ManejadorMarca();
            try
            {
                listaMarca = conexion.Listar();
                DGVProductos.DataSource = listaMarca;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        /*FILTRO*/

        private void TXBBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Marca> listaFiltrada;
            string Filtro = CBOFiltros.SelectedItem.ToString();

            if (Filtro == "Nombre" && TXBBusqueda.Text != "")
            {
                listaFiltrada = listaMarca.FindAll(x => x.Nombre.ToUpper().Contains(TXBBusqueda.Text.ToUpper()));
            }
            else if (Filtro == "ID" && TXBBusqueda.Text != "")
            {
                 listaFiltrada = listaMarca.FindAll(x => x.idMarca.ToString().Contains(TXBBusqueda.Text));
            }
            else
            {
                listaFiltrada = listaMarca;
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
                string seleccionado = CBOFiltros.SelectedItem.ToString();
            }
        }

        /*--Agregar--*/
        private void BTAceptar_Click(object sender, EventArgs e)
        {
            ManejadorMarca conexion = new ManejadorMarca();
            try
            {

                marca = new Marca();

                marca.Nombre = TBNombre.Text;

                if (ValidacionExisten(marca.Nombre) == true)
                {
                    MessageBox.Show("No se puede agregar la marca porque ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("Desea Agregar la marca?", "Marca Agregada", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    conexion.agregar(marca);
                    MessageBox.Show("Marca agregada con éxito");
                }
                else
                {
                    MessageBox.Show("Marca no agregada");
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
                cargar();
            }
        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {
            BTAceptar.Enabled = !string.IsNullOrEmpty(TBNombre.Text);
        }
        

        /*--Eliminar--*/
        private void BTEliminar_Click(object sender, EventArgs e)
        {
            ManejadorMarca conexion = new ManejadorMarca();
            Producto producto = new Producto();
            Marca Seleccionada= (Marca)DGVProductos.CurrentRow.DataBoundItem;
            try
            { 
                if (ValidacionExisten(Seleccionada.idMarca) == true)
                {
                    MessageBox.Show("No se puede eliminar la marca porque hay productos asociados a ella.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult result = MessageBox.Show("Desea eliminar la marca seleccionada?", "Marca Eliminada", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    conexion.Eliminar(Seleccionada.idMarca);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        public bool ValidacionExisten(int idMarca)
        {
            manjadorProductos  conexion = new manjadorProductos();
            List<Producto> listaProductos = conexion.listar();
            foreach (Producto producto in listaProductos)
            {
                if (producto.Marca != null && producto.Marca.idMarca == idMarca)
                {
                    return true;
                }
            }
            return false; 
        }
        public bool ValidacionExisten(string Nombre)
        {
            ManejadorMarca conexion = new ManejadorMarca();
            List<Marca> Lista = conexion.Listar();
            foreach (Marca marca in Lista)
            {
                if (marca != null && marca.Nombre.ToUpperInvariant() == Nombre.ToUpperInvariant())
                {
                    return true;
                }
            }
            return false;
        }


        /*--Modificar--*/
        private void BTNModificar_Click(object sender, EventArgs e)
        {

            groupBox2.Enabled = true;

                Marca Seleccionada = (Marca)DGVProductos.CurrentRow.DataBoundItem;
            try
            {
                if (ValidacionExisten(Seleccionada.idMarca) == true)
                {
                    MessageBox.Show("No se puede Modificar la marca porque hay productos asociados a ella.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Marca Seleccionada = (Marca)DGVProductos.CurrentRow.DataBoundItem;
                ManejadorMarca conexion = new ManejadorMarca();
                Seleccionada.Nombre = TBNombre2.Text;


                if (ValidacionExisten(Seleccionada.Nombre) == true)
                {
                    MessageBox.Show("No se puede Modificar la marca porque ya existe una con ese Nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                conexion.Modificar(Seleccionada);

                MessageBox.Show("Marca modificada con éxito");
                cargar();
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

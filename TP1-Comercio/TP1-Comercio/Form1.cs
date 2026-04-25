using Conexion;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_Comercio
{
    public partial class Form1 : Form
    {
        List<Producto> listaProductos = new List<Producto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ruta = @"C:\IMG";
            Directory.CreateDirectory(ruta);

            cargar();

            CBOFiltros.Items.Add("Nombre");
            CBOFiltros.Items.Add("Marca");
            CBOFiltros.Items.Add("Categoria");
            CBOFiltros.SelectedIndex = 0;
        }

        private void cargar()
        {
            manjadorProductos conexion = new manjadorProductos();
            try
            {
                listaProductos = conexion.listar();
                DGVProductos.DataSource = listaProductos;
                ocultarColumnas();
                CargarImagen(listaProductos[0].Imagen);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void DGVProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVProductos.CurrentRow != null)
            {
                Producto seleccionado = (Producto)DGVProductos.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.Imagen);
            }
        }

        private void ocultarColumnas()
        {
            DGVProductos.Columns["Imagen"].Visible = false;
            DGVProductos.Columns["Id"].Visible = false;
        }

        public void CargarImagen(string imagen)
        {
            try
            {
                pbxProducto.Load(imagen);
            }
            catch (Exception)
            {
                pbxProducto.Load("https://capacitacion.fundacionbancopampa.com.ar/wp-content/uploads/2024/09/placeholder-4.png");
            }
        }

        private void BTAgregarA_Click(object sender, EventArgs e)
        {
            AgregarArticulo agregarA = new AgregarArticulo();
            agregarA.ShowDialog();  
            cargar();
        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            Producto Seleccionado;
            Seleccionado = (Producto)DGVProductos.CurrentRow.DataBoundItem;

            AgregarArticulo modificar = new AgregarArticulo(Seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void BTEliminar_Click(object sender, EventArgs e)
        {
            manjadorProductos conexion = new manjadorProductos();
            Producto Seleccionado;
            try
            {
                DialogResult result = MessageBox.Show("Desea eliminar el producto seleccionado?", "Producto Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Seleccionado = (Producto)DGVProductos.CurrentRow.DataBoundItem;
                    conexion.Eliminar(Seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void BTVerDetalle_Click(object sender, EventArgs e)
        {
            Producto Seleccionado;
            Seleccionado = (Producto)DGVProductos.CurrentRow.DataBoundItem;

            VerDetalleProducto detalle = new VerDetalleProducto(Seleccionado);
            detalle.ShowDialog(); 
            cargar();
        }

        private void TXBBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Producto> listaFiltrada;
            string Filtro = CBOFiltros.SelectedItem.ToString();

            if (Filtro == "Nombre" && TXBBusqueda.Text != "")
            {
                listaFiltrada = listaProductos.FindAll(x => x.Name.ToUpper().Contains(TXBBusqueda.Text.ToUpper()));
            }
            else if (Filtro == "Categoria" && TXBBusqueda.Text != "")
            {
                listaFiltrada = listaProductos.FindAll(x => x.Categoria.Nombre.ToUpper().Contains(TXBBusqueda.Text.ToUpper()));
            }
            else if (Filtro == "Marca" && TXBBusqueda.Text != "")
            {
                listaFiltrada = listaProductos.FindAll(x => x.Marca.Nombre.ToUpper().Contains(TXBBusqueda.Text.ToUpper()));
            }
            else
            {
                listaFiltrada = listaProductos;
            }

            DGVProductos.DataSource = null;
            DGVProductos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void CBOFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = CBOFiltros.SelectedItem.ToString();
            if(opcion == "Nombre")
            {
                string seleccionado = CBOFiltros.SelectedItem.ToString();
            }
            else if(opcion == "Categoria")
            {
                string seleccionado = CBOFiltros.SelectedItem.ToString();
            }
            else
            {
                string seleccionado = CBOFiltros.SelectedItem.ToString();
            }
        }

        private void BNTAccesoMarcas_Click(object sender, EventArgs e)
        {
            MenuMarcas marcas = new MenuMarcas();
            this.Hide();
            marcas.ShowDialog();
            this.Show();
        }

        private void BTNAccesoCategoria_Click(object sender, EventArgs e)
        {
            menuCategorias categorias = new menuCategorias();
            this.Hide();
            categorias.ShowDialog();
            this.Show();
        }

    }
}

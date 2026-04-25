using Conexion;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public MenuMarcas()
        {
            InitializeComponent();

            CBOFiltros.Items.Add("ID");
            CBOFiltros.Items.Add("Nombre");
            CBOFiltros.SelectedIndex = 0;

            cargar();

        }

        private void BNTAccesoMarcas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ya te encuentras en el menú de Marcas.");
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
        private void MenuMacas_Load(object sender, EventArgs e)
        {

        }



        private void cargar()
        {
            ManejadorMarca conexion = new ManejadorMarca();
            try
            {
                listaMarca = conexion.Listar();
                DGVProductos.DataSource = listaMarca;
                CargarImagen("https://create.vista.com/es/photos/marca");
            }
            catch (Exception ex)
            {

                throw ex;
            }
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

        /*FILTRO*/

        private void TXBBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Marca> listaFiltrada;
            string Filtro = CBOFiltros.SelectedItem.ToString();

            if (Filtro == "Nombre" && TXBBusqueda.Text != "")
            {
                listaFiltrada = listaMarca.FindAll(x => x.descripcion.ToUpper().Contains(TXBBusqueda.Text.ToUpper()));
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





    }
}

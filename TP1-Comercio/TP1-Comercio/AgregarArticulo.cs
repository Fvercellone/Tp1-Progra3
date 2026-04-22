using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion;
using Dominio;

namespace TP1_Comercio
{
    public partial class AgregarArticulo : Form
    {
        public AgregarArticulo()
        {
            InitializeComponent();
        }

        private void BTCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTAceptar_Click(object sender, EventArgs e)
        {
            Producto nuevo = new Producto();
            manjadorProductos conexion = new manjadorProductos();
            try
            {
                nuevo.Codigo = TBCodigo.Text;
                nuevo.Name = TBNombre.Text;
                nuevo.Description = TBDescripcion.Text;
                nuevo.Precio = decimal.Parse(TBPrecio.Text);
                nuevo.Marca = (Marca)CBMarca.SelectedItem;
                nuevo.Categoria = (Categoria)CBCategoria.SelectedItem;



                //nuevo.Imagen = TBImagen.Text;
                conexion.agregar(nuevo);
                MessageBox.Show("Producto agregado con éxito");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AgregarArticulo_Load(object sender, EventArgs e)
        {
            ManejadorMarca marca = new ManejadorMarca();
            ManejadorCategorias categoria = new ManejadorCategorias();


            try
            {
                CBMarca.DataSource = marca.Listar();
                CBCategoria.DataSource = categoria.Listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
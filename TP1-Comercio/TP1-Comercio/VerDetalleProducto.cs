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
    public partial class VerDetalleProducto : Form
    {
        private Producto producto;

        public VerDetalleProducto(Producto producto)    
        {
            InitializeComponent();
            this.producto = producto;
            cargarDetalle(producto);
        }
        public void cargarDetalle(Producto producto)
        {
            ManejadorMarca marca = new ManejadorMarca();
            ManejadorCategorias categoria = new ManejadorCategorias();

            CBMarca.DataSource = marca.Listar();
            CBMarca.ValueMember = "idMarca";
            CBMarca.DisplayMember = "descripcion";
            CBCategoria.DataSource = categoria.Listar();
            CBCategoria.ValueMember = "idCategoria";
            CBCategoria.DisplayMember = "descripcion";

            try
            {
                TBCodigo.Text = producto.Codigo;
                TBNombre.Text = producto.Name;
                TBDescripcion.Text = producto.Description;
                TBPrecio.Text = producto.Precio.ToString();
                CBMarca.SelectedValue = producto.Marca.idMarca;
                CBCategoria.SelectedValue = producto.Categoria.idCategoria;
                TXBFoto.Text = producto.Imagen;
                cargarImagen(producto.Imagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       

        public void cargarImagen(string imagen)
        {
            try
            {
                PBNuevoProducto.Load(imagen);
            }
            catch (Exception)
            {
                PBNuevoProducto.Load("https://capacitacion.fundacionbancopampa.com.ar/wp-content/uploads/2024/09/placeholder-4.png");
            }
        }

        private void BTCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

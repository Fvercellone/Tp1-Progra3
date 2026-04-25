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
using Conexion;
using Dominio;
using System.Configuration;

namespace TP1_Comercio
{
    public partial class AgregarArticulo : Form
    {
        private Producto producto = null;
        private OpenFileDialog file = null;
        public AgregarArticulo()
        {
            InitializeComponent();
        }

        public AgregarArticulo(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            Text = "Modificar Artículo";
        }

        private void BTCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTAceptar_Click(object sender, EventArgs e)
        {
            manjadorProductos conexion = new manjadorProductos();
            try
            {
                if (producto == null)
                    producto = new Producto();

                producto.Codigo = TBCodigo.Text;
                producto.Name = TBNombre.Text;
                producto.Description = TBDescripcion.Text;
                producto.Precio = decimal.Parse(NUDPrecio.Text);
                producto.Marca = (Marca)CBMarca.SelectedItem;
                producto.Categoria = (Categoria)CBCategoria.SelectedItem;
                producto.Imagen = TXBFoto.Text;

                if (producto.Id != 0)
                {
                    conexion.modificar(producto);
                    MessageBox.Show("Producto modificado con éxito");
                }
                else
                {
                conexion.agregar(producto);
                MessageBox.Show("Producto agregado con éxito");
                }

                if (file != null && !(TXBFoto.Text.ToUpper().Contains("HTTP")))
                {
                    string carpetaImagenes = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "assets",
                    "images"
                    );
                    Directory.CreateDirectory(carpetaImagenes);

                    string nombreArchivo = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

                    string rutaDestino = Path.Combine(carpetaImagenes, nombreArchivo);

                    File.Copy(file.FileName, rutaDestino, true);

                    // guardar ruta relativa
                    producto.Imagen = Path.Combine("assets", "images", nombreArchivo);
                }

                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("El unico campo que puede quedar vacio es el de fotos");
            }
        }

        private void AgregarArticulo_Load(object sender, EventArgs e)
        {
            ManejadorMarca marca = new ManejadorMarca();
            ManejadorCategorias categoria = new ManejadorCategorias();


            try
            {
                CBMarca.DataSource = marca.Listar();
                CBMarca.ValueMember = "idMarca";
                CBMarca.DisplayMember = "Nombre";
                CBCategoria.DataSource = categoria.Listar();
                CBCategoria.ValueMember = "idCategoria";
                CBCategoria.DisplayMember = "Nombre";

                if (producto != null)
                {
                    TBCodigo.Text = producto.Codigo;
                    TBNombre.Text = producto.Name;
                    TBDescripcion.Text = producto.Description;
                    NUDPrecio.Text = producto.Precio.ToString();
                    CBMarca.SelectedValue = producto.Marca.idMarca;
                    CBCategoria.SelectedValue = producto.Categoria.idCategoria;
                    TXBFoto.Text = producto.Imagen;
                    cargarImagen(producto.Imagen);

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El unico campo que puede quedar vacio es el de fotos");
            }

        }

        private void TXBFoto_Leave(object sender, EventArgs e)
        {
            cargarImagen(TXBFoto.Text);
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

        private void ImagenArchivo_Click(object sender, EventArgs e)
        {
            file = new OpenFileDialog();
            file.Filter = "jpg|*.jpg;|png|*.png";
            if (file.ShowDialog() == DialogResult.OK)
            {
                TXBFoto.Text = file.FileName;
                cargarImagen(file.FileName);
            }

        }

        private void TBCodigo_TextChanged(object sender, EventArgs e)
        {
            BTAceptar.Enabled = !string.IsNullOrEmpty(TBCodigo.Text) && !string.IsNullOrEmpty(TBNombre.Text) && NUDPrecio.Value > 0;
        }
    }
}
using Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

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
            cargar();
        }

        private void cargar()
        {
            manjadorProductos conexion = new manjadorProductos();
            try
            {
                listaProductos = conexion.listar();
                DGVProductos.DataSource = listaProductos;
                ocultarColumnas();
                cargarImagen(listaProductos[0].Imagen);
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
                cargarImagen(seleccionado.Imagen);
            }
        }

        private void ocultarColumnas()
        {
            DGVProductos.Columns["Imagen"].Visible = false;
        }

        public void cargarImagen(string imagen)
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
    }
}

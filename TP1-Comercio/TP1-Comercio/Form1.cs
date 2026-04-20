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
using Conexion;

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
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

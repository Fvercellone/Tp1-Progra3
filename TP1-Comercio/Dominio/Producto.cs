using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //cambiar marca despues a una referencia a un clase marca
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public string Imagen { get; set; }
        public decimal Precio { get; set; }
    }
}

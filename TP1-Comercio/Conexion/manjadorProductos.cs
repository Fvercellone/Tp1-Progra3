using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Conexion
{
    public class manjadorProductos
    {
        public List<Producto> listar()
        {
            List<Producto> lista = new List<Producto>();
            ConexionDB conexion = new ConexionDB();
            try
            {
                conexion.settearConsulta("SELECT P.Id, P.Nombre, P.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, I.ImagenUrl, P.Precio FROM dbo.articulos as P, dbo.imagenes as I, dbo.marcas as M, dbo.categorias as C WHERE P.Id = I.Idarticulo AND M.id = P.IdMarca AND c.Id = P.IdCategoria");
                conexion.ejecutarLectura();
                while (conexion._lector.Read())
                {
                    Producto aux = new Producto();
                    aux.Id = (int)conexion._lector["Id"];
                    aux.Name = (string)conexion._lector["Nombre"];
                    aux.Description = (string)conexion._lector["Descripcion"];
                    aux.Marca = (string)conexion._lector["Marca"];
                    aux.Categoria = (string)conexion._lector["Categoria"];
                    aux.Imagen = (string)conexion._lector["ImagenUrl"];
                    aux.Precio = (decimal)conexion._lector["Precio"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }
    }
}

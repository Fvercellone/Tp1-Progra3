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
                conexion.settearConsulta("SELECT P.Id, P.Nombre, P.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, I.ImagenUrl, P.Precio FROM dbo.articulos P LEFT JOIN dbo.imagenes I ON P.Id = I.Idarticulo LEFT JOIN dbo.marcas M ON M.Id = P.IdMarca LEFT JOIN dbo.categorias C ON C.Id = P.IdCategoria");
                conexion.ejecutarLectura();
                while (conexion._lector.Read())
                {
                    Producto aux = new Producto();

                    aux.Id = (int)conexion._lector["Id"];
                    aux.Name = (string)conexion._lector["Nombre"];
                    aux.Description = (string)conexion._lector["Descripcion"];
                    aux.Marca = new Marca();
                    if (conexion._lector["marca"] != DBNull.Value)
                        aux.Marca.descripcion = (string)conexion._lector["Marca"];
                    else
                        aux.Marca.descripcion = "n/a";
                    aux.Categoria = new Categoria();
                    if (conexion._lector["categoria"] != DBNull.Value)
                        aux.Categoria.descripcion = (string)conexion._lector["Categoria"];
                    else
                        aux.Categoria.descripcion = "n/a";
                    if(conexion._lector["ImagenUrl"] != DBNull.Value)
                        aux.Imagen = (string)conexion._lector["ImagenUrl"];
                    else
                        aux.Imagen = "n/a";
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

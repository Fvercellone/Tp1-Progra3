using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
    internal class ManejadorCategorias
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            ConexionDB conexion = new ConexionDB();
            try
            {
                conexion.settearConsulta("SELECT C.Id, C.Descripcion FROM dbo.CATEGORIAS as C");
                conexion.ejecutarLectura();
                while (conexion._lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.idCategoria = (int)conexion._lector["Id"];
                    aux.descripcion = (string)conexion._lector["Descripcion"];
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

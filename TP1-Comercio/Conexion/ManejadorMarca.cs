using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
    internal class ManejadorMarca
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            ConexionDB conexion = new ConexionDB();
            try
            {
                conexion.settearConsulta("SELECT M.Id, M.Descripcion FROM dbo.marcas as M");
                conexion.ejecutarLectura();
                while (conexion._lector.Read())
                {
                    Marca aux = new Marca();
                    aux.idMarca = (int)conexion._lector["Id"];
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

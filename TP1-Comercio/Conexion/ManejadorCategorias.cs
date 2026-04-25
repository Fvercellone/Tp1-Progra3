using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
    public class ManejadorCategorias
    {
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();
            ConexionDB conexion = new ConexionDB();
            try
            {
                conexion.settearConsulta("SELECT C.Id, C.Descripcion as Nombre FROM dbo.CATEGORIAS as C");
                conexion.ejecutarLectura();
                while (conexion._lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.idCategoria = (int)conexion._lector["Id"];
                    aux.Nombre = (string)conexion._lector["Nombre"];
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

        public void Agregar(Categoria nuevo) {
            ConexionDB conexion = new ConexionDB();
            try
            {
                conexion.settearConsulta("INSERT INTO dbo.categorias (Descripcion) VALUES (@descripcion);");
                conexion.agregarParametro("@descripcion", nuevo.Nombre);
                conexion.ejecutarAccion();
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

        public void Eliminar(int id)
        {
            ConexionDB conexion = new ConexionDB();
            try
            {
                conexion.settearConsulta("DELETE FROM categorias WHERE Id = @Id");
                conexion.agregarParametro("@Id", id);
                conexion.ejecutarAccion();
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

        public void Modificar(Categoria categoria)
        {
            ConexionDB conexion = new ConexionDB();
            try
            {
                conexion.settearConsulta("BEGIN TRANSACTION; UPDATE Categorias SET Descripcion = @Nombre WHERE Id = @Id; COMMIT");
                conexion.agregarParametro("@Id", categoria.idCategoria);
                conexion.agregarParametro("@Nombre", categoria.Nombre);
                conexion.ejecutarAccion();
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

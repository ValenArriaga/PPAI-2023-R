using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TPPav1.Datos
{
    class BDHelper
    {

        private static BDHelper instancia;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlTransaction transaccion;
        private string cadenaConexion;

        private BDHelper()
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();

            //Valentin
            //cadenaConexion = @"Data Source=DESKTOP-84H3S6N\SQLEXPRESS;Initial Catalog=PPAI;Integrated Security=True";

            //valentin 2
            cadenaConexion = @"Data Source=VARRIAGA\VARRIAGA;Initial Catalog=PPAI;Integrated Security=True";
        }

        enum ResultadoTransaccion
        {
            exito, fracaso
        }
        enum tipoConexion
        {
            simple, transaccion
        }
        private ResultadoTransaccion miEstado = ResultadoTransaccion.exito;
        private tipoConexion miTipo = tipoConexion.simple;

        public static BDHelper ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new BDHelper();
            return instancia;
        }

        public DataTable Consultar(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());

            conexion.Close();
            return tabla;
        }

        public int Actualizar(string consultaSQL)
        {
            int filasAfectadas = 0;
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            filasAfectadas = comando.ExecuteNonQuery();

            conexion.Close();
            return filasAfectadas;
        }

        public int Insertar(string consultaSQL, string tabla)
        {
            int id;
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            comando.ExecuteNonQuery();

            id = (int) ConsultaSQLScalar("Select * from " + tabla + " order by 1 desc");
            
            conexion.Close();
            return id;
        }

        public void ConectarConTransaccion()
        {
            miTipo = tipoConexion.transaccion;
            miEstado = ResultadoTransaccion.exito;

            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            transaccion = conexion.BeginTransaction();
            comando.Transaction = transaccion;
            comando.Connection = conexion;
        }
        public bool Desconectar()
        {
            if (miTipo == tipoConexion.transaccion)
            {
                if (miEstado == ResultadoTransaccion.exito)
                {
                    transaccion.Commit(); //MessageBox.Show("La trasacción resultó con éxito...");
                }
                else
                {
                    transaccion.Rollback(); //MessageBox.Show("La trasacción no pudo realizarce...");
                }
                miTipo = tipoConexion.simple;
            }
            if ((conexion.State == ConnectionState.Open))
            {
                conexion.Close();
            }

            // Dispose() libera los recursos asociados a la conexón
            conexion.Dispose();
            if (miEstado.Equals(ResultadoTransaccion.exito))
                return true;
            else
                return false;
        }

        public void EjecutarSQLConTransaccion(string consultaSql)
        {
            //  Se utiliza para sentencias SQL del tipo Insert, Update, Delete con transaccion.
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = consultaSql;
                comando.ExecuteNonQuery();
                miEstado = ResultadoTransaccion.exito;
            }
            catch
            {
                miEstado = ResultadoTransaccion.fracaso;
            }
        }
        public object ConsultaSQLScalar(string consultaSql)
        {
                comando.CommandType = CommandType.Text;
                comando.CommandText = consultaSql;
                return comando.ExecuteScalar();
        }

    }

}


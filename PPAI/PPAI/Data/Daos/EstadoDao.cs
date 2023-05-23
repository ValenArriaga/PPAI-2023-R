using PPAI.Data.InterfacesDaos;
using PPAI.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPav1.Datos;

namespace PPAI.Data.Daos
{
    public class EstadoDao : IEstadoDao
    {
        public EstadoEntity GetEstadoById(int id)
        {
            EstadoEntity oEstado = new EstadoEntity();
            string consulta = "SELECT * FROM Estado WHERE id =" + id;

            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (tabla.Rows.Count > 0)
            {
                oEstado.Id = Int32.Parse(tabla.Rows[0]["id"].ToString());
                oEstado.Nombre = tabla.Rows[0]["nombre"].ToString().Trim();
            }
            return oEstado;
        }

        public List<EstadoEntity> GetAll()
        {
            List<EstadoEntity> lista = new List<EstadoEntity>();
            string consulta = "Select * from Estado";
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    EstadoEntity oEstado = new EstadoEntity();
                    oEstado.Nombre = fila["nombre"].ToString();
                    lista.Add(oEstado);
                }
            }
            return lista;
        }
    }
}

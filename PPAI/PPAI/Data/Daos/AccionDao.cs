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
    class AccionDao : IAccionDao
    {
        public AccionEntity GetAccionById(int id)
        {
            AccionEntity oAccion = new AccionEntity();
            string consulta = "SELECT * FROM Accion WHERE id =" + id;

            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (tabla.Rows.Count > 0)
            {
                oAccion.Descripcion = tabla.Rows[0]["descripcion"].ToString();
                oAccion.Id = Int32.Parse(tabla.Rows[0]["id"].ToString());
            }
            return oAccion;
        }

        public List<AccionEntity> GetAll()
        {
            List<AccionEntity> lista = new List<AccionEntity>();
            string consulta = "Select * from Accion";
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    AccionEntity oAccion = new AccionEntity();
                    oAccion.Descripcion = fila["descripcion"].ToString();
                    oAccion.Id = Int32.Parse(tabla.Rows[0]["id"].ToString());
                    lista.Add(oAccion);
                }
            }
            return lista;
        }
    }
}

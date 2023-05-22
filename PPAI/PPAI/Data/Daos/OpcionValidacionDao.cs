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
    public class OpcionValidacionDao
    {
        public OpcionValidacionEntity GetById(int id)
        {
            OpcionValidacionEntity oOpcion = new OpcionValidacionEntity();
            string consulta = "Select * from OpcionValidacion where idOpcionValidacion = " + id;
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (tabla.Rows.Count > 0)
            {
                oOpcion.Correcta = tabla.Rows[0]["correcta"].ToString();
                oOpcion.Descripcion = tabla.Rows[0]["descripcion"].ToString();
                oOpcion.Id = Int32.Parse(tabla.Rows[0]["id"].ToString());

            }
            return oOpcion;
        }
        public List<OpcionValidacionEntity> GetOpcionesByIdValidacion(int id)
        {
            List<OpcionValidacionEntity> lista = new List<OpcionValidacionEntity>();
            string consulta = "Select * from OpcionValidacion where idValidacion = " + id;
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            foreach (DataRow fila in tabla.Rows)
            {
                OpcionValidacionEntity oOpcion = new OpcionValidacionEntity();
                oOpcion.Correcta = tabla.Rows[0]["correcta"].ToString();
                oOpcion.Descripcion = tabla.Rows[0]["descripcion"].ToString();
                lista.Add(oOpcion);
            }
            return lista;
        }
    }
}

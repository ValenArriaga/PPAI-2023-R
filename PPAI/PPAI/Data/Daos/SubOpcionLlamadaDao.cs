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
    class SubOpcionLlamadaDao : ISubOpcionLlamadaDao
    {
        public SubOpcionLlamadaEntity getSubOpcionLlamadaById(int id)
        {
            SubOpcionLlamadaEntity oSubOpcionLlamada = new SubOpcionLlamadaEntity();
            string consulta = "SELECT * FROM SubOpcionLlamada WHERE id =" + id;

            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            ValidacionDao vdao = new ValidacionDao();
            if (tabla.Rows.Count > 0)
            {  
               oSubOpcionLlamada.Nombre = tabla.Rows[0]["nombre"].ToString();
               oSubOpcionLlamada.NroOrden = Int32.Parse(tabla.Rows[0]["nroOrden"].ToString());
               oSubOpcionLlamada.Id = Int32.Parse(tabla.Rows[0]["id"].ToString());
               oSubOpcionLlamada.ValidacionRequerida = vdao.getValidacionBySubOpcionId(Int32.Parse(tabla.Rows[0]["id"].ToString()));

            }
            return oSubOpcionLlamada;
        }

        public List<SubOpcionLlamadaEntity> getSubOpcionByOpcionId(int id)
        {
            List<SubOpcionLlamadaEntity> lista = new List<SubOpcionLlamadaEntity>();
            string consulta = "SELECT * FROM SubOpcionLlamada WHERE idOpcion = " + id;
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            ValidacionDao vdao = new ValidacionDao();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    SubOpcionLlamadaEntity oSubOpcionLlamada = new SubOpcionLlamadaEntity();
                    oSubOpcionLlamada.Nombre = tabla.Rows[0]["nombre"].ToString();
                    oSubOpcionLlamada.NroOrden = Int32.Parse(tabla.Rows[0]["nroOrden"].ToString());
                    oSubOpcionLlamada.Id = Int32.Parse(tabla.Rows[0]["id"].ToString());
                    oSubOpcionLlamada.ValidacionRequerida = vdao.getValidacionBySubOpcionId(Int32.Parse(tabla.Rows[0]["id"].ToString()));

                    lista.Add(oSubOpcionLlamada);
                }
            }
            return lista;
        }
    }
}

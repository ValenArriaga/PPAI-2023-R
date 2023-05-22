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
    class ValidacionDao : IValidacionDao
    {
        public ValidacionEntity getValidacionById(int id)
        {
            ValidacionEntity oValidacion = new ValidacionEntity();
            string consulta = "SELECT * FROM Validacion WHERE id =" + id;

            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (tabla.Rows.Count > 0)
            {
                oValidacion.AudioMensajeValidacion = tabla.Rows[0]["audioMensajeValidacion"].ToString();
                oValidacion.Nombre = tabla.Rows[0]["nombre"].ToString();
                oValidacion.NroOrden = Int32.Parse(tabla.Rows[0]["nroOrden"].ToString());
                oValidacion.Id = Int32.Parse(tabla.Rows[0]["id"].ToString());
            }
            return oValidacion;
        }

        public List <ValidacionEntity> getValidacionBySubOpcionId(int id)
        {
            List<ValidacionEntity> lista = new List<ValidacionEntity>();
            string consulta = "SELECT * FROM Validacion WHERE idSubopcion = " + id;
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            OpcionValidacionDao ovdao = new OpcionValidacionDao();
            ValidacionDao vdao = new ValidacionDao();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    ValidacionEntity oValidacion = new ValidacionEntity();
                    oValidacion.AudioMensajeValidacion = fila["audioMensajeValidacion"].ToString();
                    oValidacion.Nombre = fila["nombre"].ToString();
                    oValidacion.NroOrden = Int32.Parse(fila["nroOrden"].ToString());
                    oValidacion.Id = Int32.Parse(fila["id"].ToString());

                    oValidacion.OpcionesValidacion = ovdao.getOpcionesByIdValidacion(oValidacion.Id);
                    lista.Add(oValidacion);
                }
            }
            return lista;
        }

        public List<ValidacionEntity> getValidacionByOpcionId(int id)
        {
            List<ValidacionEntity> lista = new List<ValidacionEntity>();
            string consulta = "SELECT * FROM Validacion WHERE idOpcion = " + id;
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            OpcionValidacionDao ovdao = new OpcionValidacionDao();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    ValidacionEntity oValidacion = new ValidacionEntity();
                    oValidacion.AudioMensajeValidacion = fila["audioMensajeValidacion"].ToString();
                    oValidacion.Nombre = fila["nombre"].ToString();
                    oValidacion.NroOrden = Int32.Parse(fila["nroOrden"].ToString());
                    oValidacion.Id = Int32.Parse(fila["id"].ToString());

                    oValidacion.OpcionesValidacion = ovdao.getOpcionesByIdValidacion(oValidacion.Id);
                    lista.Add(oValidacion);
                }
            }
            return lista;
        }

    }
}

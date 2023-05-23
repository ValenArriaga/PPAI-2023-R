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
    class OpcionLlamadaDao : IOpcionLlamadaDao
    {

        public OpcionLlamadaEntity GetOpcionLlamadaById(int id)
        {
            OpcionLlamadaEntity oOpcionLlamada = new OpcionLlamadaEntity();
            string consulta = "SELECT * FROM OpcionLlamada WHERE id =" + id;

            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            ValidacionDao vdao = new ValidacionDao();
            SubOpcionLlamadaDao soldao = new SubOpcionLlamadaDao();
            if (tabla.Rows.Count > 0)
            {
               oOpcionLlamada.AudioMensajeSubopciones = tabla.Rows[0]["audioMensajeSubopciones"].ToString();
               oOpcionLlamada.MensajeSubopciones = tabla.Rows[0]["mensajeSubopciones"].ToString();
               oOpcionLlamada.Nombre = tabla.Rows[0]["nombre"].ToString();
               oOpcionLlamada.NroOrden = Int32.Parse(tabla.Rows[0]["nroOrden"].ToString());
               oOpcionLlamada.Id = Int32.Parse(tabla.Rows[0]["id"].ToString());
               oOpcionLlamada.ValidacionesRequeridas = vdao.GetValidacionByOpcionId(oOpcionLlamada.Id);
               oOpcionLlamada.SubopcionLlamada = soldao.GetSubOpcionByOpcionId(oOpcionLlamada.Id);
            }
            return oOpcionLlamada;
        }

        public List <OpcionLlamadaEntity> GetOpcionByCategoriaId(int id)
        {
            List<OpcionLlamadaEntity> lista = new List<OpcionLlamadaEntity>();
            string consulta = "SELECT * FROM OpcionLlamada WHERE idOpcion = " + id;
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            ValidacionDao vdao = new ValidacionDao();
            SubOpcionLlamadaDao soldao = new SubOpcionLlamadaDao();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    OpcionLlamadaEntity oOpcionLlamada = new OpcionLlamadaEntity();
                    oOpcionLlamada.AudioMensajeSubopciones = tabla.Rows[0]["audioMensajeSubopciones"].ToString();
                    oOpcionLlamada.MensajeSubopciones = tabla.Rows[0]["mensajeSubopciones"].ToString();
                    oOpcionLlamada.Nombre = tabla.Rows[0]["nombre"].ToString();
                    oOpcionLlamada.NroOrden = Int32.Parse(tabla.Rows[0]["nroOrden"].ToString());
                    oOpcionLlamada.Id = Int32.Parse(tabla.Rows[0]["id"].ToString());
                    oOpcionLlamada.ValidacionesRequeridas = vdao.GetValidacionByOpcionId(oOpcionLlamada.Id);
                    oOpcionLlamada.SubopcionLlamada = soldao.GetSubOpcionByOpcionId(oOpcionLlamada.Id);
                    lista.Add(oOpcionLlamada);
                }
            }
            return lista;
        }
    }
}

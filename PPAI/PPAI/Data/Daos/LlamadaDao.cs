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
    public class LlamadaDao : ILlamadaDao
    {
        public LlamadaEntity getById(int id)
        {
            LlamadaEntity oLlamada = new LlamadaEntity();
            string consulta = "select * from llamada where idLlamada = " + id;
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            ClienteDao cdao = new ClienteDao();
            OpcionLlamadaDao oldao = new OpcionLlamadaDao();
            SubOpcionLlamadaDao soldao = new SubOpcionLlamadaDao();
            CambioEstadoDao cedao = new CambioEstadoDao();
            if (tabla.Rows.Count > 0)
            {
                oLlamada.DescripcionOperador = tabla.Rows[0]["descripcionOperador"].ToString();
                oLlamada.Accion = tabla.Rows[0]["detalleAccionRequerida"].ToString();
                oLlamada.Duracion = (TimeSpan)tabla.Rows[0]["duracion"];
                oLlamada.EncuestaEnviada = (bool)tabla.Rows[0]["encuestaEnviada"];
                oLlamada.ObservacionAuditor = tabla.Rows[0]["observacionAuditor"].ToString();
                oLlamada.Id = Int32.Parse(tabla.Rows[0]["id"].ToString());
                oLlamada.Cliente = cdao.GetById((int)tabla.Rows[0]["idCliente"]);
                oLlamada.OpcionSeleccionada = oldao.getOpcionLlamadaById((int)tabla.Rows[0]["idOpcionLlamada"]);
                oLlamada.SubOpcionSeleccionada = soldao.getSubOpcionLlamadaById((int)tabla.Rows[0]["idSubOpcionLlamada"]);
                oLlamada.CambiosEstado = cedao.GetCambiosByLlamadaId(id);
            }
            return oLlamada;
        }
    }
}

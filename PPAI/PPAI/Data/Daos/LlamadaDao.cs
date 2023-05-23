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
        public LlamadaEntity GetLlamadaById(int id)
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
                string encuesta = tabla.Rows[0]["encuestaEnviada"].ToString();
                if (encuesta == "1")
                    oLlamada.EncuestaEnviada = true;
                else
                    oLlamada.EncuestaEnviada = false;
                oLlamada.ObservacionAuditor = tabla.Rows[0]["observacionAuditor"].ToString();
                oLlamada.Id = Int32.Parse(tabla.Rows[0]["idLlamada"].ToString());
                oLlamada.Cliente = cdao.GetClienteById((int)tabla.Rows[0]["idCliente"]);
                oLlamada.OpcionSeleccionada = oldao.GetOpcionLlamadaById((int)tabla.Rows[0]["idOpcionLlamada"]);
                oLlamada.SubOpcionSeleccionada = soldao.GetSubOpcionLlamadaById((int)tabla.Rows[0]["idSubOpcionLlamada"]);
                oLlamada.CambiosEstado = cedao.GetCambiosByLlamadaId(id);

            }
            return oLlamada;
        }

    }
}

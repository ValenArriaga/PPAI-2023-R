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
    class LlamadaDao : ILlamadaDao
    {
        public LlamadaEntity getLlamadaById(int id)
        {
            LlamadaEntity oLlamada = new LlamadaEntity();
            string consulta = "";
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (tabla.Rows.Count > 0)
            {
                oLlamada.DescripcionOperador = tabla.Rows[0]["descripcionOperador"].ToString();
                oLlamada.Accion = tabla.Rows[0]["detalleAccionRequerida"].ToString();
                oLlamada.Duracion = (TimeSpan)tabla.Rows[0]["duracion"];
                oLlamada.EncuestaEnviada = (bool)tabla.Rows[0]["encuestaEnviada"];
                oLlamada.ObservacionAuditor = tabla.Rows[0]["observacionAuditor"].ToString();
                oLlamada.Cliente.NombreCompleto = tabla.Rows[0]["nombreCompleto"].ToString();
            }
            tabla.Rows[0]["detalleAccionRequerida"].ToString();
            return oLlamada;
        }
    }
}

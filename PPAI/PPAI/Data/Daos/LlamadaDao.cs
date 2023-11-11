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
                if (oLlamada.CambiosEstado.Count > 0) 
                    oLlamada.EstadoActual = oLlamada.CambiosEstado[oLlamada.CambiosEstado.Count - 1].EstadoAP;
            }
            return oLlamada;
        }

        public int NuevaLlamada()
        {
            int nuevoId;
            string tabla = "Llamada";
            string consulta = "insert into Llamada(idCliente, idSubOpcionLlamada, idOpcionLlamada, idUsuario, Estado)" +
                "values(1, 1, 1, 1, 1)";
            nuevoId = BDHelper.ObtenerInstancia().Insertar(consulta, tabla);
            return nuevoId;
        }

        public bool Update(LlamadaEntity llamada)
        {
            int encuesta = 0;
            if (llamada.EncuestaEnviada)
                encuesta = 1;
            StringBuilder commandText = new StringBuilder();
            commandText.AppendFormat("Update llamada ");
            commandText.AppendFormat(" Set descripcionOperador = {0}, ", llamada.DescripcionOperador);
            commandText.AppendFormat("      detalleAccionRequerida = {0}, ", llamada.DetalleAccionRequerida);
            commandText.AppendFormat("      duracion = {0}, ", llamada.Duracion);
            commandText.AppendFormat("      encuestaEnviada = {0}, ", encuesta);
            commandText.AppendFormat("      idCliente = {0}, ", llamada.Cliente.Id);
            commandText.AppendFormat("      idSubOpcionLlamada = {0}, ", llamada.SubOpcionSeleccionada.Id);
            commandText.AppendFormat("      idOpcionLlamada = {0}, ",llamada.OpcionSeleccionada.Id);
            commandText.AppendFormat("      Estado = {0} ", llamada.EstadoActual.Id);
            commandText.AppendFormat(" where idLlamada = {0} ");

            int filas = BDHelper.ObtenerInstancia().Actualizar(commandText.ToString());

            CambioEstadoDao cedao = new CambioEstadoDao();
            foreach (CambioEstadoEntity cambio in llamada.CambiosEstado)
            {
                cedao.Insertar(cambio);
            }

            return filas < 0;
        }

    }
}

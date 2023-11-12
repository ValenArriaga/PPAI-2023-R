using PPAI.Data.InterfacesDaos;
using PPAI.Entities;
using PPAI.Entities.Estado;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPav1.Datos;

namespace PPAI.Data.Daos
{
    public class CambioEstadoDao : ICambioEstadoDao
    {
        public CambioEstadoEntity GetCambioEstadoById(int id)
        {
            throw new NotImplementedException();
        }

        public List<CambioEstadoEntity> GetCambiosByLlamadaId(int id)
        {
            List<CambioEstadoEntity> lista = new List<CambioEstadoEntity>();
            string consulta = "SELECT * FROM CambioEstado WHERE idLlamada = " + id;
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            EstadoDao edao = new EstadoDao();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    CambioEstadoEntity oCambio = new CambioEstadoEntity();
                    oCambio.Estado = edao.GetEstadoById((int)fila["idEstado"]);
                    oCambio.FechaHoraInicio = (DateTime)fila["fechaHoraInicio"];
                    oCambio.Id = Int32.Parse(tabla.Rows[0]["id"].ToString());

                    if (oCambio.Estado.Id == 1)
                        oCambio.EstadoAP = new Iniciada { Nombre = "Iniciada" };
                    else if (oCambio.Estado.Id == 2)
                        oCambio.EstadoAP = new EnCurso { Nombre = "EnCurso" };
                    else if (oCambio.Estado.Id == 3)
                        oCambio.EstadoAP = new Iniciada { Nombre = "Iniciada" };
                    else if (oCambio.Estado.Id == 4)
                        oCambio.EstadoAP = new Cancelada { Nombre = "Cancelada" };

                    lista.Add(oCambio);
                }
            }
            return lista;
        }

        public int Insertar(CambioEstadoEntity cambio, int idLlamada)
        {
            return Insertar(cambio.FechaHoraInicio, cambio.EstadoAP.Id, idLlamada);
        }

        public int Insertar(DateTime now, int idEstado, int idLlamada)
        {
            StringBuilder commandText = new StringBuilder();
            commandText.AppendFormat("INSERT INTO CambioEstado(fechaHoraInicio, idLlamada, idEstado) ");
            commandText.AppendFormat(" values ('{0}', {1}, {2}) ", now.ToString(), idLlamada, idEstado);

            return BDHelper.ObtenerInstancia().Insertar(commandText.ToString(), "CambioEstado");
        }
    }
}

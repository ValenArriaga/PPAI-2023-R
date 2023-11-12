using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entities
{
    public class LlamadaEntity : Entity
    {
        private string descripcionOperador;
        private string detalleAccionRequerida;
        private TimeSpan duracion;
        private bool encuestaEnviada;
        private string observacionAuditor;
        private OpcionLlamadaEntity opcionSeleccionada = new OpcionLlamadaEntity();
        private SubOpcionLlamadaEntity subOpcionSeleccionada = new SubOpcionLlamadaEntity();
        private string auditor;
        private string operador;
        private ClienteEntity cliente = new ClienteEntity();
        private string accion;
        private List<CambioEstadoEntity> cambiosEstado = new List<CambioEstadoEntity>();


        public string DescripcionOperador { get => descripcionOperador; set => descripcionOperador = value; }
        public string DetalleAccionRequerida { get => detalleAccionRequerida; set => detalleAccionRequerida = value; }
        public TimeSpan Duracion { get => duracion; set => duracion = value; }
        public bool EncuestaEnviada { get => encuestaEnviada; set => encuestaEnviada = value; }
        public string ObservacionAuditor { get => observacionAuditor; set => observacionAuditor = value; }
        public OpcionLlamadaEntity OpcionSeleccionada { get => opcionSeleccionada; set => opcionSeleccionada = value; }
        public SubOpcionLlamadaEntity SubOpcionSeleccionada { get => subOpcionSeleccionada; set => subOpcionSeleccionada = value; }
        public string Auditor { get => auditor; set => auditor = value; }
        public string Operador { get => operador; set => operador = value; }
        public ClienteEntity Cliente { get => cliente; set => cliente = value; }
        public string Accion { get => accion; set => accion = value; }
        public List<CambioEstadoEntity> CambiosEstado { get => cambiosEstado; set => cambiosEstado = value; }
        public EstadoA EstadoActual { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

        public bool ValidarInfoCliente(string respuesta, ValidacionEntity validacion)
        {
            return Cliente.EsInfoCorrecta(respuesta, validacion);
        }

        public void Finalizada(DateTime now)
        {
            EstadoActual.Finalizada(now, this);
        }

        public void TomadaPorOperador(DateTime now)
        {
            EstadoActual.TomadaPorOperador(now, this);
        }

        public void Cancelada(DateTime now)
        {
            EstadoActual.Cancelada(now, this);
        }
    }
}

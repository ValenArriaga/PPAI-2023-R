using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entities
{
    public class LlamadaEntity
    {
        private string descripcionOperador;
        private string detalleAccionRequerida;
        private double duracion;
        private bool encuestaEnviada;
        private string observacionAuditor;
        private OpcionLlamadaEntity opcionSeleccionada = new OpcionLlamadaEntity();
        private SubOpcionLlamadaEntity subOpcionSeleccionada = new SubOpcionLlamadaEntity();
        private string auditor;
        private string operador;
        private ClienteEntity cliente = new ClienteEntity();
        private string accion;
        private List<CambioEstadoEntity> cambioEstado = new List<CambioEstadoEntity>();

        public string DescripcionOperador { get => descripcionOperador; set => descripcionOperador = value; }
        public string DetalleAccionRequerida { get => detalleAccionRequerida; set => detalleAccionRequerida = value; }
        public double Duracion { get => duracion; set => duracion = value; }
        public bool EncuestaEnviada { get => encuestaEnviada; set => encuestaEnviada = value; }
        public string ObservacionAuditor { get => observacionAuditor; set => observacionAuditor = value; }
        public OpcionLlamadaEntity OpcionSeleccionada { get => opcionSeleccionada; set => opcionSeleccionada = value; }
        public SubOpcionLlamadaEntity SubOpcionSeleccionada { get => subOpcionSeleccionada; set => subOpcionSeleccionada = value; }
        public string Auditor { get => auditor; set => auditor = value; }
        public string Operador { get => operador; set => operador = value; }
        public ClienteEntity Cliente { get => cliente; set => cliente = value; }
        public string Accion { get => accion; set => accion = value; }
        public List<CambioEstadoEntity> CambioEstado { get => cambioEstado; set => cambioEstado = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

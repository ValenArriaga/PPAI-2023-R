using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entities
{
    public class CambioEstadoEntity : Entity
    {
        public CambioEstadoEntity() { }
        public CambioEstadoEntity(DateTime fecha, EstadoA estado)
        {
            FechaHoraInicio = fecha;
            EstadoAP = estado;
        }

        private DateTime fechaHoraInicio;
        private EstadoA estadoA;

        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        public EstadoA EstadoAP { get => estadoA; set => estadoA = value; }

        public override string ToString()
        {
            return "Estado: " + EstadoAP.Nombre + "\t - \t Fecha de Inicio: " + FechaHoraInicio;
        }
    }
}

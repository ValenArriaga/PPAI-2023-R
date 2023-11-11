using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entities
{
    public abstract class EstadoA : Entity
    {
        public string Nombre { get; set; }

        public virtual void TomadaPorOperador(DateTime date, LlamadaEntity llamada)
        {
            EstadoA nuevoEstado = CrearProximoEstado(llamada);
            CambioEstadoEntity nuevoCambio = CrearCambioEstado(date, nuevoEstado);
            llamada.CambiosEstado.Add(nuevoCambio);
            llamada.EstadoActual = nuevoEstado;
        }

        public virtual void Cancelada(DateTime fecha, LlamadaEntity llamada)
        {
            EstadoA nuevoEstado = CrearProximoEstado(llamada);
            CambioEstadoEntity nuevoCambio = CrearCambioEstado(fecha, nuevoEstado);
            llamada.CambiosEstado.Add(nuevoCambio);
            llamada.EstadoActual = nuevoEstado;
        }

        public virtual void Finalizada(DateTime fecha, LlamadaEntity llamada)
        {
            EstadoA nuevoEstado = CrearProximoEstado(llamada);
            CambioEstadoEntity nuevoCambio = CrearCambioEstado(fecha, nuevoEstado);
            llamada.CambiosEstado.Add(nuevoCambio);
            llamada.EstadoActual = nuevoEstado;
        }

        public abstract EstadoA CrearProximoEstado(LlamadaEntity llamada);

        public virtual CambioEstadoEntity CrearCambioEstado(DateTime fecha, EstadoA estado)
        {
            return new CambioEstadoEntity(fecha, estado);
        }
    }
}

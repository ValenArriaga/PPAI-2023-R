using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entities.Estado
{
    public class EnCurso : EstadoA
    {
        public EnCurso()
        {
            Id = 2;
        }

        public override void Cancelada(DateTime fecha, LlamadaEntity llamada)
        {
            EstadoA nuevoEstado = CrearProximoEstado(llamada);
            CambioEstadoEntity nuevoCambio = CrearCambioEstado(fecha, nuevoEstado);
            llamada.CambiosEstado.Add(nuevoCambio);
            llamada.EstadoActual = nuevoEstado;
            llamada.Duracion = CalcularDuracion(llamada);
        }

        public override void Finalizada(DateTime fecha, LlamadaEntity llamada)
        {
            EstadoA nuevoEstado = CrearProximoEstado(llamada);
            CambioEstadoEntity nuevoCambio = CrearCambioEstado(fecha, nuevoEstado);
            llamada.CambiosEstado.Add(nuevoCambio);
            llamada.EstadoActual = nuevoEstado;
            llamada.Duracion = CalcularDuracion(llamada);
        }

        public override bool EsEnCurso()
        {
            return true;
        }
        public override TimeSpan CalcularDuracion(LlamadaEntity llamada)
        {
            DateTime horaInicio = DateTime.Now;
            DateTime horaFin = DateTime.Now;
            TimeSpan duracion;

            foreach (CambioEstadoEntity cambioEstado in llamada.CambiosEstado)
            {
                if (cambioEstado.EstadoAP.EsIniciada())
                    horaInicio = cambioEstado.FechaHoraInicio;
                if (cambioEstado.EstadoAP.Equals(llamada.EstadoActual))
                    horaFin = cambioEstado.FechaHoraInicio;
            }

            duracion = horaFin - horaInicio;

            return duracion;
        }

        public override EstadoA CrearProximoEstado(LlamadaEntity llamada)
        {
            if (llamada.OpcionSeleccionada.Nombre == "Cancelar")
                return new Cancelada();
            else if (llamada.OpcionSeleccionada.Nombre == "Finalizar")
                return new Finalizada();
            else return null;
        }
    }
}

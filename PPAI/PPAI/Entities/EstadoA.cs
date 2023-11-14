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

        public virtual void TomadaPorOperador(DateTime date, LlamadaEntity llamada) { }

        public virtual void Cancelada(DateTime fecha, LlamadaEntity llamada) { }

        public virtual void Finalizada(DateTime fecha, LlamadaEntity llamada) { }

        public abstract EstadoA CrearProximoEstado(LlamadaEntity llamada);

        public virtual CambioEstadoEntity CrearCambioEstado(DateTime fecha, EstadoA estado)
        {
            return new CambioEstadoEntity(fecha, estado);
        }

        public virtual TimeSpan CalcularDuracion(LlamadaEntity llamada)
        {
            throw new NotImplementedException();
        }

        public virtual bool EsIniciada()
        {
            return false;
        }

        public virtual bool EsEnCurso()
        {
            return false;
        }

        public virtual bool EsFinalizada()
        {
            return false;
        }

        public virtual bool EsCancelada()
        {
            return false;
        }
    }
}

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

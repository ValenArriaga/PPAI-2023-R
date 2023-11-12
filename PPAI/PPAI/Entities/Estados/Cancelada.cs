using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entities.Estado
{
    public class Cancelada : EstadoA
    {
        public Cancelada()
        {
            Id = 4;
            Nombre = "Cancelada";
        }
        public override EstadoA CrearProximoEstado(LlamadaEntity llamada)
        {
            throw new NotImplementedException();
        }

        public override bool EsCancelada()
        {
            return true;
        }
    }
}

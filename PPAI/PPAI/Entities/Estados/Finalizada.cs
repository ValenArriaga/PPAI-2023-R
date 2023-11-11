using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entities.Estado
{
    public class Finalizada : EstadoA
    {
        public Finalizada()
        {
            Id = 3;
        }

        public override EstadoA CrearProximoEstado(LlamadaEntity llamada)
        {
            throw new NotImplementedException();
        }
    }
}

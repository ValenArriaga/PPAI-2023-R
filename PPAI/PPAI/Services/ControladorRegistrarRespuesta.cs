using PPAI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Services
{
    public class ControladorRegistrarRespuesta
    {
        private LlamadaEntity llamadaActual;
        private CategoriaLlamadaEntity categoriaSeleccionada;
        
        public void NuevaRtaOperador(LlamadaEntity llamada, CategoriaLlamadaEntity categoria)
        {
            llamadaActual = llamada;
            categoriaSeleccionada = categoria;
        }
    }
}

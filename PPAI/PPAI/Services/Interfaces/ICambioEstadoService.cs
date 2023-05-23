using PPAI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Services.Interfaces
{
    internal interface ICambioEstadoService
    {
        List<CambioEstadoEntity> GetAll();
        CambioEstadoEntity GetCambioEstadoById(int id);
    }
}

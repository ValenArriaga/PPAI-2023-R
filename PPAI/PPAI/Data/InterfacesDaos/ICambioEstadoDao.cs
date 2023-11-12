using PPAI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Data.InterfacesDaos
{
    interface ICambioEstadoDao
    {
        CambioEstadoEntity GetCambioEstadoById(int id);
        int Insertar(CambioEstadoEntity cambio, int idLlamada);
        int Insertar(DateTime fechaInicio, int idEstado, int idLlamada);
    }
}

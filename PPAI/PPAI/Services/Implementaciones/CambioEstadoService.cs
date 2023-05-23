using PPAI.Data.Daos;
using PPAI.Data.InterfacesDaos;
using PPAI.Entities;
using PPAI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Services.Implementaciones
{
    public class CambioEstadoService : ICambioEstadoService
    {
        ICambioEstadoDao cedao = new CambioEstadoDao();
        public List<CambioEstadoEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public CambioEstadoEntity GetCambioEstadoById(int id)
        {
            return cedao.GetCambioEstadoById(id);
        }

        
    }
}

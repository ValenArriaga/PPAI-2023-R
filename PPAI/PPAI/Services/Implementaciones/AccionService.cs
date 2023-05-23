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
    public class AccionService : IAccionService
    {
        IAccionDao adao = new AccionDao();
        public List<AccionEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public AccionEntity GetAccionById(int id)
        {
            return adao.GetAccionById(id);

        }
    }
}

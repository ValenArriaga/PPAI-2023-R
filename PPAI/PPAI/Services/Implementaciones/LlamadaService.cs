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
    public class LlamadaService : ILlamadaService
    {
        ILlamadaDao ldao = new LlamadaDao();
        public List<LlamadaEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public LlamadaEntity GetLlamadaById(int id)
        {
            return ldao.getById(id);
        }
    }
}

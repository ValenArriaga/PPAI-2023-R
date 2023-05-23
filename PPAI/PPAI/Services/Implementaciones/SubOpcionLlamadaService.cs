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
    public class SubOpcionLlamadaService : ISubOpcionLlamadaService
    {
        ISubOpcionLlamadaDao ldao = new SubOpcionLlamadaDao();
        public List<SubOpcionLlamadaEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public SubOpcionLlamadaEntity GetSubOpcionLlamadaById(int id)
        {
            return ldao.GetSubOpcionLlamadaById(id);
        }
    }
}

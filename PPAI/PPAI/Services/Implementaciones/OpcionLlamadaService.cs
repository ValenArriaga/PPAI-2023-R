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
    public class OpcionLlamadaService : IOpcionLlamadaService
    {
        IOpcionLlamadaDao ldao = new OpcionLlamadaDao();
        public List<OpcionLlamadaEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public OpcionLlamadaEntity GetOpcionLlamadaById(int id)
        {
            return ldao.GetOpcionLlamadaById(id);
        }
    }
}

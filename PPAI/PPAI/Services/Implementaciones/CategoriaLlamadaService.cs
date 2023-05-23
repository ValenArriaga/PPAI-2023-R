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
    public class CategoriaLlamadaService : ICategoriaLlamadaService
    {
        ICategoriaLlamadaDao cldao = new CategoriaLlamadaDao();
        public List<CategoriaLlamadaEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public CategoriaLlamadaEntity GetCategoriaLlamadaById(int id)
        {
            return cldao.GetCategoriaLlamadaByid(id);
        }
    }
}

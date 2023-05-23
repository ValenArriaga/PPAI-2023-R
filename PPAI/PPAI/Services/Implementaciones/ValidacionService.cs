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
    public class ValidacionService : IValidacionService
    {
        IValidacionDao ldao = new ValidacionDao();
        public List<ValidacionEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public ValidacionEntity GetValidacionById(int id)
        {
            return ldao.GetValidacionById(id);
        }
    }
}

using PPAI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Data.InterfacesDaos
{
    interface IValidacionDao
    {
        ValidacionEntity GetValidacionById(int id);
        List <ValidacionEntity> GetValidacionBySubOpcionId(int id);
        List<ValidacionEntity> GetValidacionByOpcionId(int id);


    }
}

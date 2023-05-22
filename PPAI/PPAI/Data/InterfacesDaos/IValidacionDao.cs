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
        ValidacionEntity getValidacionById(int id);
        List <ValidacionEntity> getValidacionBySubOpcionId(int id);
        List<ValidacionEntity> getValidacionByOpcionId(int id);


    }
}

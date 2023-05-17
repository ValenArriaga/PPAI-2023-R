using System;
using System.Collections.Generic;
using System.Linq;
using PPAI.Entities;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Services.Interfaces
{
    internal interface IOpcionValidacionService
    {
        List<OpcionValidacionEntity> GetAll();
    }
}

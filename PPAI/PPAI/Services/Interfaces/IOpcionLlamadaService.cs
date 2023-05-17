using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PPAI.Entities;
using System.Threading.Tasks;

namespace PPAI.Services.Interfaces
{
    internal interface IOpcionLlamadaService
    {
        List<OpcionLlamadaEntity> GetAll();
    }
}

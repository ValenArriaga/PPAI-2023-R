using System;
using PPAI.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Services.Interfaces
{
    internal interface IInformacionClienteService
    {
        List<InformacionClienteEntity> GetAll();
        List<InformacionClienteEntity> GetInformacionClienteById(int id);

    }
}

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
        public class ClienteService : IClienteService
        {
            IClienteDao cdao = new ClienteDao();
            public List<ClienteEntity> GetAll()
            {
                throw new NotImplementedException();
            }

            public ClienteEntity GetClienteById(int id)
            {
                return cdao.GetClienteById(id);
            }
        }
}

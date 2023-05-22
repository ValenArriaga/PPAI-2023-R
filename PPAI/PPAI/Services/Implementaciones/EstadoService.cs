﻿using PPAI.Data.Daos;
using PPAI.Entities;
using PPAI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Services.Implementaciones
{
    public class EstadoService : IEstadoService
    {
        IEstadoDao edao = new EstadoDao();
        public List<EstadoEntity> GetAll()
        {
            return edao.GetAll();
        }
    }
}

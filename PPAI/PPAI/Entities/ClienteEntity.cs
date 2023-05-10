﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entities
{
    public class ClienteEntity
    {
        private string dni;
        private string nombreCompleto;
        private string nroCelular;
        private List<InformacionClienteEntity> info = new List<InformacionClienteEntity>();

        public string Dni { get => dni; set => dni = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public string NroCelular { get => nroCelular; set => nroCelular = value; }
        public List<InformacionClienteEntity> Info { get => info; set => info = value; }

        public override string ToString()
        {
            return "Nombre: " + NombreCompleto + "\t - \t DNI: " + Dni;
        }
    }
}

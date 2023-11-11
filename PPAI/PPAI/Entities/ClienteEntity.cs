﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entities
{
    public class ClienteEntity : Entity
    {
        private int dni;
        private string nombreCompleto;
        private int nroCelular;

        private List<InformacionClienteEntity> info = new List<InformacionClienteEntity>();

        public int Dni { get => dni; set => dni = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public int NroCelular { get => nroCelular; set => nroCelular = value; }

        public List<InformacionClienteEntity> Info { get => info; set => info = value; }

        public override string ToString()
        {
            return "Nombre: " + NombreCompleto + "\t - \t DNI: " + Dni;
        }

        public bool EsInfoCorrecta(string respuesta, ValidacionEntity validacion)
        {
            foreach (InformacionClienteEntity info in Info)
            {
                if (info.EsValidacion(validacion))
                    return info.EsInfoCorrecta(respuesta);
            }
            return false;
        }
    }
}

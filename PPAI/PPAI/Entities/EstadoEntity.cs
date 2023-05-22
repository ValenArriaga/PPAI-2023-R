﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entities
{
    public class EstadoEntity
    {
        private string nombre;

        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return "Estado: " + Nombre;
        }

        public bool EsEnCurso()
        {
            if (Nombre == "EnCurso")
                return true;
            else
                return false;
        }

        public bool EsFinalizada()
        {
            if (Nombre == "Finalizada")
                return true;
            else
                return false;
        }
    }
}
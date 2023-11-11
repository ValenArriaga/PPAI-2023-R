using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entities
{
    public class OpcionValidacionEntity : Entity
    {
        private string correcta;
        private string descripcion;


        public string Correcta { get => correcta; set => correcta = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}

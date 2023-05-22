using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entities
{
    public class OpcionValidacionEntity
    {
        private string correcta;
        private string descripcion;
        private int id;


        public string Correcta { get => correcta; set => correcta = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}

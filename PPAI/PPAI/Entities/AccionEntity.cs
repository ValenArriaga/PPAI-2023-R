using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entities
{
    public class AccionEntity
    {
        private string descripcion;
        private int id;

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Id { get => id; set => id = value; }

    }
}

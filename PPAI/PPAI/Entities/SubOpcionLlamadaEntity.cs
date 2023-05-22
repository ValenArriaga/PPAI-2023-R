using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entities
{
    public class SubOpcionLlamadaEntity
    {
        private string nombre;
        private int nroOrden;
        private int id;
        private List<ValidacionEntity> validacionRequerida = new List<ValidacionEntity>();

        public string Nombre { get => nombre; set => nombre = value; }
        public int NroOrden { get => nroOrden; set => nroOrden = value; }
        public int Id { get => id; set => id = value; }

        public List<ValidacionEntity> ValidacionRequerida { get => validacionRequerida; set => validacionRequerida = value; }

        public override string ToString()
        {
            return "Nombre: " + Nombre + "\t - \t Numero de Orden: " + NroOrden;
        }
    }
}

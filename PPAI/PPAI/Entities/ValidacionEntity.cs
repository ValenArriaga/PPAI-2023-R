using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entities
{
    public class ValidacionEntity
    {
        private string audioMensajeValidacion;
        private string nombre;
        private int nroOrden;
        private int id;
        private List<OpcionValidacionEntity> opcionesValidacion = new List<OpcionValidacionEntity>();
        private string tipo;

        public string AudioMensajeValidacion { get => audioMensajeValidacion; set => audioMensajeValidacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NroOrden { get => nroOrden; set => nroOrden = value; }

        public int Id { get => id; set => id = value; }

        public List<OpcionValidacionEntity> OpcionesValidacion { get => opcionesValidacion; set => opcionesValidacion = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public override string ToString()
        {
            return "Nombre: " + Nombre + "\n Tipo: " + Tipo;
        }
    }
}

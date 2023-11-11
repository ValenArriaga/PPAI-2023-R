using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entities
{
    public class InformacionClienteEntity : Entity
    {
        private string datoAValidar;
        private OpcionValidacionEntity opcionCorrecta = new OpcionValidacionEntity();
        private ValidacionEntity validacion = new ValidacionEntity();
        private string tipo;


        public string DatoAValidar { get => datoAValidar; set => datoAValidar = value; }
        public OpcionValidacionEntity OpcionCorrecta { get => opcionCorrecta; set => opcionCorrecta = value; }
        public ValidacionEntity Validacion { get => validacion; set => validacion = value; }
        public string Tipo { get => tipo; set => tipo = value; }


        public override string ToString()
        {
            return "Dato a Validar: " + DatoAValidar + "\t - \t Tipo: " + Tipo + "\t - \t Validacion: " + Validacion;
        }

        public bool EsValidacion(ValidacionEntity validacion)
        {
            return DatoAValidar == validacion.Nombre;
        }

        public bool EsInfoCorrecta(string respuesta)
        {
            return OpcionCorrecta.Correcta == respuesta;
        }
    }
}

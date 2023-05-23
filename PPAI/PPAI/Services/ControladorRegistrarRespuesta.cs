using PPAI.Entities;
using PPAI.Services.Implementaciones;
using PPAI.Services.Interfaces;
using PPAI.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI.Services
{
    public class ControladorRegistrarRespuesta
    {
        LlamadaEntity llamadaActual;
        CategoriaLlamadaEntity categoriaSeleccionada;
        OpcionLlamadaEntity opcionSeleccionada = new OpcionLlamadaEntity();
        SubOpcionLlamadaEntity subopcionSeleccionada = new SubOpcionLlamadaEntity();
        List<ValidacionEntity> validaciones = new List<ValidacionEntity>();
        PantallaRegistrarRespuesta _pantalla;
        
        //Servicios
        IEstadoService estadoS = new EstadoService();
        ILlamadaService llamadaS = new LlamadaService();
        ICategoriaLlamadaService categoriaS = new CategoriaLlamadaService();

        internal void BuscarDatosLlamada()
        {
            BuscarInfoLlamada();
            List<string> nombreValidaciones = new List<string>();
            foreach (ValidacionEntity validacion in validaciones)
            {
                nombreValidaciones.Add(validacion.Nombre);
            }
            _pantalla.MostrarDatosLlamada(llamadaActual.Cliente.NombreCompleto, categoriaSeleccionada.Nombre, opcionSeleccionada.Nombre, subopcionSeleccionada.Nombre);
            _pantalla.MostrarValidaciones(nombreValidaciones);
        }

        public void NuevaRtaOperador(int idLlamada, int idCategoria, PantallaRegistrarRespuesta pantalla)
        {
            llamadaActual = llamadaS.GetLlamadaById(idLlamada);
            categoriaSeleccionada = categoriaS.GetCategoriaLlamadaById(idCategoria);
            _pantalla = pantalla;
            EstadoEntity enCurso = null;
            foreach (EstadoEntity estadoE in estadoS.GetAll())
            {
                if (estadoE.EsEnCurso())
                    enCurso = estadoE;
            }
            if (enCurso != null)
                llamadaActual.SetEstadoActual(enCurso, DateTime.Now);
            
        }

        public void BuscarInfoLlamada()
        {
            opcionSeleccionada = llamadaActual.OpcionSeleccionada;
            subopcionSeleccionada = llamadaActual.SubOpcionSeleccionada;
            foreach (ValidacionEntity validacion in subopcionSeleccionada.ValidacionRequerida)
            {
                validaciones.Add(validacion);
            }
        }

        public void TomarRtaYConfirmacion(string rtaOperador, string accion)
        {
            llamadaActual.DescripcionOperador = rtaOperador;
            LlamarCU28(accion);
            EstadoEntity finalizada = null;
            foreach (EstadoEntity estadoE in estadoS.GetAll())
            {
                if (estadoE.EsFinalizada())
                    finalizada = estadoE;
            }
            DateTime now = DateTime.Now;
            llamadaActual.CalcularDuracion(now);
            if (finalizada != null)
                llamadaActual.SetEstadoActual(finalizada, now);
            FinCU();
        }

        public void CancelarLlamada()
        {
            EstadoEntity cancelada = null;
            foreach (EstadoEntity estadoE in estadoS.GetAll())
            {
                if (estadoE.EsCancelada())
                    cancelada = estadoE;
            }
            DateTime now = DateTime.Now;
            llamadaActual.CalcularDuracion(now);
            if (cancelada != null)
                llamadaActual.SetEstadoActual(cancelada, now);
        }

        public void FinCU()
        {
            MessageBox.Show("Respuesta registrada con exito");
        }

        public void LlamarCU28(string accion)
        {
            llamadaActual.Accion = accion;
            MessageBox.Show("Accion registrada con exito");
        }

        public bool TomarValidacion(string validacion, string respuesta)
        {
            foreach (ValidacionEntity v in validaciones)
            {
                if (v.Nombre == validacion)
                {
                    return llamadaActual.ValidarInfoCliente(respuesta, v);
                }
            }
            return false;
        }
    }
}

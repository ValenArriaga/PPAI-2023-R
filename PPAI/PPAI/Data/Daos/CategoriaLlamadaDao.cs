using PPAI.Data.InterfacesDaos;
using PPAI.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPav1.Datos;

namespace PPAI.Data.Daos
{
    class CategoriaLlamadaDao : ICategoriaLlamadaDao
    {
        public CategoriaLlamadaEntity GetCategoriaLlamadaByid(int id)
        {
            CategoriaLlamadaEntity oCategoriaLlamada = new CategoriaLlamadaEntity();
            string consulta = "SELECT * FROM CategoriaLlamada WHERE id =" + id;
            OpcionLlamadaDao oldao = new OpcionLlamadaDao(); 
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (tabla.Rows.Count > 0)
            {
                oCategoriaLlamada.AudioMensajeOpciones = tabla.Rows[0]["audioMensajeOpciones"].ToString();
                oCategoriaLlamada.MensajeOpciones = tabla.Rows[0]["mensajeOpciones"].ToString();
                oCategoriaLlamada.Nombre = tabla.Rows[0]["nombre"].ToString();
                oCategoriaLlamada.NroOrden = Int32.Parse(tabla.Rows[0]["nroOrden"].ToString());
                oCategoriaLlamada.Id = Int32.Parse(tabla.Rows[0]["id"].ToString());
                oCategoriaLlamada.Opcion = oldao.GetOpcionByCategoriaId(oCategoriaLlamada.Id); 

            }
            return oCategoriaLlamada;
        }
    }
}

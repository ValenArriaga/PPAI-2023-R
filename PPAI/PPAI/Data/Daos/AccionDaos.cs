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
    class AccionDaos : IAccionDaos
    {
        public AccionEntity getAccionById(int id)
        {
            AccionEntity oAccion = new AccionEntity();
            string consulta = "SELECT * FROM Validacion WHERE id =" + id;

            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            if (tabla.Rows.Count > 0)
            {
                oAccion.Descripcion = tabla.Rows[0]["descripcion"].ToString();
                oAccion.Id = Int32.Parse(tabla.Rows[0]["id"].ToString());
            }
            return oAccion;
        }
    }
}

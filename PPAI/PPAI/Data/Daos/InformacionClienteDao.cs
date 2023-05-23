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
    public class InformacionClienteDao : IInformacionClienteDao
    {
        public List<InformacionClienteEntity> GetInformacionClienteById(int ID)
        {
            List<InformacionClienteEntity> lista = new List<InformacionClienteEntity>();
            string consulta = "Select * from InformacionCliente where idCliente = " + ID;
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            OpcionValidacionDao ovdao = new OpcionValidacionDao();
            ValidacionDao vdao = new ValidacionDao();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    InformacionClienteEntity info = new InformacionClienteEntity();
                    info.DatoAValidar = fila["datoAValidar"].ToString();
                    info.Tipo = fila["tipo"].ToString();
                    info.OpcionCorrecta = ovdao.GetOpcionValidacionById((int)fila["idOpcionCorrecta"]);
                    info.Validacion = vdao.GetValidacionById((int)fila["idValidacion"]);
                    info.Id = Int32.Parse(tabla.Rows[0]["id"].ToString());
                    lista.Add(info);

                }
            }
            return lista;
        }
    }
}

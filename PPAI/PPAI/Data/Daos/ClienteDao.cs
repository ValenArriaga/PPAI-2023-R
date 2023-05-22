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
    class ClienteDao
    {
        public ClienteEntity GetById(int id)
        {
            ClienteEntity oCliente = new ClienteEntity();
            string consulta = "Select * from Clientes where id = " + id;
            DataTable tabla = BDHelper.ObtenerInstancia().Consultar(consulta);
            InformacionClienteDao icdao = new InformacionClienteDao();
            if (tabla.Rows.Count > 0)
            {
                oCliente.Dni = tabla.Rows[0]["dni"].ToString();
                oCliente.NombreCompleto = tabla.Rows[0]["apellido"].ToString() + ", " + tabla.Rows[0]["nombre"].ToString();
                oCliente.NroCelular = tabla.Rows[0]["nroCelular"].ToString();
                oCliente.Info = icdao.GetInformacionByClienteID((int)tabla.Rows[0]["id"]);
                oCliente.Id = Int32.Parse(tabla.Rows[0]["id"].ToString());

            }
            return oCliente;
        }
    }
}

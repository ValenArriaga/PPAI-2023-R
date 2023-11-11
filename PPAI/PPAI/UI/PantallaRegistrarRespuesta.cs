using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI.Data.Daos;
using PPAI.Data.InterfacesDaos;
using PPAI.Services;

namespace PPAI.UI
{
    public partial class PantallaRegistrarRespuesta : Form
    {
        ControladorRegistrarRespuesta controlador = new ControladorRegistrarRespuesta();
        IAccionDao accionD = new AccionDao();
        ILlamadaDao llamadaD = new LlamadaDao();

        public PantallaRegistrarRespuesta()
        {
            InitializeComponent();
        }

        private void PantallaRegistrarRespuesta_Load(object sender, EventArgs e)
        {
            CargarComboAcciones();
            cboAcciones.Enabled = false;
            int idLlamada = llamadaD.NuevaLlamada();
            controlador.NuevaRtaOperador(idLlamada, 1, this);
            controlador.BuscarDatosLlamada();
        }

        internal void MostrarDatosLlamada(string nombreCliente, string categoria, string opcion, string subopcion)
        {
            txtCliente.Text = nombreCliente;
            txtCategoria.Text = categoria;
            txtOpcion.Text = opcion;
            txtSubOpcion.Text = subopcion;
        }

        internal void MostrarValidaciones(List<string> validaciones)
        {
            dgvValidaciones.Rows.Clear();
            foreach (string val in validaciones)
            {
                dgvValidaciones.Rows.Add(val, "");
            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Ok();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void CargarComboAcciones()
        {
            cboAcciones.DataSource = accionD.GetAll();
            cboAcciones.DisplayMember = "Descripcion";
            cboAcciones.ValueMember = "Id";
            cboAcciones.SelectedIndex = -1;
            cboAcciones.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Confirmar()
        {
            bool flag = true;
            foreach (DataGridViewRow fila in dgvValidaciones.Rows)
            {
                if (!controlador.TomarValidacion(fila.Cells["Validaciones"].Value.ToString(), fila.Cells["Respuestas"].Value.ToString()))
                {
                    MessageBox.Show(fila.Cells["Validaciones"].Value.ToString() + " es incorrecta!!");
                    flag = false;
                }
            }
            if (flag)
            {
                dgvValidaciones.Enabled = false;
                txtRespuestaOperador.Enabled = true;
                cboAcciones.Enabled = true;
            }
        }

        private void Ok()
        {
            if (MessageBox.Show("Desea confirmar la operacion realizada?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.TomarRtaYConfirmacion(txtRespuestaOperador.Text, cboAcciones.SelectedItem.ToString());
                this.Close();
            }
        }

        private void Cancel()
        {
            if (MessageBox.Show("Esta seguro que desea cancelar la operacion?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.CancelarLlamada();
                this.Close();
            }
        }
    }
}

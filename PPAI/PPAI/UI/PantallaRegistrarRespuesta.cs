using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI.Services;

namespace PPAI.UI
{
    public partial class PantallaRegistrarRespuesta : Form
    {
        ControladorRegistrarRespuesta controlador = new ControladorRegistrarRespuesta();
        public PantallaRegistrarRespuesta()
        {
            InitializeComponent();
        }

        private void PantallaRegistrarRespuesta_Load(object sender, EventArgs e)
        {
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
            foreach (DataGridViewRow fila in dgvValidaciones.Rows)
            {
                if (!controlador.TomarValidacion(fila.Cells[0].ToString(), fila.Cells[1].ToString()))
                    MessageBox.Show("Hay respuestas incorrectas!!");
                else
                {
                    dgvValidaciones.Enabled = false;
                    txtRespuestaOperador.Enabled = true;
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea confirmar la operacion realizada?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.TomarRtaYConfirmacion(txtRespuestaOperador.Text, cboAcciones.SelectedItem.ToString());
            }
        }
    }
}

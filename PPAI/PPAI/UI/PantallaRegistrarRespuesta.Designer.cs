
namespace PPAI.UI
{
    partial class PantallaRegistrarRespuesta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.lblSubopcion = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.validaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.respuestas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRespuestaOperador = new System.Windows.Forms.TextBox();
            this.lblDescripcionOperador = new System.Windows.Forms.Label();
            this.lblAccion = new System.Windows.Forms.Label();
            this.cboAcciones = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(205, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Llamada En Curso";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(17, 65);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(279, 65);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Location = new System.Drawing.Point(15, 108);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(41, 13);
            this.lblOpcion.TabIndex = 3;
            this.lblOpcion.Text = "Opcion";
            // 
            // lblSubopcion
            // 
            this.lblSubopcion.AutoSize = true;
            this.lblSubopcion.Location = new System.Drawing.Point(271, 108);
            this.lblSubopcion.Name = "lblSubopcion";
            this.lblSubopcion.Size = new System.Drawing.Size(60, 13);
            this.lblSubopcion.TabIndex = 4;
            this.lblSubopcion.Text = "SubOpcion";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.validaciones,
            this.respuestas});
            this.dataGridView1.Location = new System.Drawing.Point(17, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 105);
            this.dataGridView1.TabIndex = 5;
            // 
            // validaciones
            // 
            this.validaciones.HeaderText = "Validaciones";
            this.validaciones.Name = "validaciones";
            this.validaciones.ReadOnly = true;
            this.validaciones.Width = 300;
            // 
            // respuestas
            // 
            this.respuestas.HeaderText = "Respuestas";
            this.respuestas.Name = "respuestas";
            this.respuestas.Width = 300;
            // 
            // txtRespuestaOperador
            // 
            this.txtRespuestaOperador.Location = new System.Drawing.Point(17, 295);
            this.txtRespuestaOperador.Multiline = true;
            this.txtRespuestaOperador.Name = "txtRespuestaOperador";
            this.txtRespuestaOperador.Size = new System.Drawing.Size(645, 83);
            this.txtRespuestaOperador.TabIndex = 7;
            // 
            // lblDescripcionOperador
            // 
            this.lblDescripcionOperador.AutoSize = true;
            this.lblDescripcionOperador.Location = new System.Drawing.Point(14, 279);
            this.lblDescripcionOperador.Name = "lblDescripcionOperador";
            this.lblDescripcionOperador.Size = new System.Drawing.Size(122, 13);
            this.lblDescripcionOperador.TabIndex = 8;
            this.lblDescripcionOperador.Text = "Respuesta del Operador";
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Location = new System.Drawing.Point(15, 407);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(40, 13);
            this.lblAccion.TabIndex = 9;
            this.lblAccion.Text = "Accion";
            // 
            // cboAcciones
            // 
            this.cboAcciones.FormattingEnabled = true;
            this.cboAcciones.Location = new System.Drawing.Point(69, 404);
            this.cboAcciones.Name = "cboAcciones";
            this.cboAcciones.Size = new System.Drawing.Size(178, 21);
            this.cboAcciones.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(553, 456);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(395, 456);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(109, 23);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(58, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(337, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(192, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(58, 105);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(192, 20);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(337, 105);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(192, 20);
            this.textBox5.TabIndex = 16;
            // 
            // PantallaRegistrarRespuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 512);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cboAcciones);
            this.Controls.Add(this.lblAccion);
            this.Controls.Add(this.lblDescripcionOperador);
            this.Controls.Add(this.txtRespuestaOperador);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblSubopcion);
            this.Controls.Add(this.lblOpcion);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblTitulo);
            this.Name = "PantallaRegistrarRespuesta";
            this.Text = "PantallaRegistrarRespuesta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.Label lblSubopcion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn validaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn respuestas;
        private System.Windows.Forms.TextBox txtRespuestaOperador;
        private System.Windows.Forms.Label lblDescripcionOperador;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.ComboBox cboAcciones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}
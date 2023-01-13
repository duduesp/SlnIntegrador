namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridMostrarMedicos = new System.Windows.Forms.DataGridView();
            this.gridMostrarPacientes = new System.Windows.Forms.DataGridView();
            this.listBoxMedicosClinicos = new System.Windows.Forms.ListBox();
            this.listBoxHabitaciones = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridMostrarMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMostrarPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMostrarMedicos
            // 
            this.gridMostrarMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMostrarMedicos.Location = new System.Drawing.Point(12, 12);
            this.gridMostrarMedicos.Name = "gridMostrarMedicos";
            this.gridMostrarMedicos.Size = new System.Drawing.Size(776, 163);
            this.gridMostrarMedicos.TabIndex = 0;
            // 
            // gridMostrarPacientes
            // 
            this.gridMostrarPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMostrarPacientes.Location = new System.Drawing.Point(12, 193);
            this.gridMostrarPacientes.Name = "gridMostrarPacientes";
            this.gridMostrarPacientes.Size = new System.Drawing.Size(776, 136);
            this.gridMostrarPacientes.TabIndex = 1;
            // 
            // listBoxMedicosClinicos
            // 
            this.listBoxMedicosClinicos.FormattingEnabled = true;
            this.listBoxMedicosClinicos.Location = new System.Drawing.Point(12, 344);
            this.listBoxMedicosClinicos.Name = "listBoxMedicosClinicos";
            this.listBoxMedicosClinicos.Size = new System.Drawing.Size(371, 56);
            this.listBoxMedicosClinicos.TabIndex = 2;
            // 
            // listBoxHabitaciones
            // 
            this.listBoxHabitaciones.FormattingEnabled = true;
            this.listBoxHabitaciones.Location = new System.Drawing.Point(407, 344);
            this.listBoxHabitaciones.Name = "listBoxHabitaciones";
            this.listBoxHabitaciones.Size = new System.Drawing.Size(381, 56);
            this.listBoxHabitaciones.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxHabitaciones);
            this.Controls.Add(this.listBoxMedicosClinicos);
            this.Controls.Add(this.gridMostrarPacientes);
            this.Controls.Add(this.gridMostrarMedicos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMostrarMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMostrarPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMostrarMedicos;
        private System.Windows.Forms.DataGridView gridMostrarPacientes;
        private System.Windows.Forms.ListBox listBoxMedicosClinicos;
        private System.Windows.Forms.ListBox listBoxHabitaciones;
    }
}


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
            this.GridMostrarMedicos = new System.Windows.Forms.DataGridView();
            this.GridMostrarPacientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridMostrarMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridMostrarPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // GridMostrarMedicos
            // 
            this.GridMostrarMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMostrarMedicos.Location = new System.Drawing.Point(12, 12);
            this.GridMostrarMedicos.Name = "GridMostrarMedicos";
            this.GridMostrarMedicos.Size = new System.Drawing.Size(776, 193);
            this.GridMostrarMedicos.TabIndex = 0;
            // 
            // GridMostrarPacientes
            // 
            this.GridMostrarPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMostrarPacientes.Location = new System.Drawing.Point(12, 232);
            this.GridMostrarPacientes.Name = "GridMostrarPacientes";
            this.GridMostrarPacientes.Size = new System.Drawing.Size(776, 206);
            this.GridMostrarPacientes.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridMostrarPacientes);
            this.Controls.Add(this.GridMostrarMedicos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridMostrarMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridMostrarPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridMostrarMedicos;
        private System.Windows.Forms.DataGridView GridMostrarPacientes;
    }
}


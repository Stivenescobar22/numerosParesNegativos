namespace numerosParesNegativos
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
            this.lblbtitulo = new System.Windows.Forms.Label();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.lsbnegativos = new System.Windows.Forms.ListBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lblmensaje2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblbtitulo
            // 
            this.lblbtitulo.AutoSize = true;
            this.lblbtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbtitulo.Location = new System.Drawing.Point(28, 9);
            this.lblbtitulo.Name = "lblbtitulo";
            this.lblbtitulo.Size = new System.Drawing.Size(210, 20);
            this.lblbtitulo.TabIndex = 0;
            this.lblbtitulo.Text = "numeros pares negativos";
            // 
            // btnmostrar
            // 
            this.btnmostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrar.Location = new System.Drawing.Point(84, 112);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 1;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(39, 64);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(180, 16);
            this.lblmensaje.TabIndex = 2;
            this.lblmensaje.Text = "oprima el boton para mostrar";
            // 
            // lsbnegativos
            // 
            this.lsbnegativos.FormattingEnabled = true;
            this.lsbnegativos.Location = new System.Drawing.Point(51, 169);
            this.lsbnegativos.Name = "lsbnegativos";
            this.lsbnegativos.Size = new System.Drawing.Size(90, 147);
            this.lsbnegativos.TabIndex = 3;
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(181, 313);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // lblmensaje2
            // 
            this.lblmensaje2.AutoSize = true;
            this.lblmensaje2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje2.Location = new System.Drawing.Point(12, 80);
            this.lblmensaje2.Name = "lblmensaje2";
            this.lblmensaje2.Size = new System.Drawing.Size(254, 16);
            this.lblmensaje2.TabIndex = 5;
            this.lblmensaje2.Text = "los primeros 20 numeros pares negativos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 348);
            this.Controls.Add(this.lblmensaje2);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lsbnegativos);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.lblbtitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbtitulo;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.ListBox lsbnegativos;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label lblmensaje2;
    }
}


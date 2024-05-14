namespace HerenciaEjercicio1
{
    partial class FormularioJugador
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
            this.btnCapturarDatos = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNumeroUniforme = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMinutosJugados = new System.Windows.Forms.TextBox();
            this.txtGolesAnotados = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkMedio = new System.Windows.Forms.CheckBox();
            this.checkDelantero = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkDefensa = new System.Windows.Forms.CheckBox();
            this.checkPortero = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCapturarDatos
            // 
            this.btnCapturarDatos.Location = new System.Drawing.Point(235, 24);
            this.btnCapturarDatos.Name = "btnCapturarDatos";
            this.btnCapturarDatos.Size = new System.Drawing.Size(149, 23);
            this.btnCapturarDatos.TabIndex = 0;
            this.btnCapturarDatos.Text = "Captura datos";
            this.btnCapturarDatos.UseVisualStyleBackColor = true;
            this.btnCapturarDatos.Click += new System.EventHandler(this.btnCapturarDatos_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(235, 73);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(149, 23);
            this.btnMostrarDatos.TabIndex = 1;
            this.btnMostrarDatos.Text = "Mostrar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(235, 126);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(149, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtNumeroUniforme
            // 
            this.txtNumeroUniforme.Location = new System.Drawing.Point(104, 31);
            this.txtNumeroUniforme.Name = "txtNumeroUniforme";
            this.txtNumeroUniforme.Size = new System.Drawing.Size(100, 22);
            this.txtNumeroUniforme.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(68, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 7;
            // 
            // txtMinutosJugados
            // 
            this.txtMinutosJugados.Location = new System.Drawing.Point(103, 102);
            this.txtMinutosJugados.Name = "txtMinutosJugados";
            this.txtMinutosJugados.Size = new System.Drawing.Size(100, 22);
            this.txtMinutosJugados.TabIndex = 8;
            // 
            // txtGolesAnotados
            // 
            this.txtGolesAnotados.Location = new System.Drawing.Point(115, 130);
            this.txtGolesAnotados.Name = "txtGolesAnotados";
            this.txtGolesAnotados.Size = new System.Drawing.Size(100, 22);
            this.txtGolesAnotados.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Num. uniforme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Min.Jugados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Goles anotados";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGolesAnotados);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNumeroUniforme);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMinutosJugados);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(18, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 167);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del jugador";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkMedio
            // 
            this.checkMedio.AutoSize = true;
            this.checkMedio.Location = new System.Drawing.Point(22, 85);
            this.checkMedio.Name = "checkMedio";
            this.checkMedio.Size = new System.Drawing.Size(67, 20);
            this.checkMedio.TabIndex = 16;
            this.checkMedio.Text = "Medio";
            this.checkMedio.UseVisualStyleBackColor = true;
            this.checkMedio.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkDelantero
            // 
            this.checkDelantero.AutoSize = true;
            this.checkDelantero.Location = new System.Drawing.Point(22, 111);
            this.checkDelantero.Name = "checkDelantero";
            this.checkDelantero.Size = new System.Drawing.Size(88, 20);
            this.checkDelantero.TabIndex = 17;
            this.checkDelantero.Text = "Delantero";
            this.checkDelantero.UseVisualStyleBackColor = true;
            this.checkDelantero.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkDefensa);
            this.groupBox2.Controls.Add(this.checkPortero);
            this.groupBox2.Controls.Add(this.checkDelantero);
            this.groupBox2.Controls.Add(this.checkMedio);
            this.groupBox2.Location = new System.Drawing.Point(21, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 159);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Posicion del jugador";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // checkDefensa
            // 
            this.checkDefensa.AutoSize = true;
            this.checkDefensa.Location = new System.Drawing.Point(22, 59);
            this.checkDefensa.Name = "checkDefensa";
            this.checkDefensa.Size = new System.Drawing.Size(80, 20);
            this.checkDefensa.TabIndex = 19;
            this.checkDefensa.Text = "Defensa";
            this.checkDefensa.UseVisualStyleBackColor = true;
            this.checkDefensa.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkPortero
            // 
            this.checkPortero.AutoSize = true;
            this.checkPortero.Location = new System.Drawing.Point(22, 33);
            this.checkPortero.Name = "checkPortero";
            this.checkPortero.Size = new System.Drawing.Size(73, 20);
            this.checkPortero.TabIndex = 18;
            this.checkPortero.Text = "Portero";
            this.checkPortero.UseVisualStyleBackColor = true;
            this.checkPortero.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(320, 179);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(255, 228);
            this.listBox1.TabIndex = 19;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // FormularioJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnCapturarDatos);
            this.Name = "FormularioJugador";
            this.Text = "Equipo de Futobol";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCapturarDatos;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNumeroUniforme;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMinutosJugados;
        private System.Windows.Forms.TextBox txtGolesAnotados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkMedio;
        private System.Windows.Forms.CheckBox checkDelantero;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox checkDefensa;
        private System.Windows.Forms.CheckBox checkPortero;
    }
}


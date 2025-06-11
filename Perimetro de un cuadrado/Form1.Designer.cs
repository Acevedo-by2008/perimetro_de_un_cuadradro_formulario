namespace Perimetro_de_un_cuadrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbLados = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.lblLado = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnperimetro = new System.Windows.Forms.Button();
            this.gbLados.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLados
            // 
            this.gbLados.Controls.Add(this.lblLado);
            this.gbLados.Controls.Add(this.txtLado);
            this.gbLados.Location = new System.Drawing.Point(131, 74);
            this.gbLados.Name = "gbLados";
            this.gbLados.Size = new System.Drawing.Size(475, 150);
            this.gbLados.TabIndex = 0;
            this.gbLados.TabStop = false;
            this.gbLados.Text = "Datos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnperimetro);
            this.groupBox2.Controls.Add(this.lblPerimetro);
            this.groupBox2.Controls.Add(this.txtPerimetro);
            this.groupBox2.Location = new System.Drawing.Point(109, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Respuesta ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(109, 61);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(102, 20);
            this.txtPerimetro.TabIndex = 0;
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(204, 61);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(211, 20);
            this.txtLado.TabIndex = 1;
            this.txtLado.TextChanged += new System.EventHandler(this.txtLado_TextChanged);
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(6, 61);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(161, 13);
            this.lblLado.TabIndex = 2;
            this.lblLado.Text = "Ingrese el Lado de su Cuadrado:";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(38, 64);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(54, 13);
            this.lblPerimetro.TabIndex = 1;
            this.lblPerimetro.Text = "Perimetro:";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Perimetro_de_un_cuadrado.Properties.Resources.emergencyexit_87228__1_;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(402, 94);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(83, 54);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = global::Perimetro_de_un_cuadrado.Properties.Resources.magic_broom_halloween_icon_155987;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(402, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 58);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Limpiar";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnperimetro
            // 
            this.btnperimetro.Image = global::Perimetro_de_un_cuadrado.Properties.Resources.calculator_3534;
            this.btnperimetro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnperimetro.Location = new System.Drawing.Point(245, 42);
            this.btnperimetro.Name = "btnperimetro";
            this.btnperimetro.Size = new System.Drawing.Size(133, 57);
            this.btnperimetro.TabIndex = 2;
            this.btnperimetro.Text = "Calcular Perimetro";
            this.btnperimetro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnperimetro.UseVisualStyleBackColor = true;
            this.btnperimetro.Click += new System.EventHandler(this.btnperimetro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbLados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbLados.ResumeLayout(false);
            this.gbLados.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnperimetro;
    }
}


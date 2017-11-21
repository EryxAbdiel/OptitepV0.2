namespace WindowsFormsApp1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.LUsuario = new System.Windows.Forms.Label();
            this.LContra = new System.Windows.Forms.Label();
            this.bEntrar = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(61, 183);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(145, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(61, 272);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(145, 20);
            this.txtContra.TabIndex = 2;
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LUsuario.Location = new System.Drawing.Point(67, 153);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(61, 17);
            this.LUsuario.TabIndex = 3;
            this.LUsuario.Text = "Usuario:";
            // 
            // LContra
            // 
            this.LContra.AutoSize = true;
            this.LContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LContra.Location = new System.Drawing.Point(67, 238);
            this.LContra.Name = "LContra";
            this.LContra.Size = new System.Drawing.Size(85, 17);
            this.LContra.TabIndex = 4;
            this.LContra.Text = "Contraseña:";
            // 
            // bEntrar
            // 
            this.bEntrar.Location = new System.Drawing.Point(50, 320);
            this.bEntrar.Name = "bEntrar";
            this.bEntrar.Size = new System.Drawing.Size(78, 31);
            this.bEntrar.TabIndex = 5;
            this.bEntrar.Text = "Entrar";
            this.bEntrar.UseVisualStyleBackColor = true;
            this.bEntrar.Click += new System.EventHandler(this.bEntrar_Click);
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(159, 320);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(78, 31);
            this.bSalir.TabIndex = 6;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 64);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(636, 515);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bEntrar);
            this.Controls.Add(this.LContra);
            this.Controls.Add(this.LUsuario);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.Label LContra;
        private System.Windows.Forms.Button bEntrar;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Panel panel1;
    }
}


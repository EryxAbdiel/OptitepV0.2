namespace WindowsFormsApp1
{
    partial class Formato
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.bPLector = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.bPLector);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 88);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(215, 445);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // bPLector
            // 
            this.bPLector.Location = new System.Drawing.Point(3, 3);
            this.bPLector.Name = "bPLector";
            this.bPLector.Size = new System.Drawing.Size(121, 23);
            this.bPLector.TabIndex = 0;
            this.bPLector.Text = "Lector Prueba";
            this.bPLector.UseVisualStyleBackColor = true;
            this.bPLector.Click += new System.EventHandler(this.bPLector_Click);
            // 
            // Formato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 558);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "Formato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formato";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button bPLector;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
namespace PFProgra
{
    partial class Opciones
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
            this.btnST = new System.Windows.Forms.Button();
            this.btnHR = new System.Windows.Forms.Button();
            this.btnNR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnregistro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnST
            // 
            this.btnST.Location = new System.Drawing.Point(99, 256);
            this.btnST.Name = "btnST";
            this.btnST.Size = new System.Drawing.Size(159, 92);
            this.btnST.TabIndex = 0;
            this.btnST.Text = "Servicio de Transporte";
            this.btnST.UseVisualStyleBackColor = true;
            this.btnST.Click += new System.EventHandler(this.btnST_Click);
            // 
            // btnHR
            // 
            this.btnHR.Location = new System.Drawing.Point(311, 256);
            this.btnHR.Name = "btnHR";
            this.btnHR.Size = new System.Drawing.Size(159, 92);
            this.btnHR.TabIndex = 1;
            this.btnHR.Text = "Historial de Rutas";
            this.btnHR.UseVisualStyleBackColor = true;
            this.btnHR.Click += new System.EventHandler(this.btnHR_Click);
            // 
            // btnNR
            // 
            this.btnNR.Location = new System.Drawing.Point(532, 256);
            this.btnNR.Name = "btnNR";
            this.btnNR.Size = new System.Drawing.Size(159, 92);
            this.btnNR.TabIndex = 2;
            this.btnNR.Text = "Nuevo Registro";
            this.btnNR.UseVisualStyleBackColor = true;
            this.btnNR.Click += new System.EventHandler(this.btnNR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione una opción";
            // 
            // btnregistro
            // 
            this.btnregistro.Location = new System.Drawing.Point(311, 121);
            this.btnregistro.Name = "btnregistro";
            this.btnregistro.Size = new System.Drawing.Size(159, 92);
            this.btnregistro.TabIndex = 4;
            this.btnregistro.Text = "Registro";
            this.btnregistro.UseVisualStyleBackColor = true;
            this.btnregistro.Click += new System.EventHandler(this.btnregistro_Click);
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnregistro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNR);
            this.Controls.Add(this.btnHR);
            this.Controls.Add(this.btnST);
            this.Name = "Opciones";
            this.Text = "Opciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnST;
        private System.Windows.Forms.Button btnHR;
        private System.Windows.Forms.Button btnNR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnregistro;
    }
}
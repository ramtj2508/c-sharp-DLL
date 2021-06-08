namespace PantallaPrincipal
{
    partial class Actualizar
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
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpalabra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btningresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(217, 233);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(100, 22);
            this.txtcontraseña.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Contraseña";
            // 
            // txtpalabra
            // 
            this.txtpalabra.Location = new System.Drawing.Point(217, 143);
            this.txtpalabra.Name = "txtpalabra";
            this.txtpalabra.Size = new System.Drawing.Size(100, 22);
            this.txtpalabra.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Palabra clave:";
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(396, 143);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(97, 31);
            this.btningresar.TabIndex = 10;
            this.btningresar.Text = "Aceptar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpalabra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btningresar);
            this.Name = "Actualizar";
            this.Text = "Actualizar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpalabra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btningresar;
    }
}
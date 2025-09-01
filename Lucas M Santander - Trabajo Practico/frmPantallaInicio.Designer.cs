namespace Lucas_M_Santander___Trabajo_Practico
{
    partial class frmPantallaInicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProgramador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUSCAMINAS";
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.Location = new System.Drawing.Point(302, 211);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(144, 49);
            this.btnEmpezar.TabIndex = 1;
            this.btnEmpezar.Text = "EMPEZAR";
            this.btnEmpezar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Creditos:";
            // 
            // lblProgramador
            // 
            this.lblProgramador.AutoSize = true;
            this.lblProgramador.Location = new System.Drawing.Point(66, 428);
            this.lblProgramador.Name = "lblProgramador";
            this.lblProgramador.Size = new System.Drawing.Size(124, 13);
            this.lblProgramador.TabIndex = 3;
            this.lblProgramador.Text = "Lucas Matías Santander";
            // 
            // frmPantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblProgramador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEmpezar);
            this.Controls.Add(this.label1);
            this.Name = "frmPantallaInicio";
            this.Text = "Buscaminas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProgramador;
    }
}


namespace GeneradorVerificadorCodigo
{
    partial class Form1
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
            this.txtGenerador = new System.Windows.Forms.TextBox();
            this.txtVerificador = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lbControl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGenerador
            // 
            this.txtGenerador.Location = new System.Drawing.Point(76, 94);
            this.txtGenerador.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenerador.Name = "txtGenerador";
            this.txtGenerador.Size = new System.Drawing.Size(148, 22);
            this.txtGenerador.TabIndex = 0;
            // 
            // txtVerificador
            // 
            this.txtVerificador.Location = new System.Drawing.Point(76, 214);
            this.txtVerificador.Margin = new System.Windows.Forms.Padding(4);
            this.txtVerificador.Name = "txtVerificador";
            this.txtVerificador.Size = new System.Drawing.Size(148, 22);
            this.txtVerificador.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(382, 94);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(124, 50);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar Codigo";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(382, 194);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(124, 44);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "Verificar Codigo";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbControl
            // 
            this.lbControl.AutoSize = true;
            this.lbControl.Location = new System.Drawing.Point(76, 42);
            this.lbControl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbControl.Name = "lbControl";
            this.lbControl.Size = new System.Drawing.Size(289, 16);
            this.lbControl.TabIndex = 4;
            this.lbControl.Text = "Vector de control: { 9, 8, 7, 6, 5, 4, 3, 2, 1 }";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Generar Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Verificar Codigo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 304);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbControl);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtVerificador);
            this.Controls.Add(this.txtGenerador);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGenerador;
        private System.Windows.Forms.TextBox txtVerificador;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lbControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


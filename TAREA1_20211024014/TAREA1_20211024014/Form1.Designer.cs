namespace TAREA1_20211024014
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NUmero_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CALCULO_button = new System.Windows.Forms.Button();
            this.ResultadoPoN_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RESULTADO_PoI_textBox = new System.Windows.Forms.TextBox();
            this.Numero_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Numero_errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(787, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESE UN NUMERO PARA SABER SI ES PAR O IMPAR Y PARA SABER SI ES NEGATIVO O POSI" +
    "TIVO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Underline);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(31, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESE EL NUMERO DESEADO:";
            // 
            // NUmero_textBox
            // 
            this.NUmero_textBox.Font = new System.Drawing.Font("Georgia", 11F);
            this.NUmero_textBox.Location = new System.Drawing.Point(346, 74);
            this.NUmero_textBox.Name = "NUmero_textBox";
            this.NUmero_textBox.Size = new System.Drawing.Size(275, 24);
            this.NUmero_textBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Underline);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(31, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "EL NUMERO INGRESADO:  ";
            // 
            // CALCULO_button
            // 
            this.CALCULO_button.Font = new System.Drawing.Font("Georgia", 11F);
            this.CALCULO_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CALCULO_button.Location = new System.Drawing.Point(368, 132);
            this.CALCULO_button.Name = "CALCULO_button";
            this.CALCULO_button.Size = new System.Drawing.Size(236, 24);
            this.CALCULO_button.TabIndex = 5;
            this.CALCULO_button.Text = "CALCULAR";
            this.CALCULO_button.UseVisualStyleBackColor = true;
            this.CALCULO_button.Click += new System.EventHandler(this.CALCULO_button_Click);
            // 
            // ResultadoPoN_textBox
            // 
            this.ResultadoPoN_textBox.Font = new System.Drawing.Font("Georgia", 11F);
            this.ResultadoPoN_textBox.Location = new System.Drawing.Point(346, 191);
            this.ResultadoPoN_textBox.Name = "ResultadoPoN_textBox";
            this.ResultadoPoN_textBox.Size = new System.Drawing.Size(275, 24);
            this.ResultadoPoN_textBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Underline);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(31, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "EL NUMERO INGRESADO: ";
            // 
            // RESULTADO_PoI_textBox
            // 
            this.RESULTADO_PoI_textBox.Font = new System.Drawing.Font("Georgia", 11F);
            this.RESULTADO_PoI_textBox.Location = new System.Drawing.Point(346, 264);
            this.RESULTADO_PoI_textBox.Name = "RESULTADO_PoI_textBox";
            this.RESULTADO_PoI_textBox.Size = new System.Drawing.Size(275, 24);
            this.RESULTADO_PoI_textBox.TabIndex = 9;
            // 
            // Numero_errorProvider
            // 
            this.Numero_errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RESULTADO_PoI_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ResultadoPoN_textBox);
            this.Controls.Add(this.CALCULO_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NUmero_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Numero_errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NUmero_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CALCULO_button;
        private System.Windows.Forms.TextBox ResultadoPoN_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RESULTADO_PoI_textBox;
        private System.Windows.Forms.ErrorProvider Numero_errorProvider;
    }
}


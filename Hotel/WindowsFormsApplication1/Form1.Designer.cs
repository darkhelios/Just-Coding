namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numeroCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.precioTxt = new System.Windows.Forms.TextBox();
            this.calcularBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de dias";
            // 
            // numeroCb
            // 
            this.numeroCb.FormattingEnabled = true;
            this.numeroCb.Location = new System.Drawing.Point(126, 22);
            this.numeroCb.Name = "numeroCb";
            this.numeroCb.Size = new System.Drawing.Size(135, 21);
            this.numeroCb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio diario";
            // 
            // precioTxt
            // 
            this.precioTxt.Location = new System.Drawing.Point(126, 59);
            this.precioTxt.Name = "precioTxt";
            this.precioTxt.Size = new System.Drawing.Size(135, 20);
            this.precioTxt.TabIndex = 3;
            // 
            // calcularBtn
            // 
            this.calcularBtn.Location = new System.Drawing.Point(126, 104);
            this.calcularBtn.Name = "calcularBtn";
            this.calcularBtn.Size = new System.Drawing.Size(135, 23);
            this.calcularBtn.TabIndex = 4;
            this.calcularBtn.Text = "Calcular";
            this.calcularBtn.UseVisualStyleBackColor = true;
            this.calcularBtn.Click += new System.EventHandler(this.calcularBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 148);
            this.Controls.Add(this.calcularBtn);
            this.Controls.Add(this.precioTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeroCb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hotel Gandariwi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox numeroCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox precioTxt;
        private System.Windows.Forms.Button calcularBtn;
    }
}


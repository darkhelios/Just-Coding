namespace pasteleria
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.cbFoto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDecoracion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMenu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbInvitados = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mcCalendario = new System.Windows.Forms.MonthCalendar();
            this.cbEvento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btnEnviar);
            this.groupBox.Controls.Add(this.cbFoto);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.cbDecoracion);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.cbMenu);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.tbInvitados);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.mcCalendario);
            this.groupBox.Controls.Add(this.cbEvento);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.tbNombre);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Location = new System.Drawing.Point(24, 20);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(611, 463);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Eventos Felices";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(273, 418);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 14;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // cbFoto
            // 
            this.cbFoto.FormattingEnabled = true;
            this.cbFoto.Location = new System.Drawing.Point(95, 356);
            this.cbFoto.Name = "cbFoto";
            this.cbFoto.Size = new System.Drawing.Size(125, 21);
            this.cbFoto.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fotografia";
            // 
            // cbDecoracion
            // 
            this.cbDecoracion.FormattingEnabled = true;
            this.cbDecoracion.Location = new System.Drawing.Point(95, 328);
            this.cbDecoracion.Name = "cbDecoracion";
            this.cbDecoracion.Size = new System.Drawing.Size(125, 21);
            this.cbDecoracion.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Decoracion";
            // 
            // cbMenu
            // 
            this.cbMenu.FormattingEnabled = true;
            this.cbMenu.Location = new System.Drawing.Point(95, 299);
            this.cbMenu.Name = "cbMenu";
            this.cbMenu.Size = new System.Drawing.Size(125, 21);
            this.cbMenu.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo de Menu";
            // 
            // tbInvitados
            // 
            this.tbInvitados.Location = new System.Drawing.Point(95, 270);
            this.tbInvitados.Name = "tbInvitados";
            this.tbInvitados.Size = new System.Drawing.Size(77, 20);
            this.tbInvitados.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "No. de Invitados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de Evento";
            // 
            // mcCalendario
            // 
            this.mcCalendario.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.mcCalendario.Location = new System.Drawing.Point(95, 94);
            this.mcCalendario.MaxSelectionCount = 1;
            this.mcCalendario.Name = "mcCalendario";
            this.mcCalendario.TabIndex = 4;
            // 
            // cbEvento
            // 
            this.cbEvento.FormattingEnabled = true;
            this.cbEvento.Location = new System.Drawing.Point(95, 50);
            this.cbEvento.Name = "cbEvento";
            this.cbEvento.Size = new System.Drawing.Size(162, 21);
            this.cbEvento.TabIndex = 3;
            this.cbEvento.SelectedIndexChanged += new System.EventHandler(this.cbEvento_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Evento";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(95, 22);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(162, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 495);
            this.Controls.Add(this.groupBox);
            this.Name = "Form1";
            this.Text = "Registro de Evento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ComboBox cbFoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDecoracion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbInvitados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar mcCalendario;
        private System.Windows.Forms.ComboBox cbEvento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label1;
    }
}


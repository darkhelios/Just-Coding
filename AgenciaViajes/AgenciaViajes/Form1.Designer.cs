namespace AgenciaViajes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enviarBtn = new System.Windows.Forms.Button();
            this.niñosCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.adultosCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.camasCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cuartosCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fechas = new System.Windows.Forms.MonthCalendar();
            this.hotelCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.destinoCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enviarBtn);
            this.groupBox1.Controls.Add(this.niñosCb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.adultosCb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.camasCb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cuartosCb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fechas);
            this.groupBox1.Controls.Add(this.hotelCb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.destinoCb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservación";
            // 
            // enviarBtn
            // 
            this.enviarBtn.Location = new System.Drawing.Point(128, 364);
            this.enviarBtn.Name = "enviarBtn";
            this.enviarBtn.Size = new System.Drawing.Size(75, 23);
            this.enviarBtn.TabIndex = 13;
            this.enviarBtn.Text = "Enviar";
            this.enviarBtn.UseVisualStyleBackColor = true;
            this.enviarBtn.Click += new System.EventHandler(this.enviarBtn_Click);
            // 
            // niñosCb
            // 
            this.niñosCb.FormattingEnabled = true;
            this.niñosCb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.niñosCb.Location = new System.Drawing.Point(128, 326);
            this.niñosCb.Name = "niñosCb";
            this.niñosCb.Size = new System.Drawing.Size(63, 21);
            this.niñosCb.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Numero de niños:";
            // 
            // adultosCb
            // 
            this.adultosCb.FormattingEnabled = true;
            this.adultosCb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.adultosCb.Location = new System.Drawing.Point(128, 299);
            this.adultosCb.Name = "adultosCb";
            this.adultosCb.Size = new System.Drawing.Size(63, 21);
            this.adultosCb.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Numero de adultos:";
            // 
            // camasCb
            // 
            this.camasCb.FormattingEnabled = true;
            this.camasCb.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.camasCb.Location = new System.Drawing.Point(128, 272);
            this.camasCb.Name = "camasCb";
            this.camasCb.Size = new System.Drawing.Size(63, 21);
            this.camasCb.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad de camas:";
            // 
            // cuartosCb
            // 
            this.cuartosCb.FormattingEnabled = true;
            this.cuartosCb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cuartosCb.Location = new System.Drawing.Point(128, 245);
            this.cuartosCb.Name = "cuartosCb";
            this.cuartosCb.Size = new System.Drawing.Size(63, 21);
            this.cuartosCb.TabIndex = 6;
            this.cuartosCb.SelectedIndexChanged += new System.EventHandler(this.cuartosCb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad de cuartos:";
            // 
            // fechas
            // 
            this.fechas.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.fechas.Location = new System.Drawing.Point(10, 77);
            this.fechas.Name = "fechas";
            this.fechas.TabIndex = 4;
            // 
            // hotelCb
            // 
            this.hotelCb.FormattingEnabled = true;
            this.hotelCb.Location = new System.Drawing.Point(59, 44);
            this.hotelCb.Name = "hotelCb";
            this.hotelCb.Size = new System.Drawing.Size(256, 21);
            this.hotelCb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hotel:";
            // 
            // destinoCb
            // 
            this.destinoCb.FormattingEnabled = true;
            this.destinoCb.Location = new System.Drawing.Point(59, 17);
            this.destinoCb.Name = "destinoCb";
            this.destinoCb.Size = new System.Drawing.Size(256, 21);
            this.destinoCb.TabIndex = 1;
            this.destinoCb.SelectedIndexChanged += new System.EventHandler(this.destinoCb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destino:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 441);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Agencia de Viajes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox destinoCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox hotelCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar fechas;
        private System.Windows.Forms.ComboBox cuartosCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox niñosCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox adultosCb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox camasCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button enviarBtn;
    }
}


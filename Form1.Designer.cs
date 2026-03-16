namespace ED_Taller_7
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.txtNumeroDiscos = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.listBoxTorreA = new System.Windows.Forms.ListBox();
            this.listBoxTorreB = new System.Windows.Forms.ListBox();
            this.listBoxTorreC = new System.Windows.Forms.ListBox();
            this.lblMovimientos = new System.Windows.Forms.Label();
            this.lblMovimientosMinimos = new System.Windows.Forms.Label();
            this.btnSeleccionarA = new System.Windows.Forms.Button();
            this.btnSeleccionarB = new System.Windows.Forms.Button();
            this.btnSeleccionarC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumeroDiscos
            // 
            this.txtNumeroDiscos.Location = new System.Drawing.Point(135, 25);
            this.txtNumeroDiscos.Name = "txtNumeroDiscos";
            this.txtNumeroDiscos.Size = new System.Drawing.Size(60, 20);
            this.txtNumeroDiscos.TabIndex = 0;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(210, 23);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(291, 23);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 2;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // listBoxTorreA
            // 
            this.listBoxTorreA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTorreA.FormattingEnabled = true;
            this.listBoxTorreA.ItemHeight = 15;
            this.listBoxTorreA.Location = new System.Drawing.Point(30, 80);
            this.listBoxTorreA.Name = "listBoxTorreA";
            this.listBoxTorreA.Size = new System.Drawing.Size(140, 199);
            this.listBoxTorreA.TabIndex = 3;
            // 
            // listBoxTorreB
            // 
            this.listBoxTorreB.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTorreB.FormattingEnabled = true;
            this.listBoxTorreB.ItemHeight = 15;
            this.listBoxTorreB.Location = new System.Drawing.Point(190, 80);
            this.listBoxTorreB.Name = "listBoxTorreB";
            this.listBoxTorreB.Size = new System.Drawing.Size(140, 199);
            this.listBoxTorreB.TabIndex = 4;
            // 
            // listBoxTorreC
            // 
            this.listBoxTorreC.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTorreC.FormattingEnabled = true;
            this.listBoxTorreC.ItemHeight = 15;
            this.listBoxTorreC.Location = new System.Drawing.Point(350, 80);
            this.listBoxTorreC.Name = "listBoxTorreC";
            this.listBoxTorreC.Size = new System.Drawing.Size(140, 199);
            this.listBoxTorreC.TabIndex = 5;
            // 
            // lblMovimientos
            // 
            this.lblMovimientos.AutoSize = true;
            this.lblMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimientos.Location = new System.Drawing.Point(30, 335);
            this.lblMovimientos.Name = "lblMovimientos";
            this.lblMovimientos.Size = new System.Drawing.Size(114, 16);
            this.lblMovimientos.TabIndex = 6;
            this.lblMovimientos.Text = "Movimientos: 0";
            // 
            // lblMovimientosMinimos
            // 
            this.lblMovimientosMinimos.AutoSize = true;
            this.lblMovimientosMinimos.Location = new System.Drawing.Point(187, 337);
            this.lblMovimientosMinimos.Name = "lblMovimientosMinimos";
            this.lblMovimientosMinimos.Size = new System.Drawing.Size(111, 13);
            this.lblMovimientosMinimos.TabIndex = 7;
            this.lblMovimientosMinimos.Text = "Movimientos Mínimos: 0";
            // 
            // btnSeleccionarA
            // 
            this.btnSeleccionarA.Location = new System.Drawing.Point(30, 285);
            this.btnSeleccionarA.Name = "btnSeleccionarA";
            this.btnSeleccionarA.Size = new System.Drawing.Size(140, 30);
            this.btnSeleccionarA.TabIndex = 8;
            this.btnSeleccionarA.Tag = "0";
            this.btnSeleccionarA.Text = "Seleccionar A";
            this.btnSeleccionarA.UseVisualStyleBackColor = true;
            this.btnSeleccionarA.Click += new System.EventHandler(this.btnSeleccionarTorre_Click);
            // 
            // btnSeleccionarB
            // 
            this.btnSeleccionarB.Location = new System.Drawing.Point(190, 285);
            this.btnSeleccionarB.Name = "btnSeleccionarB";
            this.btnSeleccionarB.Size = new System.Drawing.Size(140, 30);
            this.btnSeleccionarB.TabIndex = 9;
            this.btnSeleccionarB.Tag = "1";
            this.btnSeleccionarB.Text = "Seleccionar B";
            this.btnSeleccionarB.UseVisualStyleBackColor = true;
            this.btnSeleccionarB.Click += new System.EventHandler(this.btnSeleccionarTorre_Click);
            // 
            // btnSeleccionarC
            // 
            this.btnSeleccionarC.Location = new System.Drawing.Point(350, 285);
            this.btnSeleccionarC.Name = "btnSeleccionarC";
            this.btnSeleccionarC.Size = new System.Drawing.Size(140, 30);
            this.btnSeleccionarC.TabIndex = 10;
            this.btnSeleccionarC.Tag = "2";
            this.btnSeleccionarC.Text = "Seleccionar C";
            this.btnSeleccionarC.UseVisualStyleBackColor = true;
            this.btnSeleccionarC.Click += new System.EventHandler(this.btnSeleccionarTorre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Número de Discos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 380);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeleccionarC);
            this.Controls.Add(this.btnSeleccionarB);
            this.Controls.Add(this.btnSeleccionarA);
            this.Controls.Add(this.lblMovimientosMinimos);
            this.Controls.Add(this.lblMovimientos);
            this.Controls.Add(this.listBoxTorreC);
            this.Controls.Add(this.listBoxTorreB);
            this.Controls.Add(this.listBoxTorreA);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtNumeroDiscos);
            this.Name = "Form1";
            this.Text = "Torres de Hanoi - Taller 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroDiscos;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.ListBox listBoxTorreA;
        private System.Windows.Forms.ListBox listBoxTorreB;
        private System.Windows.Forms.ListBox listBoxTorreC;
        private System.Windows.Forms.Label lblMovimientos;
        private System.Windows.Forms.Label lblMovimientosMinimos;
        private System.Windows.Forms.Button btnSeleccionarA;
        private System.Windows.Forms.Button btnSeleccionarB;
        private System.Windows.Forms.Button btnSeleccionarC;
        private System.Windows.Forms.Label label1;
    }
}
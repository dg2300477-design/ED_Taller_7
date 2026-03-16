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
            txtNumeroDiscos = new TextBox();
            btnIniciar = new Button();
            btnReiniciar = new Button();
            listBoxTorreA = new ListBox();
            listBoxTorreB = new ListBox();
            listBoxTorreC = new ListBox();
            lblMovimientos = new Label();
            lblMovimientosMinimos = new Label();
            btnSeleccionarA = new Button();
            btnSeleccionarB = new Button();
            btnSeleccionarC = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNumeroDiscos
            // 
            txtNumeroDiscos.Location = new Point(180, 38);
            txtNumeroDiscos.Margin = new Padding(4, 5, 4, 5);
            txtNumeroDiscos.Name = "txtNumeroDiscos";
            txtNumeroDiscos.Size = new Size(79, 27);
            txtNumeroDiscos.TabIndex = 0;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(280, 35);
            btnIniciar.Margin = new Padding(4, 5, 4, 5);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(100, 35);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(388, 35);
            btnReiniciar.Margin = new Padding(4, 5, 4, 5);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(100, 35);
            btnReiniciar.TabIndex = 2;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // listBoxTorreA
            // 
            listBoxTorreA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxTorreA.FormattingEnabled = true;
            listBoxTorreA.Location = new Point(40, 123);
            listBoxTorreA.Margin = new Padding(4, 5, 4, 5);
            listBoxTorreA.Name = "listBoxTorreA";
            listBoxTorreA.Size = new Size(185, 289);
            listBoxTorreA.TabIndex = 3;
            // 
            // listBoxTorreB
            // 
            listBoxTorreB.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxTorreB.FormattingEnabled = true;
            listBoxTorreB.Location = new Point(253, 123);
            listBoxTorreB.Margin = new Padding(4, 5, 4, 5);
            listBoxTorreB.Name = "listBoxTorreB";
            listBoxTorreB.Size = new Size(185, 289);
            listBoxTorreB.TabIndex = 4;
            // 
            // listBoxTorreC
            // 
            listBoxTorreC.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxTorreC.FormattingEnabled = true;
            listBoxTorreC.Location = new Point(467, 123);
            listBoxTorreC.Margin = new Padding(4, 5, 4, 5);
            listBoxTorreC.Name = "listBoxTorreC";
            listBoxTorreC.Size = new Size(185, 289);
            listBoxTorreC.TabIndex = 5;
            listBoxTorreC.SelectedIndexChanged += listBoxTorreC_SelectedIndexChanged;
            // 
            // lblMovimientos
            // 
            lblMovimientos.AutoSize = true;
            lblMovimientos.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovimientos.Location = new Point(40, 515);
            lblMovimientos.Margin = new Padding(4, 0, 4, 0);
            lblMovimientos.Name = "lblMovimientos";
            lblMovimientos.Size = new Size(136, 20);
            lblMovimientos.TabIndex = 6;
            lblMovimientos.Text = "Movimientos: 0";
            // 
            // lblMovimientosMinimos
            // 
            lblMovimientosMinimos.AutoSize = true;
            lblMovimientosMinimos.Location = new Point(249, 518);
            lblMovimientosMinimos.Margin = new Padding(4, 0, 4, 0);
            lblMovimientosMinimos.Name = "lblMovimientosMinimos";
            lblMovimientosMinimos.Size = new Size(171, 20);
            lblMovimientosMinimos.TabIndex = 7;
            lblMovimientosMinimos.Text = "Movimientos Mínimos: 0";
            // 
            // btnSeleccionarA
            // 
            btnSeleccionarA.Location = new Point(40, 438);
            btnSeleccionarA.Margin = new Padding(4, 5, 4, 5);
            btnSeleccionarA.Name = "btnSeleccionarA";
            btnSeleccionarA.Size = new Size(187, 46);
            btnSeleccionarA.TabIndex = 8;
            btnSeleccionarA.Tag = "0";
            btnSeleccionarA.Text = "Seleccionar A";
            btnSeleccionarA.UseVisualStyleBackColor = true;
            btnSeleccionarA.Click += btnSeleccionarTorre_Click;
            // 
            // btnSeleccionarB
            // 
            btnSeleccionarB.Location = new Point(253, 438);
            btnSeleccionarB.Margin = new Padding(4, 5, 4, 5);
            btnSeleccionarB.Name = "btnSeleccionarB";
            btnSeleccionarB.Size = new Size(187, 46);
            btnSeleccionarB.TabIndex = 9;
            btnSeleccionarB.Tag = "1";
            btnSeleccionarB.Text = "Seleccionar B";
            btnSeleccionarB.UseVisualStyleBackColor = true;
            btnSeleccionarB.Click += btnSeleccionarTorre_Click;
            // 
            // btnSeleccionarC
            // 
            btnSeleccionarC.Location = new Point(467, 438);
            btnSeleccionarC.Margin = new Padding(4, 5, 4, 5);
            btnSeleccionarC.Name = "btnSeleccionarC";
            btnSeleccionarC.Size = new Size(187, 46);
            btnSeleccionarC.TabIndex = 10;
            btnSeleccionarC.Tag = "2";
            btnSeleccionarC.Text = "Seleccionar C";
            btnSeleccionarC.UseVisualStyleBackColor = true;
            btnSeleccionarC.Click += btnSeleccionarTorre_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 11;
            label1.Text = "Número de Discos:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 585);
            Controls.Add(label1);
            Controls.Add(btnSeleccionarC);
            Controls.Add(btnSeleccionarB);
            Controls.Add(btnSeleccionarA);
            Controls.Add(lblMovimientosMinimos);
            Controls.Add(lblMovimientos);
            Controls.Add(listBoxTorreC);
            Controls.Add(listBoxTorreB);
            Controls.Add(listBoxTorreA);
            Controls.Add(btnReiniciar);
            Controls.Add(btnIniciar);
            Controls.Add(txtNumeroDiscos);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Torres de Hanoi - Taller 5";
            ResumeLayout(false);
            PerformLayout();

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
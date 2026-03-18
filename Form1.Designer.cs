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
            label2 = new Label();
            SuspendLayout();
            // 
            // txtNumeroDiscos
            // 
            txtNumeroDiscos.Location = new Point(243, 147);
            txtNumeroDiscos.Margin = new Padding(4, 3, 4, 3);
            txtNumeroDiscos.Name = "txtNumeroDiscos";
            txtNumeroDiscos.Size = new Size(129, 23);
            txtNumeroDiscos.TabIndex = 0;
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.Location = new Point(392, 144);
            btnIniciar.Margin = new Padding(4, 3, 4, 3);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(88, 27);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReiniciar.Location = new Point(487, 144);
            btnReiniciar.Margin = new Padding(4, 3, 4, 3);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(88, 27);
            btnReiniciar.TabIndex = 2;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // listBoxTorreA
            // 
            listBoxTorreA.BackColor = SystemColors.ActiveCaption;
            listBoxTorreA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxTorreA.FormattingEnabled = true;
            listBoxTorreA.Location = new Point(120, 210);
            listBoxTorreA.Margin = new Padding(4, 3, 4, 3);
            listBoxTorreA.Name = "listBoxTorreA";
            listBoxTorreA.Size = new Size(163, 229);
            listBoxTorreA.TabIndex = 3;
            // 
            // listBoxTorreB
            // 
            listBoxTorreB.BackColor = Color.Pink;
            listBoxTorreB.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxTorreB.FormattingEnabled = true;
            listBoxTorreB.Location = new Point(307, 210);
            listBoxTorreB.Margin = new Padding(4, 3, 4, 3);
            listBoxTorreB.Name = "listBoxTorreB";
            listBoxTorreB.Size = new Size(163, 229);
            listBoxTorreB.TabIndex = 4;
            // 
            // listBoxTorreC
            // 
            listBoxTorreC.BackColor = Color.PapayaWhip;
            listBoxTorreC.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxTorreC.FormattingEnabled = true;
            listBoxTorreC.Location = new Point(493, 210);
            listBoxTorreC.Margin = new Padding(4, 3, 4, 3);
            listBoxTorreC.Name = "listBoxTorreC";
            listBoxTorreC.Size = new Size(163, 229);
            listBoxTorreC.TabIndex = 5;
            // 
            // lblMovimientos
            // 
            lblMovimientos.AutoSize = true;
            lblMovimientos.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovimientos.Location = new Point(120, 505);
            lblMovimientos.Margin = new Padding(4, 0, 4, 0);
            lblMovimientos.Name = "lblMovimientos";
            lblMovimientos.Size = new Size(110, 16);
            lblMovimientos.TabIndex = 6;
            lblMovimientos.Text = "Movimientos: 0";
            // 
            // lblMovimientosMinimos
            // 
            lblMovimientosMinimos.AutoSize = true;
            lblMovimientosMinimos.Location = new Point(303, 507);
            lblMovimientosMinimos.Margin = new Padding(4, 0, 4, 0);
            lblMovimientosMinimos.Name = "lblMovimientosMinimos";
            lblMovimientosMinimos.Size = new Size(139, 15);
            lblMovimientosMinimos.TabIndex = 7;
            lblMovimientosMinimos.Text = "Movimientos Mínimos: 0";
            // 
            // btnSeleccionarA
            // 
            btnSeleccionarA.BackColor = SystemColors.ActiveCaption;
            btnSeleccionarA.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeleccionarA.Location = new Point(120, 447);
            btnSeleccionarA.Margin = new Padding(4, 3, 4, 3);
            btnSeleccionarA.Name = "btnSeleccionarA";
            btnSeleccionarA.Size = new Size(163, 35);
            btnSeleccionarA.TabIndex = 8;
            btnSeleccionarA.Tag = "0";
            btnSeleccionarA.Text = "Seleccionar A";
            btnSeleccionarA.UseVisualStyleBackColor = false;
            btnSeleccionarA.Click += btnSeleccionarTorre_Click;
            // 
            // btnSeleccionarB
            // 
            btnSeleccionarB.BackColor = Color.Pink;
            btnSeleccionarB.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeleccionarB.Location = new Point(307, 447);
            btnSeleccionarB.Margin = new Padding(4, 3, 4, 3);
            btnSeleccionarB.Name = "btnSeleccionarB";
            btnSeleccionarB.Size = new Size(163, 35);
            btnSeleccionarB.TabIndex = 9;
            btnSeleccionarB.Tag = "1";
            btnSeleccionarB.Text = "Seleccionar B";
            btnSeleccionarB.UseVisualStyleBackColor = false;
            btnSeleccionarB.Click += btnSeleccionarTorre_Click;
            // 
            // btnSeleccionarC
            // 
            btnSeleccionarC.BackColor = Color.PapayaWhip;
            btnSeleccionarC.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeleccionarC.Location = new Point(493, 447);
            btnSeleccionarC.Margin = new Padding(4, 3, 4, 3);
            btnSeleccionarC.Name = "btnSeleccionarC";
            btnSeleccionarC.Size = new Size(163, 35);
            btnSeleccionarC.TabIndex = 10;
            btnSeleccionarC.Tag = "2";
            btnSeleccionarC.Text = "Seleccionar C";
            btnSeleccionarC.UseVisualStyleBackColor = false;
            btnSeleccionarC.Click += btnSeleccionarTorre_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 150);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 11;
            label1.Text = "Número de Discos:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(174, 53);
            label2.Name = "label2";
            label2.Size = new Size(401, 55);
            label2.TabIndex = 12;
            label2.Text = "Las Torres de Hanoi ";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(780, 565);
            Controls.Add(label2);
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
            Margin = new Padding(4, 3, 4, 3);
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
        private Label label2;
    }
}
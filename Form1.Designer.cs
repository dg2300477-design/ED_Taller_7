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
            labelTitulo = new Label();
            SuspendLayout();
            // 
            // txtNumeroDiscos
            // 
            txtNumeroDiscos.Location = new Point(30, 40);
            txtNumeroDiscos.Name = "txtNumeroDiscos";
            txtNumeroDiscos.Size = new Size(100, 31);
            txtNumeroDiscos.TabIndex = 0;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(140, 38);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(74, 33);
            btnIniciar.TabIndex = 9;
            btnIniciar.Text = "Iniciar";
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(220, 38);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(80, 33);
            btnReiniciar.TabIndex = 8;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // listBoxTorreA
            // 
            listBoxTorreA.Location = new Point(30, 100);
            listBoxTorreA.Name = "listBoxTorreA";
            listBoxTorreA.Size = new Size(120, 179);
            listBoxTorreA.TabIndex = 7;
            // 
            // listBoxTorreB
            // 
            listBoxTorreB.Location = new Point(180, 100);
            listBoxTorreB.Name = "listBoxTorreB";
            listBoxTorreB.Size = new Size(120, 179);
            listBoxTorreB.TabIndex = 6;
            // 
            // listBoxTorreC
            // 
            listBoxTorreC.Location = new Point(330, 100);
            listBoxTorreC.Name = "listBoxTorreC";
            listBoxTorreC.Size = new Size(120, 179);
            listBoxTorreC.TabIndex = 5;
            // 
            // lblMovimientos
            // 
            lblMovimientos.Location = new Point(330, 43);
            lblMovimientos.Name = "lblMovimientos";
            lblMovimientos.Size = new Size(150, 20);
            lblMovimientos.TabIndex = 4;
            lblMovimientos.Text = "Movimientos: 0";
            // 
            // lblMovimientosMinimos
            // 
            lblMovimientosMinimos.Location = new Point(330, 20);
            lblMovimientosMinimos.Name = "lblMovimientosMinimos";
            lblMovimientosMinimos.Size = new Size(200, 20);
            lblMovimientosMinimos.TabIndex = 3;
            lblMovimientosMinimos.Text = "Mínimos: 0";
            // 
            // btnSeleccionarA
            // 
            btnSeleccionarA.Location = new Point(30, 310);
            btnSeleccionarA.Name = "btnSeleccionarA";
            btnSeleccionarA.Size = new Size(120, 30);
            btnSeleccionarA.TabIndex = 2;
            btnSeleccionarA.Tag = "0";
            btnSeleccionarA.Text = "Seleccionar A";
            btnSeleccionarA.Click += btnSeleccionarTorre_Click;
            // 
            // btnSeleccionarB
            // 
            btnSeleccionarB.Location = new Point(180, 310);
            btnSeleccionarB.Name = "btnSeleccionarB";
            btnSeleccionarB.Size = new Size(120, 30);
            btnSeleccionarB.TabIndex = 1;
            btnSeleccionarB.Tag = "1";
            btnSeleccionarB.Text = "Seleccionar B";
            btnSeleccionarB.Click += btnSeleccionarTorre_Click;
            // 
            // btnSeleccionarC
            // 
            btnSeleccionarC.Location = new Point(330, 310);
            btnSeleccionarC.Name = "btnSeleccionarC";
            btnSeleccionarC.Size = new Size(120, 30);
            btnSeleccionarC.TabIndex = 0;
            btnSeleccionarC.Tag = "2";
            btnSeleccionarC.Text = "Seleccionar C";
            btnSeleccionarC.Click += btnSeleccionarTorre_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.Location = new Point(0, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(100, 23);
            labelTitulo.TabIndex = 0;
            // 
            // Form1
            // 
            ClientSize = new Size(549, 433);
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
            Name = "Form1";
            Text = "Torres de Hanoi";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

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
        private System.Windows.Forms.Label labelTitulo;
    }
}
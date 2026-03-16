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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtNumeroDiscos
            this.txtNumeroDiscos.Location = new System.Drawing.Point(30, 40);
            this.txtNumeroDiscos.Name = "txtNumeroDiscos";
            this.txtNumeroDiscos.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDiscos.TabIndex = 0;

            // btnIniciar
            this.btnIniciar.Location = new System.Drawing.Point(140, 38);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);

            // btnReiniciar
            this.btnReiniciar.Location = new System.Drawing.Point(220, 38);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);

            // ListBoxes (Torres)
            this.listBoxTorreA.Location = new System.Drawing.Point(30, 100);
            this.listBoxTorreA.Name = "listBoxTorreA";
            this.listBoxTorreA.Size = new System.Drawing.Size(120, 200);

            this.listBoxTorreB.Location = new System.Drawing.Point(180, 100);
            this.listBoxTorreB.Name = "listBoxTorreB";
            this.listBoxTorreB.Size = new System.Drawing.Size(120, 200);

            this.listBoxTorreC.Location = new System.Drawing.Point(330, 100);
            this.listBoxTorreC.Name = "listBoxTorreC";
            this.listBoxTorreC.Size = new System.Drawing.Size(120, 200);

            // Labels
            this.lblMovimientos.Location = new System.Drawing.Point(330, 43);
            this.lblMovimientos.Name = "lblMovimientos";
            this.lblMovimientos.Size = new System.Drawing.Size(150, 20);
            this.lblMovimientos.Text = "Movimientos: 0";

            this.lblMovimientosMinimos.Location = new System.Drawing.Point(330, 20);
            this.lblMovimientosMinimos.Name = "lblMovimientosMinimos";
            this.lblMovimientosMinimos.Size = new System.Drawing.Size(200, 20);
            this.lblMovimientosMinimos.Text = "Mínimos: 0";

            // Botones Seleccionar (IMPORTANTE EL TAG)
            this.btnSeleccionarA.Location = new System.Drawing.Point(30, 310);
            this.btnSeleccionarA.Name = "btnSeleccionarA";
            this.btnSeleccionarA.Size = new System.Drawing.Size(120, 30);
            this.btnSeleccionarA.Tag = "0";
            this.btnSeleccionarA.Text = "Seleccionar A";
            this.btnSeleccionarA.Click += new System.EventHandler(this.btnSeleccionarTorre_Click);

            this.btnSeleccionarB.Location = new System.Drawing.Point(180, 310);
            this.btnSeleccionarB.Name = "btnSeleccionarB";
            this.btnSeleccionarB.Size = new System.Drawing.Size(120, 30);
            this.btnSeleccionarB.Tag = "1";
            this.btnSeleccionarB.Text = "Seleccionar B";
            this.btnSeleccionarB.Click += new System.EventHandler(this.btnSeleccionarTorre_Click);

            this.btnSeleccionarC.Location = new System.Drawing.Point(330, 310);
            this.btnSeleccionarC.Name = "btnSeleccionarC";
            this.btnSeleccionarC.Size = new System.Drawing.Size(120, 30);
            this.btnSeleccionarC.Tag = "2";
            this.btnSeleccionarC.Text = "Seleccionar C";
            this.btnSeleccionarC.Click += new System.EventHandler(this.btnSeleccionarTorre_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(500, 380);
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
            this.Text = "Torres de Hanoi";
            this.ResumeLayout(false);
            this.PerformLayout();
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
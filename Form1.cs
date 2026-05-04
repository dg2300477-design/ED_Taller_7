using System;
using System.Drawing;
using System.Windows.Forms;

namespace ED_Taller_7
{
    public partial class Form1 : Form
    {
        // --- VARIABLES DE HANOI ---
        private StackArray<int> TorreA = new StackArray<int>();
        private StackArray<int> TorreB = new StackArray<int>();
        private StackArray<int> TorreC = new StackArray<int>();
        private int movimientos = 0;
        private int totalDiscos = 0;
        private int origenSeleccionado = -1;

        // --- VARIABLES DEL ÁRBOL ---
        private BinaryTree<int> miArbol = new AVLTree<int>(); // Por defecto AVL
        private Panel panelArbol;
        private TextBox txtValorNodo;
        private Label lblInfoArbol;
        private Label lblRecorridos;
        private ComboBox cmbTipoArbol;

        public Form1()
        {
            InitializeComponent();
            ConfigurarPestanasYArbol(); // Construye la UI del árbol al arrancar
        }

        // ==========================================
        // 1. CONFIGURACIÓN DE PESTAÑAS (HANOI / ÁRBOL)
        // ==========================================
        private void ConfigurarPestanasYArbol()
        {
            // Crear el TabControl
            TabControl tabControl = new TabControl();
            tabControl.Dock = DockStyle.Fill;

            // Pestaña 1: Hanoi
            TabPage tabHanoi = new TabPage("Torres de Hanoi");
            // Mover todos los controles existentes (botones, listas) a la pestaña de Hanoi
            Control[] controlesHanoi = new Control[this.Controls.Count];
            this.Controls.CopyTo(controlesHanoi, 0);
            foreach (Control c in controlesHanoi)
            {
                tabHanoi.Controls.Add(c);
            }

            // Pestaña 2: Árboles
            TabPage tabArboles = new TabPage("Árbol Binario / AVL");
            ConfigurarUIArbol(tabArboles);

            // Agregar pestañas al form
            tabControl.TabPages.Add(tabHanoi);
            tabControl.TabPages.Add(tabArboles);
            this.Controls.Add(tabControl);
        }

        private void ConfigurarUIArbol(TabPage tab)
        {
            // Panel de dibujo
            panelArbol = new Panel { Dock = DockStyle.Top, Height = 400, BackColor = Color.White };
            panelArbol.Paint += PanelArbol_Paint;

            // Controles inferiores
            Panel panelControles = new Panel { Dock = DockStyle.Bottom, Height = 100, BackColor = Color.LightGray };

            Label lblValor = new Label { Text = "Valor:", Location = new Point(10, 20), Width = 40 };
            txtValorNodo = new TextBox { Location = new Point(50, 18), Width = 60 };

            Button btnInsertar = new Button { Text = "Insertar", Location = new Point(120, 15), Width = 70 };
            btnInsertar.Click += BtnInsertar_Click;

            Button btnMin = new Button { Text = "Mínimo", Location = new Point(200, 15), Width = 70 };
            btnMin.Click += (s, e) => { if (!miArbol.IsEmpty()) MessageBox.Show("Mínimo: " + miArbol.Min()); };

            Button btnMax = new Button { Text = "Máximo", Location = new Point(280, 15), Width = 70 };
            btnMax.Click += (s, e) => { if (!miArbol.IsEmpty()) MessageBox.Show("Máximo: " + miArbol.Max()); };

            Button btnLimpiar = new Button { Text = "Limpiar", Location = new Point(360, 15), Width = 70 };
            btnLimpiar.Click += (s, e) => { miArbol.Clear(); ActualizarInfoArbol(); };

            Button btnInOrder = new Button { Text = "InOrder", Location = new Point(440, 15), Width = 70 };
            btnInOrder.Click += (s, e) => { miArbol.InOrder(); ActualizarInfoArbol(); };

            cmbTipoArbol = new ComboBox { Location = new Point(600, 18), Width = 120, DropDownStyle = ComboBoxStyle.DropDownList };
            cmbTipoArbol.Items.AddRange(new string[] { "Árbol AVL", "Árbol Binario (BST)" });
            cmbTipoArbol.SelectedIndex = 0;
            cmbTipoArbol.SelectedIndexChanged += CmbTipoArbol_SelectedIndexChanged;
            Label lblTipo = new Label { Text = "Tipo:", Location = new Point(560, 20), Width = 40 };

            lblInfoArbol = new Label { Text = "Nodos: 0 | Altura: 0 | Clasificación: Vacio", Location = new Point(10, 50), Width = 400 };
            lblRecorridos = new Label { Text = "Recorrido: ", Location = new Point(10, 70), Width = 700, Font = new Font("Arial", 9, FontStyle.Bold) };

            panelControles.Controls.AddRange(new Control[] { lblValor, txtValorNodo, btnInsertar, btnMin, btnMax, btnLimpiar, btnInOrder, lblTipo, cmbTipoArbol, lblInfoArbol, lblRecorridos });
            tab.Controls.Add(panelArbol);
            tab.Controls.Add(panelControles);
        }

        // ==========================================
        // 2. LÓGICA DEL ÁRBOL
        // ==========================================
        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValorNodo.Text, out int val))
            {
                miArbol.Insert(val);
                txtValorNodo.Clear();
                txtValorNodo.Focus();
                ActualizarInfoArbol();
            }
            else MessageBox.Show("Ingrese un número entero válido.");
        }

        private void CmbTipoArbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            miArbol = cmbTipoArbol.SelectedIndex == 0 ? new AVLTree<int>() : new BinaryTree<int>();
            ActualizarInfoArbol();
        }

        private void ActualizarInfoArbol()
        {
            lblInfoArbol.Text = $"Nodos: {miArbol.Count()} | Altura: {miArbol.Height()} | Clasificación: {TreeClassifier.Classify(miArbol)}";
            lblRecorridos.Text = $"Recorrido: {miArbol.RecorridoActual}";
            panelArbol.Invalidate(); // Fuerza a redibujar el árbol
        }

        // ==========================================
        // 3. DIBUJO DEL ÁRBOL (GDI+)
        // ==========================================
        private void PanelArbol_Paint(object sender, PaintEventArgs e)
        {
            if (miArbol != null && !miArbol.IsEmpty())
            {
                // Empezar a dibujar desde el centro superior del panel
                DibujarNodo(e.Graphics, miArbol.GetRoot(), panelArbol.Width / 2, 30, panelArbol.Width / 4);
            }
        }

        private void DibujarNodo(Graphics g, NodeTree<int> nodo, int x, int y, int xOffset)
        {
            if (nodo == null) return;

            // Dibujar línea al hijo izquierdo
            if (nodo.Left != null)
            {
                g.DrawLine(Pens.Black, x, y, x - xOffset, y + 50);
                DibujarNodo(g, nodo.Left, x - xOffset, y + 50, xOffset / 2);
            }
            // Dibujar línea al hijo derecho
            if (nodo.Right != null)
            {
                g.DrawLine(Pens.Black, x, y, x + xOffset, y + 50);
                DibujarNodo(g, nodo.Right, x + xOffset, y + 50, xOffset / 2);
            }

            // Dibujar el círculo del nodo (estilo azul marino como en tu imagen)
            Brush fondoNodo = new SolidBrush(Color.FromArgb(44, 62, 80));
            g.FillEllipse(fondoNodo, x - 15, y - 15, 30, 30);
            g.DrawEllipse(Pens.White, x - 15, y - 15, 30, 30);

            // Dibujar el número en el centro
            StringFormat sf = new StringFormat { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center };
            g.DrawString(nodo.Data.ToString(), new Font("Arial", 10, FontStyle.Bold), Brushes.White, x, y, sf);
        }

        // ==========================================
        // 4. LÓGICA DE HANOI (Tu código original intacto)
        // ==========================================
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumeroDiscos.Text, out totalDiscos) || totalDiscos <= 0 || totalDiscos > 15)
            {
                MessageBox.Show("Por favor, ingrese un número válido de discos (entre 1 y 15).", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumeroDiscos.Clear();
                txtNumeroDiscos.Focus();
                return;
            }
            ReiniciarTodo();
            for (int i = totalDiscos; i >= 1; i--) TorreA.Push(i);
            lblMovimientosMinimos.Text = "Movimientos Mínimos: " + (Math.Pow(2, totalDiscos) - 1);
            ActualizarPantalla();
        }

        private void btnSeleccionarTorre_Click(object sender, EventArgs e)
        {
            if (totalDiscos == 0) { MessageBox.Show("Debe iniciar el juego primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            Button btn = (Button)sender;
            int torreID = int.Parse(btn.Tag.ToString());

            if (origenSeleccionado == -1)
            {
                if (!ObtenerTorre(torreID).IsEmpty()) { origenSeleccionado = torreID; Resaltar(torreID, true); }
            }
            else
            {
                MoverDisco(origenSeleccionado, torreID);
                Resaltar(origenSeleccionado, false);
                origenSeleccionado = -1;
                ActualizarPantalla();
                VerificarVictoria();
            }
        }

        private void MoverDisco(int de, int a)
        {
            if (de == a) return;
            var stackOrigen = ObtenerTorre(de);
            var stackDestino = ObtenerTorre(a);

            if (stackDestino.IsEmpty() || stackOrigen.Peek() < stackDestino.Peek())
            {
                stackDestino.Push(stackOrigen.Pop());
                movimientos++;
                lblMovimientos.Text = "Movimientos: " + movimientos;
            }
            else MessageBox.Show("Movimiento inválido: No puedes colocar un disco grande sobre uno pequeño.", "Regla violada", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ActualizarPantalla()
        {
            DibujarTorre(TorreA, listBoxTorreA);
            DibujarTorre(TorreB, listBoxTorreB);
            DibujarTorre(TorreC, listBoxTorreC);
        }

        private void DibujarTorre(StackArray<int> torre, ListBox lb)
        {
            lb.Items.Clear();
            StackArray<int> aux = new StackArray<int>();
            while (!torre.IsEmpty()) aux.Push(torre.Pop());
            while (!aux.IsEmpty())
            {
                int disco = aux.Pop();
                string barra = new string('=', disco * 2);
                lb.Items.Insert(0, string.Format("{0,15}", "[" + barra + " " + disco + " " + barra + "]"));
                torre.Push(disco);
            }
        }

        private void Resaltar(int id, bool seleccionado)
        {
            Color colorSeleccion = seleccionado ? Color.LightSkyBlue : Color.White;
            if (id == 0) listBoxTorreA.BackColor = colorSeleccion;
            else if (id == 1) listBoxTorreB.BackColor = colorSeleccion;
            else listBoxTorreC.BackColor = colorSeleccion;
        }

        private void VerificarVictoria()
        {
            if (TorreC.Count() == totalDiscos && totalDiscos > 0)
            {
                MessageBox.Show($"¡Felicidades! Completaste el puzzle en {movimientos} movimientos.", "¡VICTORIA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReiniciarTodo();
                ActualizarPantalla();
            }
        }

        private StackArray<int> ObtenerTorre(int id) { return id == 0 ? TorreA : (id == 1 ? TorreB : TorreC); }

        private void ReiniciarTodo()
        {
            TorreA.Clear(); TorreB.Clear(); TorreC.Clear();
            movimientos = 0; lblMovimientos.Text = "Movimientos: 0"; origenSeleccionado = -1;
            listBoxTorreA.BackColor = Color.White; listBoxTorreB.BackColor = Color.White; listBoxTorreC.BackColor = Color.White;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            totalDiscos = 0; txtNumeroDiscos.Clear(); lblMovimientosMinimos.Text = "Movimientos Mínimos: 0";
            ReiniciarTodo(); ActualizarPantalla();
        }

        // Eventos vacíos del diseñador
        private void Form1_Load(object sender, EventArgs e) { }
        private void txtNumeroDiscos_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
    }
}
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ED_Taller_7
{
    public partial class Form1 : Form
    {
        private StackArray<int> TorreA = new StackArray<int>();
        private StackArray<int> TorreB = new StackArray<int>();
        private StackArray<int> TorreC = new StackArray<int>();

        private int movimientos = 0;
        private int totalDiscos = 0;
        private int origenSeleccionado = -1; // -1 significa que no hay torre seleccionada

        public Form1()
        {
            InitializeComponent();
        }

        // --- LÓGICA DE JUEGO ---

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // MANEJO DE ERRORES (Punto 7): Evitar crash por textos o números inválidos
            if (!int.TryParse(txtNumeroDiscos.Text, out totalDiscos) || totalDiscos <= 0 || totalDiscos > 15)
            {
                MessageBox.Show("Por favor, ingrese un número válido de discos (entre 1 y 15).", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumeroDiscos.Clear();
                txtNumeroDiscos.Focus();
                return;
            }

            ReiniciarTodo();

            // Llenar la Torre A con los discos (el más grande primero)
            for (int i = totalDiscos; i >= 1; i--)
            {
                TorreA.Push(i);
            }

            // Cálculo matemático de movimientos mínimos (2^n - 1)
            lblMovimientosMinimos.Text = "Movimientos Mínimos: " + (Math.Pow(2, totalDiscos) - 1);
            ActualizarPantalla();
        }

        private void btnSeleccionarTorre_Click(object sender, EventArgs e)
        {
            // MANEJO DE ERRORES (Punto 7): Evitar crash si hacen clic antes de iniciar
            if (totalDiscos == 0)
            {
                MessageBox.Show("Debe iniciar el juego primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Button btn = (Button)sender;
            int torreID = int.Parse(btn.Tag.ToString()); // 0 = A, 1 = B, 2 = C

            if (origenSeleccionado == -1)
            {
                // Seleccionar origen (solo si la torre no está vacía)
                if (!ObtenerTorre(torreID).IsEmpty())
                {
                    origenSeleccionado = torreID;
                    Resaltar(torreID, true);
                }
            }
            else
            {
                // Seleccionar destino y mover
                MoverDisco(origenSeleccionado, torreID);
                Resaltar(origenSeleccionado, false);
                origenSeleccionado = -1;
                ActualizarPantalla();
                VerificarVictoria();
            }
        }

        private void MoverDisco(int de, int a)
        {
            if (de == a) return; // Cancelar si seleccionan la misma torre dos veces

            var stackOrigen = ObtenerTorre(de);
            var stackDestino = ObtenerTorre(a);

            // Validación con PEEK
            if (stackDestino.IsEmpty() || stackOrigen.Peek() < stackDestino.Peek())
            {
                stackDestino.Push(stackOrigen.Pop());
                movimientos++;
                lblMovimientos.Text = "Movimientos: " + movimientos;
            }
            else
            {
                MessageBox.Show("Movimiento inválido: No puedes colocar un disco grande sobre uno pequeño.", "Regla violada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- INTERFAZ GRÁFICA ---

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

            // Pasar a pila auxiliar
            while (!torre.IsEmpty()) aux.Push(torre.Pop());

            // Devolver a la torre original y dibujar (de arriba hacia abajo)
            while (!aux.IsEmpty())
            {
                int disco = aux.Pop();
                string barra = new string('=', disco * 2);
                string representacionVisual = string.Format("{0,15}", "[" + barra + " " + disco + " " + barra + "]");

                // Usamos Insert(0) para que los discos pequeños queden arriba
                lb.Items.Insert(0, representacionVisual);

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

        // --- UTILIDADES ---

        private void VerificarVictoria()
        {
            if (TorreC.Count() == totalDiscos && totalDiscos > 0)
            {
                MessageBox.Show($"¡Felicidades! Completaste el puzzle en {movimientos} movimientos.", "¡VICTORIA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReiniciarTodo();
                ActualizarPantalla();
            }
        }

        private StackArray<int> ObtenerTorre(int id)
        {
            if (id == 0) return TorreA;
            if (id == 1) return TorreB;
            return TorreC;
        }

        private void ReiniciarTodo()
        {
            TorreA.Clear();
            TorreB.Clear();
            TorreC.Clear();
            movimientos = 0;
            lblMovimientos.Text = "Movimientos: 0";
            origenSeleccionado = -1;

            listBoxTorreA.BackColor = Color.White;
            listBoxTorreB.BackColor = Color.White;
            listBoxTorreC.BackColor = Color.White;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            totalDiscos = 0;
            txtNumeroDiscos.Clear();
            lblMovimientosMinimos.Text = "Movimientos Mínimos: 0";
            ReiniciarTodo();
            ActualizarPantalla();
        }

        // Eventos vacíos que generó el diseñador visual
        private void Form1_Load(object sender, EventArgs e) { }
        private void txtNumeroDiscos_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
    }
}
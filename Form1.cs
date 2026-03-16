using System;
using System.Drawing;
using System.Windows.Forms;
using ED_Taller_7;

namespace ED_Taller_7
{
    public partial class Form1 : Form
    {
        // 1. Pilas obligatorias del taller
        private StackArray<int> TorreA = new StackArray<int>();
        private StackArray<int> TorreB = new StackArray<int>();
        private StackArray<int> TorreC = new StackArray<int>();


        private int movimientos = 0;
        private int totalDiscos = 0;
        private int origenSeleccionado = -1; // -1: ninguno seleccionado


        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumeroDiscos_TextChanged(object sender, EventArgs e)
        {
            // Se deja vacío para que el Designer no falle
        }
        private void btnSeleccionarTorre_Click(object sender, EventArgs e)
        {
            if (totalDiscos == 0) return;

            Button btn = (Button)sender;
            // Importante: El Tag del botón debe ser 0, 1 o 2
            int torreID = int.Parse(btn.Tag.ToString());

            if (origenSeleccionado == -1)
            {
                if (!ObtenerTorre(torreID).IsEmpty())
                {
                    origenSeleccionado = torreID;
                    Resaltar(torreID, true);
                }
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

        // --- LÓGICA DE JUEGO ---

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumeroDiscos.Text, out totalDiscos) || totalDiscos <= 0)
            {
                MessageBox.Show("Ingrese un número de discos válido.");
                return;
            }

            ReiniciarTodo();
            for (int i = totalDiscos; i >= 1; i--) TorreA.Push(i);

            lblMovimientosMinimos.Text = "Mínimos: " + (Math.Pow(2, totalDiscos) - 1);
            ActualizarPantalla();
        }

        private void MoverDisco(int de, int a)
        {
            if (de == a) return;
            var stackOrigen = ObtenerTorre(de);
            var stackDestino = ObtenerTorre(a);

            // Validación con PEEK (Punto 3 del taller)
            if (stackDestino.IsEmpty() || stackOrigen.Peek() < stackDestino.Peek())
            {
                stackDestino.Push(stackOrigen.Pop());
                movimientos++;
                lblMovimientos.Text = "Movimientos: " + movimientos;
            }
            else
            {
                MessageBox.Show("Movimiento inválido: Disco grande sobre pequeño.");
            }
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
                // Representación visual con caracteres: [======= 3 =======]
                string barra = new string('=', disco * 2);
                lb.Items.Add(string.Format("{0,15}", "[" + barra + " " + disco + " " + barra + "]"));
                torre.Push(disco);
            }
        }

        // --- UTILIDADES ---

        private void VerificarVictoria()
        {
            if (TorreC.Count() == totalDiscos && totalDiscos > 0)
                MessageBox.Show("¡GANASTE! Todos los discos están en la Torre C.");
        }

        private StackArray<int> ObtenerTorre(int id) => id == 0 ? TorreA : (id == 1 ? TorreB : TorreC);

        private void Resaltar(int id, bool r)
        {
            Color c = r ? Color.LightBlue : Color.White;
            if (id == 0) listBoxTorreA.BackColor = c;
            else if (id == 1) listBoxTorreB.BackColor = c;
            else listBoxTorreC.BackColor = c;
        }

        private void ReiniciarTodo()
        {
            TorreA.Clear(); TorreB.Clear(); TorreC.Clear();
            movimientos = 0;
            lblMovimientos.Text = "Movimientos: 0";
            origenSeleccionado = -1;
            listBoxTorreA.BackColor = Color.White;
            listBoxTorreB.BackColor = Color.White;
            listBoxTorreC.BackColor = Color.White;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            ReiniciarTodo();
            ActualizarPantalla();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBoxTorreC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
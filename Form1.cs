using System;
using System.Windows.Forms;
using ED_Taller_7;

namespace ED_Taller_7
{
    public partial class Form1 : Form
    {
        // Pilas personalizadas
        private ArrayStack<int> TorreA;
        private ArrayStack<int> TorreB;
        private ArrayStack<int> TorreC;

        private int movimientos = 0;
        private int totalDiscos = 0;
        private int torreOrigenSeleccionada = -1;

        public Form1()
        {
            InitializeComponent();
            // Inicialización de pilas
            TorreA = new ArrayStack<int>();
            TorreB = new ArrayStack<int>();
            TorreC = new ArrayStack<int>();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumeroDiscos.Text, out totalDiscos) || totalDiscos <= 0)
            {
                MessageBox.Show("Ingrese un número válido.");
                return;
            }

            ReiniciarJuego();

            for (int i = totalDiscos; i >= 1; i--)
            {
                TorreA.Push(i);
            }

            lblMovimientosMinimos.Text = "Mínimos: " + (Math.Pow(2, totalDiscos) - 1);
            ActualizarInterfaz();
        }

        private void btnSeleccionarTorre_Click(object sender, EventArgs e)
        {
            if (totalDiscos == 0) return;

            Button btn = (Button)sender;
            int torreClickeada = int.Parse(btn.Tag.ToString());

            if (torreOrigenSeleccionada == -1)
            {
                if (!ObtenerPila(torreClickeada).IsEmpty())
                    torreOrigenSeleccionada = torreClickeada;
            }
            else
            {
                MoverDisco(torreOrigenSeleccionada, torreClickeada);
                torreOrigenSeleccionada = -1;
                ActualizarInterfaz();
                VerificarVictoria();
            }
        }

        private void MoverDisco(int origen, int destino)
        {
            if (origen == destino) return;

            ArrayStack<int> pOrigen = ObtenerPila(origen);
            ArrayStack<int> pDestino = ObtenerPila(destino);

            if (pDestino.IsEmpty() || pOrigen.Peek() < pDestino.Peek())
            {
                pDestino.Push(pOrigen.Pop());
                movimientos++;
                lblMovimientos.Text = "Movimientos: " + movimientos;
            }
            else
            {
                MessageBox.Show("Movimiento inválido.");
            }
        }

        private void ActualizarInterfaz()
        {
            RefrescarListBox(TorreA, listBoxTorreA);
            RefrescarListBox(TorreB, listBoxTorreB);
            RefrescarListBox(TorreC, listBoxTorreC);
        }

        private void RefrescarListBox(ArrayStack<int> pila, ListBox lb)
        {
            lb.Items.Clear();
            ArrayStack<int> aux = new ArrayStack<int>();
            while (!pila.IsEmpty())
            {
                int d = pila.Pop();
                lb.Items.Add("Disco " + d);
                aux.Push(d);
            }
            while (!aux.IsEmpty()) pila.Push(aux.Pop());
        }

        private ArrayStack<int> ObtenerPila(int i)
        {
            if (i == 0) return TorreA;
            if (i == 1) return TorreB;
            return TorreC;
        }

        private void VerificarVictoria()
        {
            if (TorreC.Count() == totalDiscos && totalDiscos > 0)
                MessageBox.Show("¡Ganaste!");
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            ReiniciarJuego();
        }

        private void ReiniciarJuego()
        {
            TorreA.Clear(); TorreB.Clear(); TorreC.Clear();
            movimientos = 0;
            lblMovimientos.Text = "Movimientos: 0";
            torreOrigenSeleccionada = -1;
            ActualizarInterfaz();
        }
    }
}
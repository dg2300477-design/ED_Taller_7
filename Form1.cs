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
            if (totalDiscos == 0) return; //si no hay discos de una torre a otra no  hace nada

            Button btn = (Button)sender; //el sender sera el boton
            // Importante: El Tag del botón debe ser 0, 1 o 2
            int torreID = int.Parse(btn.Tag.ToString()); //identifica el boton de la torre seleccionada

            if (origenSeleccionado == -1) //si aun no hay torre de origen seleccionada
            {
                if (!ObtenerTorre(torreID).IsEmpty()) //si la torre seleccionada NO está vacia
                {
                    origenSeleccionado = torreID; //la torre sera de donde saldra el disco
                    Resaltar(torreID, true);    //y sera resaltada para indicar que fue seleccionada
                }
            }
            else  //en cambio si ya hay torre de origen seleccionada
            {
                MoverDisco(origenSeleccionado, torreID); //llamará al metodo de mover disco
                Resaltar(origenSeleccionado, false); //metodo de resaltar
                origenSeleccionado = -1; //reinicia la seleccion
                ActualizarPantalla(); //redibujara las torres de la interfaz
                VerificarVictoria(); //evalua si el jugador ganó(si los discos estan ordenados en c)
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
            if (de == a) return; //evita movimiento hacia la misma torre
            var stackOrigen = ObtenerTorre(de); //maneja cada torre como stack
            var stackDestino = ObtenerTorre(a);

            // Validación con PEEK (Punto 3 del taller)
            //si el disco de destino está vacio o el disco del origen es mas pequeño al de destino
            if (stackDestino.IsEmpty() || stackOrigen.Peek() < stackDestino.Peek())
            {
                stackDestino.Push(stackOrigen.Pop());//saca el disco de origen y lo pone inmediatamente en destino
                movimientos++;//aumenta el numero de movimientos realizados
                lblMovimientos.Text = "Movimientos: " + movimientos; //marca el contador de movimientos
            }
            else
            {
                //si no se cumple la regla lanza un mensaje de error
                MessageBox.Show("Movimiento inválido: Disco grande sobre pequeño.");
            }
        }
        private void ActualizarPantalla()
        {
            //redibuja cada torre en su listbox correspondiente
            DibujarTorre(TorreA, listBoxTorreA);
            DibujarTorre(TorreB, listBoxTorreB);
            DibujarTorre(TorreC, listBoxTorreC);
        }

        private void DibujarTorre(StackArray<int> torre, ListBox lb)
        {
            lb.Items.Clear();//borra todo lo que estaba para redibujar desde cero

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
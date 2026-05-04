
namespace ED_Taller_7
{
    public class StackArray<T> : IStack<T>
    {
        private T[] elementos;
        private int tope;
        private const int CapacidadInicial = 10;

        // Constructor
        //Holaputos
        public StackArray()
        {
            elementos = new T[CapacidadInicial];
            tope = -1; // -1 indica que la pila está vacía
        }

        // Inserta un elemento en la parte superior de la pila
        public void Push(T item)
        {
            // Si el arreglo está lleno, duplicamos su tamaño
            if (tope == elementos.Length - 1)
            {
                Array.Resize(ref elementos, elementos.Length * 2);
            }

            tope++;
            elementos[tope] = item;
        }

        // Retira y devuelve el elemento superior de la pila
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("La pila está vacía.");
            }

            T item = elementos[tope];
            elementos[tope] = default(T); // Limpiamos la referencia
            tope--;

            return item;
        }

        // Devuelve el elemento superior sin retirarlo (Necesario para validar movimientos)
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("La pila está vacía.");
            }

            return elementos[tope];
        }

        // Verifica si la pila está vacía
        public bool IsEmpty()
        {
            return tope == -1;
        }

        // Devuelve la cantidad actual de elementos en la pila
        public int Count()
        {
            return tope + 1;
        }

        // Vacía la pila completamente
        public void Clear()
        {
            elementos = new T[CapacidadInicial];
            tope = -1;
        }
    }
}
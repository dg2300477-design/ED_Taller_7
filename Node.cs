namespace ED_Taller_7
{
    public class Node<T>
    {
        public T Data { get; set; }// Guarda y leer
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }
}
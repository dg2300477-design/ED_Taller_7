/*using System;
using ED_Taller_7;
using EST_Master.Interfaces;

namespace EST_Master.Structures.Stacks
{
    public class StackArray<T> : IStack<T>
    {
        private T[] array;
        private int size;
        private int capacity;

        public StackArray(int initialCapacity = 10)//Constructor
        {
            capacity = initialCapacity;
            array = new T[capacity];
            size = 0;
        }

        public void Push(T data)// Agrega un elemento en top
        {
            if (size == capacity) Resize();//Revisa si la pila esta llena, llama metodo 
            array[size++] = data;//Almacena el valor e incrementa el contador de elemento
        }

        public T Pop()
        {
            //E Extrae el valor y actualiza la pila
            if (IsEmpty()) throw new InvalidOperationException("Pila vacía");
            return array[--size]; 
        }

        public T Peek() => IsEmpty() ? default(T) : array[size - 1]; //Consulta el elemento de top sin extraerlo
        public bool IsEmpty() => size == 0; //Consulta si se tiene elementos en la pila
        public int Count() => size; //Devuelve el numero actual elementos
        public void Clear() => size = 0; //Reinicia la pila

        private void Resize()
        {
            //I Duplica la capacidad, lo hace mas grande y copia los elementos
            capacity *= 2;
            T[] newArray = new T[capacity];
            Array.Copy(array, newArray, size);
            array = newArray;
        }
    }
}*/

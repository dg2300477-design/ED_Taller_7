using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ED_Taller_7
{
    public class StackArray<T> : IStack<T>
    {
        private T[] array;
        private int size;
        private int capacity;

        public StackArray(int Capacity = 4)//Constructor
        {
            capacity = Capacity;
            array = new T[capacity];
            size = 0;
        }

        public void Push(T data)
        {
            if (size == capacity)
            {
                //I Duplica la capacidad, lo hace mas grande y copia los elementos
                capacity *= 2; 
                T[] newArray = new T[capacity]; 
                Array.Copy(array, newArray, size);
                array = newArray;
            }
            array[size] = data;
            size++;
        }

        public T Pop()
        {
            //E reduce el tamaño , guarda el valor, Borra la referencia  -Nulling out references
            if (IsEmpty()) throw new InvalidOperationException("La pila está vacía.");
            size--;
            T data = array[size];
            array[size] = default(T);
            return data; //Devuelve el elemento
        }

        public T Peek()
        {
            if (IsEmpty()) throw new InvalidOperationException("La pila está vacía.");
            return array[size - 1]; //Accede al ultimo elemento ingresado
        }

        public bool IsEmpty() => size == 0;//condicional si no hay elementos

        public int Count() => size; //Devuelve el numero actual elementos

        public void Clear()
        {
            //Se crea un nuevo arreglo y se reinicia la pila
            array = new T[capacity];
            size = 0;
        }
    }
}

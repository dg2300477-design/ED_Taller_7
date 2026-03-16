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

        public StackArray(int Capacity = 4)
        {
            capacity = Capacity;
            array = new T[capacity];
            size = 0;
        }

        public void Push(T data)
        {
            if (size == capacity)
            {
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
            if (IsEmpty()) throw new InvalidOperationException("La pila está vacía.");
            size--;
            T data = array[size];
            array[size] = default(T);
            return data;
        }

        public T Peek()
        {
            if (IsEmpty()) throw new InvalidOperationException("La pila está vacía.");
            return array[size - 1];
        }

        public bool IsEmpty() => size == 0;

        public int Count() => size;

        public void Clear()
        {
            array = new T[capacity];
            size = 0;
        }
    }
}

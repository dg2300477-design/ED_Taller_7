using System;
using ED_Taller_7;
using EST_Master.Interfaces;

namespace EST_Master.Structures.Stacks
{
    public class StackArray<T> : IStack<T>
    {
        private T[] array;
        private int size;
        private int capacity;

        public StackArray(int initialCapacity = 10)
        {
            capacity = initialCapacity;
            array = new T[capacity];
            size = 0;
        }

        public void Push(T data)
        {
            if (size == capacity) Resize();
            array[size++] = data;
        }

        public T Pop()
        {
            if (IsEmpty()) throw new InvalidOperationException("Pila vacía");
            return array[--size];
        }

        public T Peek() => IsEmpty() ? default(T) : array[size - 1];
        public bool IsEmpty() => size == 0;
        public int Count() => size;
        public void Clear() => size = 0;

        private void Resize()
        {
            capacity *= 2;
            T[] newArray = new T[capacity];
            Array.Copy(array, newArray, size);
            array = newArray;
        }
    }
}
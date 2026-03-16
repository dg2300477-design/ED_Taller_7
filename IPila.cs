using System;

namespace ED_Taller_7
{
    public interface IPila<T>
    {
        void Push(T data);
        T Pop();
        T Peek();
        bool IsEmpty();
        int Count();
        void Clear();
    }
}
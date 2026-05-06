using System;
using System.Collections.Generic;
using System.Text;

namespace ED_Taller_7.ED_Taller_7.Interfaces
{
    internal interface IStack<T>
    {
        void Push(T data);
        T Pop();
        T Peek();
        bool IsEmpty();
        int Count();
        void Clear();
    }
}

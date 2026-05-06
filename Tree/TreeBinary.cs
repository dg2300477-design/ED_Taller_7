using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;

namespace ED_Taller_7.ED_Taller_7.Tree
{
    public class TreeBinary<T> : Interfaces.ITree<T> where T : IComparable<T> 
    {
        public required NodeTree<T> Root;

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T data)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public NodeTree<T>? GetRoot()
        {
            throw new NotImplementedException();
        }

        public int Height()
        {
            throw new NotImplementedException();
        }

        public void InOrder()
        {
            throw new NotImplementedException();
        }

        public void Insert(T data)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public void LevelOrder()
        {
            throw new NotImplementedException();
        }

        public T Max()
        {
            throw new NotImplementedException();
        }

        public T Min()
        {
            throw new NotImplementedException();
        }

        public void PostOrder()
        {
            throw new NotImplementedException();
        }

        public void PreOrder()
        {
            throw new NotImplementedException();
        }

        public T Remove(T data)
        {
            throw new NotImplementedException();
        }
    }
}

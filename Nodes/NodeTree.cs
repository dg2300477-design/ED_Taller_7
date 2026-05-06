using System;
using System.Collections.Generic;
using System.Text;

namespace ED_Taller_7.ED_Taller_7.Nodes
{
    internal class NodeTree<T>
    {
        public T Value;
        public NodeTree<T> left;
        public NodeTree<T> right;

        public NodeTree(T value)
        {
            Value = value;
            left = null;
            right = null;
        }
    }
}

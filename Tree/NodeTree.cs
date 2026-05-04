using System;

namespace ED_Taller_7.Nodes
{
    public class NodeTree<T> where T : IComparable<T>
    {
        public T Data { get; set; }
        public NodeTree<T>? Left { get; set; }
        public NodeTree<T>? Right { get; set; }
        public int Height { get; set; }

        public NodeTree(T data)
        {
            Data = data;
            Left = null;
            Right = null;
            Height = 1;
        }
    }
}
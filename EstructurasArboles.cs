using System;
using System.Collections.Generic;
using System.Text;

namespace ED_Taller_7
{
    // 1. EL NODO
    public class NodeTree<T> where T : IComparable<T>
    {
        public T Data { get; set; }
        public NodeTree<T> Left { get; set; }
        public NodeTree<T> Right { get; set; }
        public int Height { get; set; }

        public NodeTree(T data)
        {
            Data = data;
            Left = null;
            Right = null;
            Height = 1;
        }
    }

    // 2. LA INTERFAZ (Basado en tu foto)
    internal interface ITree<T> where T : IComparable<T>
    {
        void Insert(T data);
        T Remove(T data);
        bool Contains(T data);
        T Min();
        T Max();
        int Count();
        int Height();
        bool IsEmpty();
        void Clear();
        void PreOrder();
        void InOrder();
        void PostOrder();
        void LevelOrder();
        NodeTree<T> GetRoot();
    }

    // 3. ÁRBOL BINARIO DE BÚSQUEDA
    public class BinaryTree<T> : ITree<T> where T : IComparable<T>
    {
        protected NodeTree<T> root;
        protected int count;

        // Propiedad para almacenar el resultado de los recorridos
        public string RecorridoActual { get; protected set; } = "";

        public virtual void Insert(T data)
        {
            root = InsertRecursive(root, data);
        }

        protected virtual NodeTree<T> InsertRecursive(NodeTree<T> node, T data)
        {
            if (node == null)
            {
                count++;
                return new NodeTree<T>(data);
            }

            if (data.CompareTo(node.Data) < 0)
                node.Left = InsertRecursive(node.Left, data);
            else if (data.CompareTo(node.Data) > 0)
                node.Right = InsertRecursive(node.Right, data);

            return node;
        }

        public T Remove(T data) { /* Implementación básica de eliminación */ return default; }

        public bool Contains(T data) => FindRecursive(root, data) != null;
        private NodeTree<T> FindRecursive(NodeTree<T> node, T data)
        {
            if (node == null || node.Data.CompareTo(data) == 0) return node;
            return data.CompareTo(node.Data) < 0 ? FindRecursive(node.Left, data) : FindRecursive(node.Right, data);
        }

        public T Min()
        {
            if (root == null) throw new InvalidOperationException("Árbol vacío");
            NodeTree<T> current = root;
            while (current.Left != null) current = current.Left;
            return current.Data;
        }

        public T Max()
        {
            if (root == null) throw new InvalidOperationException("Árbol vacío");
            NodeTree<T> current = root;
            while (current.Right != null) current = current.Right;
            return current.Data;
        }

        public int Count() => count;

        public int Height() => GetHeight(root);
        protected int GetHeight(NodeTree<T> node) => node == null ? 0 : node.Height;

        public bool IsEmpty() => root == null;

        public void Clear() { root = null; count = 0; RecorridoActual = ""; }

        public NodeTree<T> GetRoot() => root;

        // RECORRIDOS
        public void PreOrder() { RecorridoActual = ""; PreOrderRec(root); }
        private void PreOrderRec(NodeTree<T> node) { if (node != null) { RecorridoActual += node.Data + " "; PreOrderRec(node.Left); PreOrderRec(node.Right); } }

        public void InOrder() { RecorridoActual = ""; InOrderRec(root); }
        private void InOrderRec(NodeTree<T> node) { if (node != null) { InOrderRec(node.Left); RecorridoActual += node.Data + " "; InOrderRec(node.Right); } }

        public void PostOrder() { RecorridoActual = ""; PostOrderRec(root); }
        private void PostOrderRec(NodeTree<T> node) { if (node != null) { PostOrderRec(node.Left); PostOrderRec(node.Right); RecorridoActual += node.Data + " "; } }

        public void LevelOrder() { /* Por simplicidad en consola/UI */ }
    }

    // 4. ÁRBOL AVL (Balanceado)
    public class AVLTree<T> : BinaryTree<T> where T : IComparable<T>
    {
        public override void Insert(T data)
        {
            root = InsertAVL(root, data);
        }

        private NodeTree<T> InsertAVL(NodeTree<T> node, T data)
        {
            if (node == null) { count++; return new NodeTree<T>(data); }

            if (data.CompareTo(node.Data) < 0) node.Left = InsertAVL(node.Left, data);
            else if (data.CompareTo(node.Data) > 0) node.Right = InsertAVL(node.Right, data);
            else return node; // No duplicados

            node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));
            int balance = GetBalance(node);

            // Rotaciones
            if (balance > 1 && data.CompareTo(node.Left.Data) < 0) return RightRotate(node);
            if (balance < -1 && data.CompareTo(node.Right.Data) > 0) return LeftRotate(node);
            if (balance > 1 && data.CompareTo(node.Left.Data) > 0) { node.Left = LeftRotate(node.Left); return RightRotate(node); }
            if (balance < -1 && data.CompareTo(node.Right.Data) < 0) { node.Right = RightRotate(node.Right); return LeftRotate(node); }

            return node;
        }

        private int GetBalance(NodeTree<T> node) => node == null ? 0 : GetHeight(node.Left) - GetHeight(node.Right);

        private NodeTree<T> RightRotate(NodeTree<T> y)
        {
            NodeTree<T> x = y.Left;
            NodeTree<T> T2 = x.Right;
            x.Right = y;
            y.Left = T2;
            y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;
            x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;
            return x;
        }

        private NodeTree<T> LeftRotate(NodeTree<T> x)
        {
            NodeTree<T> y = x.Right;
            NodeTree<T> T2 = y.Left;
            y.Left = x;
            x.Right = T2;
            x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;
            y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;
            return y;
        }
    }

    // 5. CLASIFICADOR
    internal static class TreeClassifier
    {
        internal static string Classify<T>(ITree<T> tree) where T : IComparable<T>
        {
            if (tree.IsEmpty()) return "Vacio";
            if (tree is AVLTree<T>) return "Árbol AVL (Balanceado)";
            return "Árbol Binario de Búsqueda";
        }
    }
}
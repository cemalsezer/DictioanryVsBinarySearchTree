using System;

namespace DictionaryVsBinarySearchTree
{
    public class Node
    {
        public int Key;
        public Node Left, Right;

        public Node(int key)
        {
            Key = key;
            Left = Right = null;
        }
    }

    public class BinarySearchTree
    {
        public Node Root;

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Insert(int key)
        {
            Root = InsertRec(Root, key);
        }

        private Node InsertRec(Node root, int key)
        {
            if (root == null)
            {
                root = new Node(key);
                return root;
            }

            if (key < root.Key)
            {
                root.Left = InsertRec(root.Left, key);
            }
            else if (key > root.Key)
            {
                root.Right = InsertRec(root.Right, key);
            }

            return root;
        }

        // Düzeltilmiş Search metodu
        public bool Search(int key)
        {
            return SearchRec(Root, key);  // Hem Root hem de key gönderiliyor
        }

        // Arama işlemi için recursive fonksiyon
        private bool SearchRec(Node root, int key)
        {
            if (root == null)
            {
                return false;
            }
            if (root.Key == key)
            {
                return true;
            }
            if (key < root.Key)
            {
                return SearchRec(root.Left, key);
            }
            else
            {
                return SearchRec(root.Right, key);
            }
        }
    }
}

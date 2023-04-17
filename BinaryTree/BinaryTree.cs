using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node<T> where T : IComparable<T>
    {
        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

    public class Tree<T> where T : IComparable<T>
    {
        private Node<T> root;

        public Tree()
        {
            root = null;
        }

        public void Add(T data)
        {
            Node<T> newNode = new(data);

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node<T> current = root;

                while (true)
                {
                    if (newNode.Data.CompareTo(current.Data) < 0)
                    {
                        if (current.Left == null)
                        {
                            current.Left = newNode;
                            break;
                        }
                        else
                        {
                            current = current.Left;
                        }
                    }
                    else
                    {
                        if (current.Right == null)
                        {
                            current.Right = newNode;
                            break;
                        }
                        else
                        {
                            current = current.Right;
                        }
                    }
                }
            }
        }

        public bool Search(T data)
        {
            Node<T> current = root;

            while (current != null)
            {
                if (data.CompareTo(current.Data) == 0)
                {
                    return true;
                }
                else if (data.CompareTo(current.Data) < 0)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }

            return false;
        }
    }
}

using System;
using System.Collections.Generic;
namespace beetree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B tree by perryizgr8");
            Console.ReadKey(true);
        }
    }
    class Node<A, B>
    {
        List<KeyValuePair<int, IntPtr>> Keys;
        List<Node<A, B>> Children;
        public Node()
        {
            Keys = new List<KeyValuePair<int, IntPtr>>();
            Children = new List<Node<A, B>>();
        }
        public int getNumberOfKeys()
        {
            return Keys.Count;
        }
        public bool isLeaf()
        {
            if (Children.Count == 0)
                return true;
            else
                return false;
        }
    }
    class Btrie<A, B>
    {
        Node<A, B> rootNode;
        int degree;
        public Btrie(int degree)
        {
            if(degree < 2)
            {
                throw new System.ArgumentOutOfRangeException("degree", "Degree must be at least 2.");
            }
            this.degree = degree;
            rootNode = new Node<A, B>();
        }
    }
}

using System;
using System.Collections.Generic;
namespace beetree
{
    class Program
    {
        static void Main(string[] args)
        {
            int degree = 0;
            Btrie<int, IntPtr> Trie;
            string input;
            Console.WriteLine("Degree?");
            input = Console.ReadLine();
            Int32.TryParse(input, out degree);
            Console.WriteLine("Creating a B tree of degree {0:0}...", degree);
            try
            {
                Trie = new Btrie<int, IntPtr>(degree);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Trie not created.");
            }
            Console.WriteLine("Done.");
            Console.ReadKey();
        }
    }
    class Btrie<A, B>
    {
        Node<A, B> rootNode;
        int degree;
        public Btrie(int degree)
        {
            if (degree < 2)
            {
                throw new System.ArgumentOutOfRangeException("degree", "Degree must be at least 2.");
            }
            this.degree = degree;
            rootNode = new Node<A, B>();
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
}

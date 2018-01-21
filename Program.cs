using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = null;
            BSTree elements = new BSTree();
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i=0;i<n;i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
               root= elements.insert(arr[i], root);
            }
            Console.WriteLine("...........................");
           // Console.Write(root.data);
            Node temp = elements.search(3, root);
          
            Node successor = elements.predecessor(root, 3);
            Console.WriteLine("predes" + successor.data);
          
            elements.inorder(root);
            int k = elements.Height(root);

           Console.WriteLine("height of the tree" + k);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class BSTree
    {
        public Node insert(int n,Node root)
        {
           //if(temp==null)
           // {
           //     temp = new Node();
           //     temp.data = n;
           //     temp.left = null;
           //     temp.right = null;
           //     if(root==null)
           //     {
           //         root = temp;
           //     }
           // }
           // else
           // {
           //     if(temp.left!=null && temp.data>n)
           //     {
           //         insert(n, temp.left);
           //     }
           //     if(temp.right!=null && temp.data>n)
           //     {
           //         insert(n, temp.right);
           //     }
           // }
           if(root==null)
            {
                root = new Node();
                root.data = n;
            }
          else if(n<root.data)
            {
              root.left=  insert(n, root.left);
            }
            else
            {
               root.right= insert(n, root.right);
            }
            return root;

        }


        public Node search(int n, Node root)
        {
           
            if (root == null || root.data == n)
                return root;
            else if (n < root.data)
                return search(n, root.left);
                    return search(n, root.right);
            
        }


        public Node inorder(Node root)
        {
            if (root == null)
                return root;
            inorder(root.left);
            Console.WriteLine(root.data);
            inorder(root.right);
            return root;
        }


        public Node InorderSuccessor(Node root)
        {
            Node temp = min(root.right);
            return temp;   
        }


        public Node min(Node root)
        {
            Node temp = new Node();
            temp = root;
            while (temp != null)
            {
                temp = temp.left;
            }
            return temp;

        }

        public Node predecessor(Node node,int n)
        {
           if(node.data==n||node==null)
            {
                return node;
            }
          if(node.left.data==n||node.right.data==n)
            {
                return node;
            }
          else if(n<node.data)
            {
                return predecessor(node.left, n);
            }
            return predecessor(node.right, n);
        }


        public int Height(Node root)
        {
           if(root==null)
            {
                return 0;
            }
           else if(root.left==null&& root.right==null)
            {
                return 0;
            }
           else
            {
                int l, r;
                l = Height(root.left);
                r = Height(root.right);
                l = l > r ? l : r;
                return (1 + l);
            }
        }


        public int delete(int n, Node node)
        {
            Node temp = predecessor(node, n);
            if(temp==null)
            {
                Console.WriteLine("No such data is available");
                return 0;
            }
         else   if(temp.left.left==null&& temp.right.right==null)
            {
                temp.left = null;
                temp.right = null;
            }
          else  if(temp.left.left!=null&&temp.right.right==null)
            {
                temp = temp.left.left;
                return 1;
            }
         else   if(temp.left.left==null&&temp.right.right!=null)
            {
                temp = temp.right.right;
                return 1;
            }
           else if(temp.left.data==n)
            {
                Node mini = min(temp.left.right);
                mini.left = temp.left.left;
                temp.left = mini;
                return 1;
            }
            else if(temp.right.data==n)
            {
                Node mini = min(temp.right.right);
                temp = mini;
               
            }
            return 1;

            //Node temp = predecessor(node,n);
            //if (node == null)
            //{
            //    return 0;
            //}
            //else if (node.left != null && node.right == null)
            //{
            //    temp = node.left;
            //    Console.WriteLine(temp.data);
            //    return 0;
            //}
            //else if (node.left == null && node.right == null)
            //{
            //    node = null;
            //    return 0;
            //}
            //else if (node.left == null && node.right != null)
            //{
            //    node = node.right;
            //    return 0;
            //}
            //else
            //{
            //    Node temp2;
            //    temp2 = InorderSuccessor(node);
            //    node = temp2;
            //    temp = null;
            //    return 1;

            //}



        }
    }
}

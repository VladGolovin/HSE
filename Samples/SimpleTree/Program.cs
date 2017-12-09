using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTree
{
    class Program
    {
        static void Main(string[] args)
        {

            TreeNode root = null;

            AddNode(ref root, 5);
            AddNode(ref root, 10);
            AddNode(ref root, 15);
            AddNode(ref root, 14);
            AddNode(ref root, 4);
            AddNode(ref root, 3);
            AddNode(ref root, 20);

            TreeNode node = FindNode(root, 14);
            TreeNode node1 = FindNode(root, 3);
            TreeNode node2 = FindNode(root, 555);

            TreeNode node3 = FindNodeRecursive(root, 14);
            TreeNode node4 = FindNodeRecursive(root, 3);
            TreeNode node5 = FindNodeRecursive(root, 555);

            PrintTree(root, 0, 40);

            Console.WriteLine();

        }

        /// <summary>
        /// Добавление новой вершины.
        /// </summary>
        /// <param name="root">Корень.</param>
        /// <param name="info">Значение.</param>
        /// <returns></returns>
        static TreeNode AddNode(ref TreeNode root, int info)
        {
            if (root == null)
            {
                root = new TreeNode(info);

                return root;
            }

            TreeNode node = root;

            bool nodeAdded = false;

            while (!nodeAdded)
            {
                if (info < node.Info)
                {
                    if (node.Left == null)
                    {
                        node.Left = new TreeNode(info);
                        nodeAdded = true;
                    }
                    else
                    {
                        node = node.Left;
                    }
                }
                else
                {
                    if (node.Right == null)
                    {
                        node.Right = new TreeNode(info);
                        nodeAdded = true;
                    }
                    else
                    {
                        node = node.Right;
                    }
                }
            }

            return root;
        }

        /// <summary>
        /// Поиск вершины дерева по информационному полю (итерационно).
        /// </summary>
        /// <param name="root">Корень.</param>
        /// <param name="info">Значение.</param>
        /// <returns></returns>
        static TreeNode FindNode(TreeNode root, int info)
        {
            if (root == null)
            {
                return null;
            }

            TreeNode node = root;

            while (node != null)
            {
                if (info < node.Info)
                {
                    if (node.Left == null)
                    {
                        return null;
                    } 
                    else
                    {
                        node = node.Left;
                    }
                }
                else if (info > node.Info)
                {
                    if (node.Right == null)
                    {
                        return null;
                    }
                    else
                    {
                        node = node.Right;
                    }
                }
                else
                {
                    return node;
                }
            }

            return node;
        }

        /// <summary>
        /// Поиск вершины дерева по информационному полю (рекурсивно).
        /// </summary>
        /// <param name="root">Корень.</param>
        /// <param name="info">Значение.</param>
        /// <returns></returns>
        static TreeNode FindNodeRecursive(TreeNode root, int info)
        {
            if (root == null)
                return null;
            if (info < root.Info)
                return FindNodeRecursive(root.Left, info);
            if (info > root.Info)
                return FindNodeRecursive(root.Right, info);
            if (info == root.Info)
                return root;
            return null;
        }

        /// <summary>
        /// Вывод дерева в консоль.
        /// </summary>
        /// <param name="root">Корень.</param>
        /// <param name="y">Координаты по OX.</param>
        /// <param name="x">Координаты по OY.</param>
        static void PrintTree(TreeNode root, int y, int x)
        {
            if (root == null)
                return;

            Console.SetCursorPosition(x, y);
            Console.Write(root.Info);

            if (root.Left != null)
            {
                Console.SetCursorPosition(x - 7, y);
                Console.Write("+-------");
            }

            if (root.Right != null)
            {
                Console.SetCursorPosition(x + 2, y);
                Console.Write("-------+");
            }

            PrintTree(root.Left, y + 1, x - 7);
            PrintTree(root.Right, y + 1, x + 7);
        }
    }
}

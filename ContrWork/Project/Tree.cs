using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContrWork.Project
{
    public class TreeNode
    {
        public int Value;
        public TreeNode? Left;
        public TreeNode? Right;
        //Конструктор
        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class BinaryTree
    {
        public TreeNode? Root;
        //Конструктор
        public BinaryTree()
        {
            Root = null;
        }
        //Метод доабвления узла в дерево
        public void AddNode(int val)
        {
            TreeNode newNode = new TreeNode(val);

            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                InsertNode(Root, newNode);
            }
        }

        private void InsertNode(TreeNode node, TreeNode newNode)
        {
            if (newNode.Value < node.Value)
            {
                if (node.Left == null)
                {
                    node.Left = newNode;
                }
                else
                {
                    InsertNode(node.Left, newNode);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = newNode;
                }
                else
                {
                    InsertNode(node.Right, newNode);
                }
            }
        }
    }
}

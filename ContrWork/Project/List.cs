using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContrWork.Project
{
    public class ListNode
    {
        public int Value;
        public ListNode? Next;
        //Конструктор
        public ListNode(int value = 0, ListNode? next = null)
        {
            Value = value;
            Next = next;
        }
    }

    public class LinkedList
    {
        public ListNode? Head;
        //Конструктор
        public LinkedList()
        {
            Head = null;
        }
        //Метод доабвления узла
        public void AddNode(int val)
        {
            ListNode newNode = new ListNode(val);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                ListNode current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
    }
}

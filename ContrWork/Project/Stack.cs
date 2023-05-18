using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContrWork.Project
{
    public class Stack
    {
        private List<int> stack;
        //Конструктор
        public Stack()
        {
            stack = new List<int>();
        }
        //Метод добавления в Stack
        public void Push(int val)
        {
            stack.Add(val);
        }
        //Удаляет и возвращает объект, находящийся в начале Stack.
        public int Pop()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            int lastIndex = stack.Count - 1;
            int poppedElement = stack[lastIndex];
            stack.RemoveAt(lastIndex);
            return poppedElement;
        }
        //Этот метод аналогичен методу Pop, однако метод Peek не вносит изменения в очередь Stack.
        public int Peek()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return stack[stack.Count - 1];
        }
        //Метод проверки на пустоту Stack.
        public bool IsEmpty()
        {
            return stack.Count == 0;
        }
    }
}

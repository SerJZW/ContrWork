using ContrWork.Project;

class Program
{
    static void Main(string[] args)
    {
        // Пример использования графа
        Graph graph = new Graph();
        graph.AddVertex(1);
        graph.AddVertex(2);
        graph.AddVertex(3);
        graph.AddEdge(1, 2);
        graph.AddEdge(2, 3);
        graph.AddEdge(3, 1);
        var neighbors = graph.GetNeighbors(3);
        foreach (int neighbor in neighbors)
        {
            Console.WriteLine($"Вершина 3 находится рядом с {neighbor}");
        }

        // Пример использования связного списка
        LinkedList list = new LinkedList();
        list.AddNode(1);
        list.AddNode(2);
        list.AddNode(3);
        ListNode? current = list.Head;
        while (current != null)
        {
            Console.WriteLine("List "+ current.Value);
            current = current.Next;
        }

        // Пример использования стека
        Stack stack = new Stack();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        while (!stack.IsEmpty())
        {
            Console.WriteLine("Stack " + stack.Pop());
        }

        // Пример использования двоичного дерева поиска
        BinaryTree tree = new BinaryTree();
        tree.AddNode(2);
        tree.AddNode(1);
        tree.AddNode(3);
        Console.WriteLine($"Корень дерева {tree.Root?.Value}");
    }
}
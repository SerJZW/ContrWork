using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContrWork.Project
{
    public class Graph
    {
        private Dictionary<int, List<int>> adjacencyList;
        //Конструктор
        public Graph()
        {
            adjacencyList = new Dictionary<int, List<int>>();
        }
        //Метод добавление вешины
        public void AddVertex(int vertex)
        {
            adjacencyList[vertex] = new List<int>();
        }
        //Метод добавление связи
        public void AddEdge(int vertex1, int vertex2)
        {
            adjacencyList[vertex1].Add(vertex2);
            adjacencyList[vertex2].Add(vertex1);
        }
        //Метод поиска соседей
        public List<int> GetNeighbors(int vertex)
        {
            return adjacencyList[vertex];
        }
    }
}

using System;

namespace Graph1
{
    class Program
    {
        static void Main(string[] args)
        {
            int graphSize = 10;
            Graph<string> graph = new Graph<string>(graphSize);

            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");
            graph.AddVertex("D");
            graph.AddVertex("E");
            graph.AddVertex("F");
            graph.AddVertex("G");
            graph.AddVertex("H");
            graph.AddVertex("I");
            graph.AddVertex("J");

            for(int i = 0; i < graphSize; i++)
            {
                graph.ShowVertex(i);
            }
        }
    }
}

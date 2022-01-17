using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph1
{
    class Graph<T>
    {
        private int NUM_VERTICES;
        private GraphNode<T>[] vertices;
        private int[,] adjMatrix;
        public int numVerts;

        public Graph(int size)
        {
            this.NUM_VERTICES = size;
            this.vertices = new GraphNode<T>[NUM_VERTICES];
            this.adjMatrix = new int[NUM_VERTICES, NUM_VERTICES];
            numVerts = 0;
            for(int j = 0; j < NUM_VERTICES; j++)
            {
                for (int k = 0; k < NUM_VERTICES - 1; k++)
                {
                    this.adjMatrix[j, k] = 0;
                }
            }
        }

        public void AddVertex(T label)
        {
            this.vertices[this.numVerts] = new GraphNode<T>(label);
            this.numVerts++;
        }

        public void AddEgde(int start, int end)
        {
            this.adjMatrix[start, end] = 1;
            this.adjMatrix[end, start] = 1;
        }

        public void ShowVertex(int v)
        {
            Console.WriteLine(this.vertices[v].Label + " ");
        }
    }
}

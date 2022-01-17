using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph1
{
    internal class GraphNode<T>
    {
        private bool wasVisited;

        private T label;

        public GraphNode(T label)
        {
            this.wasVisited = false;
            this.label = label;
        }

        public T Label
        {
            get { return this.label; }
        }

        public bool WasVisited
        {
            get { return this.wasVisited; }
        }
    }
}

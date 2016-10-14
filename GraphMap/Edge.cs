using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphMap
{
    class Edge
    {
        public Node a;
        public Node b;
        public int cost;

        public Edge(Node a, Node b, int cost)
        {
            this.a = a;
            this.b = b;
            this.cost = cost;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphMap
{
    class Graph
    {
        List<Node> nodeList = new List<Node>();

        public void addUnDir(Node a, Node b, int cost)
        {
            if (!nodeList.Contains(a))
            {
                nodeList.Add(a);
            }
            if (!nodeList.Contains(b))
            {
                nodeList.Add(b);
            }



            Edge edge1 = new Edge(a, b, cost);
            Edge edge2 = new Edge(b, a, cost);
            a.addEdge(edge1);
            b.addEdge(edge2);

        }

        public void addDir(Node a, Node b, int cost)
        {
            Edge edge = new Edge(a, b, cost);
            a.addEdge(edge);

        }
        public void printGraph()
        {
            foreach (Node node in nodeList)
            {
                node.printNeigbors();
            }
        }

    }
}

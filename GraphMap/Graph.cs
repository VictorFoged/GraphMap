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

        public List<Node> findPath(Node start, Node finish)
        {
            int maxint = int.MaxValue;
            Dictionary<Node, float> distances = new Dictionary<Node, float>();
            Dictionary<Node, Node> previous = new Dictionary<Node, Node>();
            SimplePriorityQueue<Node> nodes = new SimplePriorityQueue<Node>();
            

            foreach(Node vertex in nodeList)
            {
                if (vertex == start)
                {
                    distances[vertex] = 0;
                    nodes.Enqueue(vertex, 0);
                }
            }
        }






        /*
        public List<Node> findPath(Node start, Node end)
        {
            int maxint = int.MaxValue;
            Dictionary<Node, int> distances = new Dictionary<Node, int>();
            Dictionary<Node, Node> previous = new Dictionary<Node, Node>();
            Node[] nodes = new Node[nodeList.Count];
            Node smallest;
            List<Node> path = new List<Node>();
            

            foreach (Node node in nodeList)
            {
                if(node == start)
                {
                    distances.Add(node, 0);
                }
                else
                {
                    distances.Add(node, maxint);
                }
            }
            while(nodes.Length > 0)
            {
                nodes = sort(distances);
                smallest = nodes[0];
                if(smallest == end)
                {
                    foreach (KeyValuePair<Node,Node> entry in previous)
                    {
                        path.Add(smallest);
                        smallest = previous[smallest];
                    }
                    return path;
                }
                if (distances[smallest] == maxint)
                {
                    break;
                }
            }


        }
        */

        public Node[] sort(Dictionary<Node, int> distances)
        {
            Node[] keys = new Node[distances.Count];
            int[] value = new int[distances.Count];
            int i = 0;
            foreach (KeyValuePair<Node, int> entry in distances)
            {
                keys[i] = entry.Key;
                value[i] = entry.Value;
                i = i + 1;
            }
            Array.Sort(keys, value);
            
            return keys;
        }


    }
}

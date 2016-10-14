using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphMap
{
    class Node
    {
        List<Edge> neighbors = new List<Edge>();
        public string name;

        public Node(string name)
        {
            this.name = name;
            
        }

        public void addEdge(Edge e)
        {
            neighbors.Add(e);
        }

        public void printNeigbors()
        {
            Console.WriteLine("Neigbors for node " + this.name);
            foreach (Edge edge in neighbors) 
            {
                Console.WriteLine("From " + edge.a.name + " To " + edge.b.name);
            }
            }
        }

    }


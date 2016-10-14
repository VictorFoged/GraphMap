using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphMap
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph();

            Node a = new Node("a");
            Node b = new Node("b");
            Node c = new Node("c");
            Node d = new Node("d");
            Node e = new Node("e");
            Node f = new Node("f");
            

            g.addUnDir(a, b, 10);
            g.addUnDir(a, c, 5);
            g.addUnDir(a, d, 8);
            g.addUnDir(b, c, 2);
            g.addUnDir(b, f, 20);
            g.addUnDir(f, d, 4);
            g.addUnDir(c, e, 9);




            g.printGraph();
            Console.ReadLine();
        }
    }
}

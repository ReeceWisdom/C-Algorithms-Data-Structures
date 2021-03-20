using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13___Graphs
{
    public class Graph<T> where T : IComparable
    {
        private LinkedList<GraphNode<T>> nodes;

        public Graph()
        {
            nodes = new LinkedList<GraphNode<T>>();
        }

        public bool IsEmptyGraph()
        {
            return nodes.Count == 0;
        }

        public bool ContainsGraph(GraphNode<T> node)
        {
            foreach (GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(node.ID) == 0)
                    return true;
            }
            return false;
        }

        public GraphNode<T> GetNodeByID(T id)
        {
            foreach (GraphNode<T> n in nodes)
            {
                if (id.CompareTo(n.ID) == 0)
                    return n;
            }
            return null;
        }

        public void AddNode(T id)
        {
            GraphNode<T> n = new GraphNode<T>(id);
            nodes.AddFirst(n);
        }

        public bool IsAdjacent(GraphNode<T> from, GraphNode<T> to)
        {
            foreach (GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(from.ID) == 0)
                {
                    if (from.GetAdjList().Contains(to.ID))
                        return true;
                }
            }
            return false;
        }

        public void AddEdge(T from, T to)
        {
            //foreach (GraphNode<T> n in nodes)
            {
                //if (from.CompareTo(n.ID) == 0)
                GetNodeByID(from);
                AddEdge(from, to);
            }   
        }

        public void DepthFirstTraverse(T startID, ref List<T> visited)
        {
            LinkedList<T> adj;
            Stack<T> toVisit = new Stack<T>();
            GraphNode<T> current = new GraphNode<T>(startID);
            toVisit.Push(startID);

            while (toVisit.Count != 0)
            {
                //Hint: get current node to the list of visited nodes and add its adjacent nodes (only those not already visited) to toVist
            }
        }

        // Return a list which contains the id's of the nodes that are mothervertices.
        //For example, return the list ['A',C','B'] if the nodes with id’s = A, C and B are mother vertices
        public List<T> mothervertices()
        {
            // Hint: Implement a method Boolean ListEq(List<T> l1, List<T> l2)
            //that only returns true if two lists of type List<T> contain the same elements.
            //Use ListEq and a traversal method (BFS or DFS) to check if a vertex is a mother vertex.
            return null;
        }
    }
}
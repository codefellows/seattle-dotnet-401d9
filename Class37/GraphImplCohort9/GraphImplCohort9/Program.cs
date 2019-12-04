using System;
using System.Collections.Generic;

namespace GraphImplCohort9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Graph<string> graph = new Graph<string>();

            var nd = graph.AddVertex("North Dakota");
            var wa = graph.AddVertex("Washington");
            var mt = graph.AddVertex("Montana");
            var ca = graph.AddVertex("California");
            var ga = graph.AddVertex("Georgia");

             
            graph.AddDirectedEdge(nd, mt, 5);
            graph.AddUndirectedEdge(ca, wa, 20);
            graph.AddDirectedEdge(ga, nd, 11);
            graph.AddUndirectedEdge(ga, mt, 7);
            graph.AddDirectedEdge(ca, ga, 2);

            graph.Print();

            Console.WriteLine("===== GET ALL NEIGHBORS ==== ");

            var listOfEdges = graph.GetNeighbors(ga);
            foreach (var item in listOfEdges)
            {
                Console.WriteLine(item.Vertex.Data);
            }


            Console.WriteLine("== ALL VERTICES! ===");

            var listofVerts = graph.GetAllVertices();

            foreach (var item in listofVerts)
            {
                Console.WriteLine(item.Data);
            }



        }
    }

    class Graph<T>
    {
        public Dictionary<Vertex<T>,List<Edge<T>>> AdjacencyList { get; set; }
        private int _size;

        public Graph()
        {
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
        }

  
        // AddNode(value of Node) -> added node
        public Vertex<T> AddVertex(T data)
        {
            Vertex<T> vertex = new Vertex<T>(data);

            AdjacencyList.Add(vertex,new List<Edge<T>>());
            _size++;
            return vertex;
        }

        // Size() -> return the total number of nodes in the graph

        public int Size()
        {
            return _size;
        }

        // AddEdge(Node a, Node b) adds a new edge b/w nodes. must have weight, Both nodes should be in graph

        public void AddDirectedEdge(Vertex<T> source, Vertex<T> destination, int weight)
        {
            // create an edge and load it up with the dest and the weight
            // find the source in the AL and add the edge to the list

            AdjacencyList[source].Add(
                new Edge<T>
                {
                    Weight = weight,
                    Vertex = destination
                });
        }

        public void AddUndirectedEdge(Vertex<T> source, Vertex<T> destination, int weight)
        {
            // attach Source to destination with weight of our int.
            AddDirectedEdge(source, destination, weight);
            AddDirectedEdge(destination, source, weight);

        }

        // GetNodes() // returns a list of all the nodes

        public List<Vertex<T>> GetAllVertices()
        {
            List<Vertex<T>> vertices = new List<Vertex<T>>();

            foreach (var vertex in AdjacencyList)
            {
                vertices.Add(vertex.Key);
            }

            return vertices;
        }

        // GetNeighbors(Node a) returns a collection of nodes connected to given node. Include weights

        public List<Edge<T>> GetNeighbors(Vertex<T> vertex)
        {
           return AdjacencyList[vertex];
        }

        public void Print()
        {
            foreach (var vertex in AdjacencyList)
            {
                Console.Write($"Vertex:{vertex.Key.Data} -> ");
                foreach (var edge in vertex.Value)
                {
                    Console.Write($"{edge.Vertex.Data}, {edge.Weight} -> ");
                }
                Console.WriteLine("null");
            }
        }

    }

    class Vertex<T>
    {
        public T Data { get; set; }

        public Vertex(T value)
        {
            Data = value;
        }
    }
    class Edge<T>
    {
        public int Weight { get; set; }
        public Vertex<T> Vertex { get; set; }
    }

}

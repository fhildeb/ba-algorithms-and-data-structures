using System.Collections.Generic;
using Model.Base;

namespace Model.List
{
    public class List : IDataContainer
    {
        private IList<Node> nodes;
        public List<Node> Nodes
        {
            get { return new List<Node>(nodes); }
        }
        
        public List(IList<Node> nodes)
        {
            this.nodes = new List<Node>(nodes);
        }

        public List()
        {
            nodes = new List<Node>();
        }

        public void AddNode(Node n)
        {
            nodes.Add(n);
        }
        
        public Node CreateAndAddNode(int value)
        {
            Node n = new Node(value);
            AddNode(n);
            return n;
        }
    }
}
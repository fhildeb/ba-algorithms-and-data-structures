using Model.Base;

namespace Model.Graph
{
	public class Edge : IDataObject
	{
		public Node A { get; private set;}
		public Node B { get; private set;}
		public double weight { get; private set;}

		public Edge (Node A, Node B, double weight)
		{
			this.A = A;
			this.B = B;
			this.weight = weight;
		}

		public string GetName()
		{
			return A.Label + "_" + B.Label;
		}
	}
}


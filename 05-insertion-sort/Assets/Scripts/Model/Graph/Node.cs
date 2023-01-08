using Model.Base;

namespace Model.Graph
{
	public class Node : IDataObject
	{
		public float X { get; private set;}
		public float Y { get; private set; }
		public string Label { get; private set;}

		public Node (float x, float y, string label)
		{
			X = x;
			Y = y;
			Label = label;
		}
	}
}


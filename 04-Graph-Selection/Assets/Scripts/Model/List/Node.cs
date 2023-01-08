using Model.Base;

namespace Model.List
{
    public class Node : IDataObject
    {
        public int Value { get; private set; }

        public Node(int value)
        {
            Value = value;
        }
    }
}
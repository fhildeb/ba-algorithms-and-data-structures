using Actions;
using Model.List;
using UnityEngine;

namespace DefaultNamespace
{
    public class SelectionSort : ListAlgorithm
    {
        public override List generate()
        {
            List list = new List();

            list.CreateAndAddNode(1);
            list.CreateAndAddNode(3);
            list.CreateAndAddNode(5);
            list.CreateAndAddNode(4);
            list.CreateAndAddNode(6);
            list.CreateAndAddNode(2);
            list.CreateAndAddNode(4);
            list.CreateAndAddNode(10);
            list.CreateAndAddNode(8);
            list.CreateAndAddNode(10);
            list.CreateAndAddNode(11);
        
            return list;
        }

        private int findMinimum(Node[] arr, int start)
        {
            int vergleiche = 0;
            visualFeedback(new SetStatusTextAction("Search of the minimum node from "+start));
            int value = arr[start].Value;
            int index = start;
            for (int i = start; i < arr.Length; i++)
            {
                visualFeedback(new SetStatusTextAction("Node "+i+" is checked if it is smaller than "+value));
                vergleiche++;
                if (arr[i].Value < value)
                {
                    value = arr[i].Value;
                    visualFeedback(new ColorizeAction(Color.white,arr[index]));
                    index = i;
                    visualFeedback(new BlinkAction(Color.green,1,0.3f,arr[i]));
                }
                else
                {
                    visualFeedback(new BlinkAction(Color.yellow,1,0.3f,arr[i]));
                }

                if (i == index)
                {
                    visualFeedback(new ColorizeAction(Color.cyan, arr[i]));
                }
            }

            visualFeedback(new SetStatusTextAction("The smallest content "+value+" is located at index "+index+"!"));
            
            visualFeedback(new SetStatusTextAction("Number of comparisons: "+vergleiche));
            
            return index;
        }

        public override void applyAlgorithm(List g)
        {
            Node[] nodes = g.Nodes.ToArray();
            for (int i = 0; i < nodes.Length; i++)
            {
                int min = findMinimum(nodes, i);
                if (i != min)
                {
                    tauscheFelder(nodes, i, min);
                }
            }

            visualFeedback(new ColorizeAction(Color.green,nodes));
            visualFeedback(new SetStatusTextAction("Complete!"));
        }

        private void tauscheFelder(Node[] arr, int pos1, int pos2)
        {
            visualFeedback(new SetStatusTextAction("Swap element with index "+pos1+" with element with index "+pos2));
            visualFeedback(new ExchangeAction(1f,arr[pos1],arr[pos2]));
            Node temp = arr[pos1];
            arr[pos1] = arr[pos2];
            arr[pos2] = temp;
        }
    }
}
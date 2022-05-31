using Actions;
using Model.List;
using UnityEngine;

namespace DefaultNamespace
{
    public class InsertionSort : ListAlgorithm
    {
        public override List generate()
        {
            List list = new List();

            list.CreateAndAddNode(10);
            list.CreateAndAddNode(20);
            list.CreateAndAddNode(30);
            list.CreateAndAddNode(40);
            list.CreateAndAddNode(50);
            list.CreateAndAddNode(60);
            list.CreateAndAddNode(70);
            list.CreateAndAddNode(80);
            list.CreateAndAddNode(1);
            list.CreateAndAddNode(2);
            list.CreateAndAddNode(3);
            list.CreateAndAddNode(4);
            list.CreateAndAddNode(5);
            list.CreateAndAddNode(6);
            list.CreateAndAddNode(7);
            list.CreateAndAddNode(8);
            list.CreateAndAddNode(11);
            list.CreateAndAddNode(22);
            list.CreateAndAddNode(33);
            list.CreateAndAddNode(44);
            list.CreateAndAddNode(55);
            list.CreateAndAddNode(66);
            list.CreateAndAddNode(77);
            list.CreateAndAddNode(88);
            list.CreateAndAddNode(81);
            list.CreateAndAddNode(72);
            list.CreateAndAddNode(63);
            list.CreateAndAddNode(54);
            list.CreateAndAddNode(45);
            list.CreateAndAddNode(36);
            list.CreateAndAddNode(27);
            list.CreateAndAddNode(18);
        
            return list;
        }

        public override void applyAlgorithm(List g)
        {
            int vergleiche = 0;

            Node[] nodes = g.Nodes.ToArray();

            for (int i = 0; i <= nodes.Length - 1; i++)
            {
                visualFeedback(new SetStatusTextAction("Add node "+i));
                Node active = nodes[i];
                visualFeedback(new ColorizeAction(Color.cyan,active));
                for (int j = i; j > 0; j--)
                {
                    vergleiche++;
                    if (nodes[j - 1].Value > nodes[i].Value)
                    {
                        visualFeedback(new BlinkAction(Color.red,1,0.5f,nodes[j-1],nodes[j]));
                        Node temp = nodes[j - 1];
                        nodes[j - 1] = nodes[j];
                        nodes[j] = temp;
                        visualFeedback(new ExchangeAction(1f,nodes[j-1],nodes[j]));
                    }
                    else
                    {
                        visualFeedback(new BlinkAction(Color.green,1,0.5f,nodes[j-1],nodes[j]));
                        break;
                    }
                }
                visualFeedback(new ColorizeAction(Color.gray,active));
            }

            foreach (Node n in nodes)
            {
                visualFeedback(new ColorizeAction(Color.green,n));
            }
            
            visualFeedback(new SetStatusTextAction("Completed with "+vergleiche+" comparisons"));
        }
    }
}
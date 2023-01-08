using System.Collections.Generic;
using Actions;
using Model.Graph;
using UnityEngine;

public class MinimumSpanningTree : GraphAlgorithm
{

	private int[] groups;
	private List<Node> nodes;
	private List<Edge> edges;

	public override Graph generate()
	{
		Graph g = new Graph();

		Node A = g.CreateAndAddNode(-2, 0, "A");
		Node B = g.CreateAndAddNode(-1, 1, "B");
		Node C = g.CreateAndAddNode(-1,-1, "C");
		Node D = g.CreateAndAddNode( 1, 1, "D");
		Node E = g.CreateAndAddNode( 1,-1, "E");
		Node F = g.CreateAndAddNode( 2, 0, "F");
		Node G = g.CreateAndAddNode( 0, 2, "G");
		Node H = g.CreateAndAddNode( 0,-2, "H");

		g.CreateAndAddEdge(A, C, 3);
		g.CreateAndAddEdge(A, B, 8);
		g.CreateAndAddEdge(B, C, 4);
		g.CreateAndAddEdge(G, B, 3);
		g.CreateAndAddEdge(B, D, 1);
		g.CreateAndAddEdge(G, D, 5);
		g.CreateAndAddEdge(B, E, 2);
		g.CreateAndAddEdge(G, D, 5);
		g.CreateAndAddEdge(C, D, 7);
		g.CreateAndAddEdge(C, E, 3);
		g.CreateAndAddEdge(C, H, 5);
		g.CreateAndAddEdge(H, E, 6);
		g.CreateAndAddEdge(D, E, 5);
		g.CreateAndAddEdge(D, F, 4);
		g.CreateAndAddEdge(E, F, 6);

		return g;
	}

	private int find(Node n)
	{
		return groups[nodes.IndexOf(n)];
	}

	private void union(int a, int b, int c)
	{
		List<Node> affected = new List<Node>();

		//Alle Knoten der beiden Gruppen suchen
		for (int i = 0; i < nodes.Count; i++)
		{
			if (groups[i] == a || groups[i] == b)
			{
				affected.Add(nodes[i]);
				//Jeden zugehörigen Knoten in neue Gruppe einordnen
				groups[i] = c;
			}
		}

		//Betroffene Knoten grafisch animieren
		visualFeedback(new SetStatusTextAction("Node "+a+" and "+b+" are classified into group "+c+" !"));
		visualFeedback(new BlinkAction(Color.yellow,1,0.25f,affected.ToArray()));
		visualFeedback(new ChangeLabelAction(""+c,affected.ToArray()));
		visualFeedback(new BlinkAction(Color.yellow,1,0.25f,affected.ToArray()));
		visualFeedback(new SetStatusTextAction(""));
	}

	public override void applyAlgorithm(Graph g)
	{
		nodes = g.Nodes;
		edges = g.Edges;

		groups = new int[nodes.Count];

		IList<Edge> resEdges = new List<Edge>();
		visualFeedback(new SetStatusTextAction("Group assignment"));
		for (int i = 0; i < groups.Length; i++)
		{
			groups[i] = i;
			visualFeedback(new ChangeLabelAction(""+i,nodes[i]));
		}

		int n = groups.Length;
		visualFeedback(new SetStatusTextAction(""));

		edges.Sort((x,y) => x.weight.CompareTo(y.weight));
		int zahl = 0;
		double kosten = 0;
		while (n > 1)
		{
			Edge currentfocus = edges[zahl];
			visualFeedback(new BlinkAction(Color.yellow,1,0.5f,currentfocus));
			int x = find(currentfocus.A);
			int y = find(currentfocus.B);
			if (x != y)
			{
				//Endknoten in unterschiedlichen Gruppen
				visualFeedback(new BlinkAction(Color.green,1,0.5f,currentfocus,currentfocus.A,currentfocus.B));
				visualFeedback(new ColorizeAction(Color.green,currentfocus));
				visualFeedback(new ColorizeAction(Color.gray,currentfocus.A,currentfocus.B));
				//Gruppen verschmelzen
				union(x,y,x);
				resEdges.Add(currentfocus);
				n--;
				zahl++;
				//Kosten für benutzten Knoten hochzählen
				kosten += currentfocus.weight;
			}
			else
			{
				//Beide Knoten in der gleichen Gruppe
				visualFeedback(new BlinkAction(Color.red,1,0.5f,currentfocus,currentfocus.A,currentfocus.B));
				visualFeedback(new ColorizeAction(Color.red,currentfocus));
				//Nächsten Knoten aussuchen
				zahl++;
			}
		}
		visualFeedback(new SetStatusTextAction("Completed. The clamping tree has a cost of "+kosten));
	}
}

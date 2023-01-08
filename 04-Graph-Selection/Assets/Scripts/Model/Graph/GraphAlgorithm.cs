using Model.Base;
using UnityEngine;

namespace Model.Graph
{
    public abstract class GraphAlgorithm : DefaultAlgorithm<Graph>
    {
        public override void visualize(Graph graph, Prefabs pf)
        {
            //draw nodes
            foreach (Node n in graph.Nodes)
            {
                GameObject nodeClone = Object.Instantiate(pf.nodePrefab, new Vector3(n.X, n.Y, 0), Quaternion.identity);
                nodeClone.name = n.Label;
                nodeClone.GetComponentInChildren<TextMesh>().text = n.Label;
                objectMapper.register(n, nodeClone);
            }

            //Draw edges
            foreach (Edge e in graph.Edges)
            {
                GameObject edgeClone = Object.Instantiate(pf.edgePrefab);
                edgeClone.name = e.GetName();

                Vector3 p1 = objectMapper.resolve(e.A).transform.position;
                Vector3 p2 = objectMapper.resolve(e.B).transform.position;

                edgeClone.transform.position = Vector3.Lerp(p1, p2, 0.5f);
                edgeClone.transform.LookAt(p2);

                Vector3 newScale = edgeClone.transform.localScale;
                newScale.z = Vector3.Distance(p1, p2) / 2;
                edgeClone.transform.localScale = newScale;

                objectMapper.register(e, edgeClone);

                GameObject txt = Object.Instantiate(pf.textPrefab);
                txt.transform.position = Vector3.Lerp(p1, p2, 0.33f);
                txt.GetComponentInChildren<TextMesh>().text = "" + e.weight;
            }
        }
    }
}
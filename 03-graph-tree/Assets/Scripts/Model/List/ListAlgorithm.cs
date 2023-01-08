using Model.Base;
using UnityEngine;

namespace Model.List
{
    public abstract class ListAlgorithm : DefaultAlgorithm<List>
    {
        public override void visualize(List list, Prefabs pf)
        {
            int perRow = 7;
            float scale = 0.75f;

            int cnt = list.Nodes.Count;
            int fullR = cnt / perRow;
            int halveR = cnt % perRow;
            int rows = fullR + (halveR > 0 ? 1 : 0);
            int yoffs = rows / 2;
            int xoffs = -perRow / 2;
            int row = 0;
            int nr = 0;

            //draw nodes
            foreach (Node n in list.Nodes)
            {
                GameObject nodeClone = Object.Instantiate(pf.nodePrefab,
                    new Vector3(scale * (nr + xoffs), (-row + yoffs) * scale, 0), Quaternion.identity);
                nr = (nr + 1) % perRow;
                if (nr == 0) row++;
                nodeClone.name = n.Value.ToString();
                nodeClone.GetComponentInChildren<TextMesh>().text = n.Value.ToString();
                objectMapper.register(n, nodeClone);
            }
        }
    }
}
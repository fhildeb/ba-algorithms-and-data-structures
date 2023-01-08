using System.Collections;
using Model.Base;
using UnityEngine;

namespace Actions
{
    public class ColorizeAction : BasicAction
    {
        private IDataObject[] os;
        private Color col;

        public ColorizeAction(Color col, params IDataObject[] os)
        {
            this.os = os;
            this.col = col;
        }

        public override IEnumerator Run()
        {
            foreach (IDataObject x in os)
            {
                GameObject go = mapper.resolve(x);
                go.GetComponentInChildren<Renderer>().material.SetColor("_Color", col);
            }

            yield break;
        }
    }
}
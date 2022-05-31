using System.Collections;
using Model.Base;
using UnityEngine;

namespace Actions
{
    public class ExchangeAction : BasicAction
    {
        private GameObject objA;
        private GameObject objB;
        private Vector3 a;
        private Vector3 b;
        private Vector3 ca;
        private Vector3 cb;
        private float duration;

        public ExchangeAction(float duration, IDataObject a, IDataObject b)
        {
            this.duration = duration;
            this.objA = mapper.resolve(a);
            this.objB = mapper.resolve(b);
        }

        private void generateControlPoints()
        {
            GameObject cam = GameObject.FindWithTag("MainCamera");
            var m = (a + b) / 2;
            var r = (a - b).magnitude / 2;
            var dir = Vector3.Cross(m - cam.transform.position, a - b).normalized;
            ca = m + dir * r;
            cb = m - dir * r;
        }

        public override IEnumerator Run()
        {
            this.a = objA.transform.position;
            this.b = objB.transform.position;
            generateControlPoints();

            float prog;
            float startTime = Time.time;

            do
            {
                prog = (Time.time - startTime) / duration;
                objA.transform.position = bezier(a, b, ca, prog);
                objB.transform.position = bezier(b, a, cb, prog);
                yield return null;
            } while (prog < 1);
        }

        private Vector3 bezier(Vector3 p1, Vector3 p2, Vector3 ctr, float prog)
        {
            Vector3 h1 = Vector3.Lerp(p1, ctr, prog);
            Vector3 h2 = Vector3.Lerp(ctr, p2, prog);
            return Vector3.Lerp(h1, h2, prog);
        }
    }
}
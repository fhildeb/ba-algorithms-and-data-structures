using System.Collections;
using Model.Base;
using UnityEngine;
using UnityEngine.UI;

namespace Actions
{
    public class SetStatusTextAction : BasicAction
    {
        private string txt;

        public SetStatusTextAction(string txt)
        {
            this.txt = txt;
        }


        public override IEnumerator Run()
        {
            GameObject go = GameObject.Find("Status Text");
            go.GetComponentInChildren<Text>().text = txt;

            yield return null;
        }
    }
}
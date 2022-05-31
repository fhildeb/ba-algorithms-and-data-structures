using System.Collections;
using System.Collections.Generic;
using Actions.Base;
using UnityEngine;

namespace Helper
{
	public class AnimationQueue{

		// Singleton
		private static AnimationQueue instance = new AnimationQueue();

		public static AnimationQueue Instance
		{
			get { return instance; }
		}

		// Normal implementation
		public float delaySeconds=0.5f;
		private Queue<IAction> queue = new Queue<IAction> ();

		public void enqueueAction(IAction action)
		{
			queue.Enqueue(action);
		}

		private IEnumerator worker()
		{
			while(true)
			{
				if(queue.Count != 0)
				{
					IAction action = queue.Dequeue();
					yield return action.Run ();
				}
				yield return new WaitForSeconds (delaySeconds);
			}
		}
	
		public void start(MonoBehaviour host)
		{
			host.StartCoroutine(worker());
		}
	}
}
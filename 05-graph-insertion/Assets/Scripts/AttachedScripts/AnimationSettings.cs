using System;
using Helper;
using Model.Base;
using UnityEditor;
using UnityEngine;

namespace AttachedScripts
{
    public class AnimationSettings : MonoBehaviour
    {
        //Script with Algorithm
        public MonoScript algorithm;

        // Needed Prefabs
        public Prefabs prefabs;

        // Delay
        public float delaySeconds = 0.5f;

        //Algorithm and Container
        private IAlgorithm ga;
        private IDataContainer obj;


        void Start()
        {
            //Set up animation quere
            AnimationQueue a = AnimationQueue.Instance;
            a.delaySeconds = delaySeconds;
            a.start(this);

            //Set up the Algorithm
            ga = (IAlgorithm) Activator.CreateInstance(algorithm.GetClass());
            obj = ga.generate();
            ga.visualize(obj, prefabs);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                ga.applyAlgorithm(obj);
            }
        }

    }
}
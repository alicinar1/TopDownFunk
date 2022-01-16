using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownFunk.Manager
{
    public abstract class AbstractScriptableManager<T> : AbstractScriptableManagerBase where T: AbstractScriptableManager<T>
    {
        private static volatile T instance = null;

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = FindObjectOfType(typeof(T)) as T;
                }

                return instance;
            }
        }

        public override void InitializeManager()
        {
            base.InitializeManager();
        }

        public override void DestroyManager()
        {
            base.DestroyManager();
        }
    }
}

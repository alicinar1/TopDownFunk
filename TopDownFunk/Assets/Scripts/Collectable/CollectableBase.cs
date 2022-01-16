using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownFunk.Collectable
{
    public abstract class CollectableBase : MonoBehaviour
    {
        public virtual void OnTriggerEnter(Collider other)
        {

        }
    }
}

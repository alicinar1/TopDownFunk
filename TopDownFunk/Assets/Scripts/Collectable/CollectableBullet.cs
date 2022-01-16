using System;
using System.Collections;
using System.Collections.Generic;
using TopDownFunk.Bullets;
using UnityEngine;

namespace TopDownFunk.Collectable
{
    public class CollectableBullet : CollectableBase
    {
        [SerializeField] private AbstractBulletMono bullet;
        public static event Action<AbstractBulletMono> OnBulletChange;
        public override void OnTriggerEnter(Collider other)
        {
            base.OnTriggerEnter(other);
            OnBulletChange?.Invoke(bullet);
            Destroy(this);
        }
    }
}
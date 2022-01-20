using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownFunk.Bullets;
using TopDownFunk.Statics;
using TopDownFunk.Enemy;

namespace TopDownFunk.Damage
{
    public class DamagebleObjectBase : MonoBehaviour, IDamagable
    {
        [SerializeField] private Collider _collider;
        public int InstanceID { get; private set; }

        private void Awake()
        {
            InstanceID = _collider.GetInstanceID();
            this.InitializeDamageble();
        }
        public virtual void Damage()
        {

        }

        public virtual void Damage(BulletStats bulletStats)
        {

        }

        public virtual void Damage(EnemyStats enemyStats)
        {

        }

        public void DestroyObject()
        {
            //Debug.Log("hellö");
            this.gameObject.SetActive(false);
            this.DestroyDamageble();
        }
    }
}
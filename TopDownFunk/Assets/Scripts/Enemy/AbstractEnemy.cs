using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownFunk.Damage;
using TopDownFunk.Bullets;
using System;

namespace TopDownFunk.Enemy
{
    public abstract class AbstractEnemy : DamagebleObjectBase
    {
        [SerializeField] protected EnemyScriptableObject _enemyScriptableObject;

        [SerializeField] protected string EnemyName;
        [SerializeField] protected string EnemyType;
        [SerializeField] protected string EnemyTag;
        public EnemyStats stats;

        public EnemyScriptableObject Enemy { get { return _enemyScriptableObject; } }


        private void Awake()
        {
            SetEnemy();
          
        }

        public override void Damage(BulletStats bullet)
        {
            base.Damage(bullet);
            if (stats.enemyArmor > 0)
            {
                stats.enemyArmor -= bullet.armorPenentration * bullet.Damage;
            }
            else
            {
                stats.enemyHealth -= bullet.Damage;
            }

            if (stats.enemyHealth <= 0)
            {
                DestroyObject();
            }                  
        }

        protected void SetEnemy()
        {
            SetEnemyStats();
            EnemyName = _enemyScriptableObject.EnemyName;
            EnemyType = _enemyScriptableObject.EnemyType;
            EnemyTag = _enemyScriptableObject.EnemyTag;

            this.transform.name = EnemyName;
            this.transform.tag = EnemyTag;
        }

        private void OnEnable()
        {
            SetEnemyStats();
        }

        protected void SetEnemyStats()
        {
            stats = _enemyScriptableObject.stats;
        }
    }
}
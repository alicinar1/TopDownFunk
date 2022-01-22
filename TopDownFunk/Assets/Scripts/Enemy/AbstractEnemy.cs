using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownFunk.Damage;
using TopDownFunk.Bullets;
using System;
using TopDownFunk.Statics;
using TopDownFunk.UI;

namespace TopDownFunk.Enemy
{
    public abstract class AbstractEnemy : DamagebleObjectBase
    {
        [SerializeField] protected EnemyScriptableObject _enemyScriptableObject;

        [SerializeField] protected string EnemyName;
        [SerializeField] protected string EnemyType;
        [SerializeField] protected string EnemyTag;
        [SerializeField] protected HealtBarController healtBarController; 
        public Stats stats;
        public EnemyStats enemyStats;

        public static event Action<Stats> OnDamageTake;

        public EnemyScriptableObject Enemy { get { return _enemyScriptableObject; } }


        private void Awake()
        {
            SetEnemy();
            healtBarController.SetHealthBar(stats);
        }

        public override void Damage(BulletStats bullet)
        {
            base.Damage(bullet);
            if (stats.Armor > 0)
            {
                stats.Armor -= bullet.armorPenentration * bullet.Damage;
            }
            else
            {
                stats.Health -= bullet.Damage;
            }

            healtBarController.SetHealthBar(stats);

            if (stats.Health <= 0)
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
            stats = _enemyScriptableObject.generalStats;
            enemyStats = _enemyScriptableObject.enemyStats;
        }
    }
}
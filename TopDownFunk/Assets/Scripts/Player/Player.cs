using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownFunk.Damage;
using TopDownFunk.Enemy;
using TopDownFunk.Statics;
using TopDownFunk.UI;
using System;

namespace TopDownFunk.PlayerController
{
    public class Player : DamagebleObjectBase
    {
        [SerializeField] private PlayerScriptableObject _playerScriptableObject;
        [SerializeField] private HealtBarController _healtBar;
        public Stats stats;

        public static event Action<Stats> OnDamageTake;

        private void Start()
        {
            stats = _playerScriptableObject.generalStats;
            _healtBar.SetHealthBar(stats);
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.CompareTag("Enemy"))
            {
                Damage(collision.collider.GetComponent<AbstractEnemy>().enemyStats);
            }
            
        }

        public override void Damage(EnemyStats enemyStats)
        {
            base.Damage(enemyStats);

            if (stats.Armor > 0)
            {
                stats.Armor -= enemyStats.enemyDamage * enemyStats.enemyArmorPenentration;                
            }
            else
            {
                stats.Health -= enemyStats.enemyDamage;
            }

            _healtBar.SetHealthBar(stats);

            if (stats.Health <= 0)
            {
                DestroyObject();
            }
            //Debug.Log(stats.Health);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownFunk.Damage;
using TopDownFunk.Enemy;

namespace TopDownFunk.PlayerController
{
    public class Player : DamagebleObjectBase
    {
        [SerializeField] private PlayerScriptableObject _playerScriptableObject;
        public PlayerStats stats;

        private void Start()
        {
            stats = _playerScriptableObject.stats;
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.CompareTag("Enemy"))
            {
                Damage(collision.collider.GetComponent<AbstractEnemy>().stats);
            }
            
        }

        public override void Damage(EnemyStats enemyStats)
        {
            base.Damage(enemyStats);

            if (stats.PlayerArmor > 0)
            {
                stats.PlayerArmor -= enemyStats.enemyDamage * enemyStats.enemyArmorPenentration;
            }
            else
            {
                stats.PlayerHealth -= enemyStats.enemyDamage;
            }

            if (stats.PlayerHealth <= 0)
            {
                DestroyObject();
            }
            Debug.Log(stats.PlayerHealth);
        }
    }
}

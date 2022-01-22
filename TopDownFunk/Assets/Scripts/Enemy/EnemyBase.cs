using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TopDownFunk.Bullets;
using UnityEngine.AI;
using TopDownFunk.AI;

namespace TopDownFunk.Enemy
{
    public class EnemyBase : AbstractEnemy
    {
        [SerializeField] private NavMeshAgent _enemy;
        [SerializeField] private Transform _target;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.CompareTag("Bullet"))
            {
                Damage(collision.collider.GetComponent<AbstractBulletMono>().BulletStat);
            }
        }

        private void OnEnable()
        {
            _enemy.speed = stats.MovementSpeed;
        }

        private void Update()
        {
            AIManager.Instance.SetAIDestination(_enemy);
           // Debug.Log(_target.position);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace TopDownFunk.Enemy
{
    public class EnemyNavMesh : MonoBehaviour
    {
        [SerializeField] private NavMeshAgent _enemy;
        [SerializeField] private Transform _target;

        private void Update()
        {
            _enemy.SetDestination(_target.position);
        }
    }
}

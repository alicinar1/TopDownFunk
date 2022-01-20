using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownFunk.Manager;
using UnityEngine.AI;

namespace TopDownFunk.AI
{
    public class AIManager : MonoSingleton<AIManager>
    {
        [SerializeField] public Transform _target;
        public void SetAIDestination(NavMeshAgent agent)
        {
            agent.SetDestination(_target.position);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace TopDownFunk.Enemy
{    
    [Serializable]
    public struct EnemyStats 
    {
        public float enemyHealth;
        public float enemyArmorPenentration;
        public float enemyMovementSpeed;
        public float enemyDamage;
        public float enemyArmor;
    }
}

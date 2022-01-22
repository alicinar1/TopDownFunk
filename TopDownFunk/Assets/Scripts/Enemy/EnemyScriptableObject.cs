using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownFunk.Statics;

namespace TopDownFunk.Enemy
{
    [CreateAssetMenu(menuName = "TopDownFunk/Enemy/Enemy")]
    public class EnemyScriptableObject : ScriptableObject
    {
        public string EnemyName;
        public string EnemyType;
        public string EnemyTag;
        public Stats generalStats;
        public EnemyStats enemyStats;
    }
}


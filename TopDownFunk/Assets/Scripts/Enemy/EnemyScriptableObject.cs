using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownFunk.Enemy
{
    [CreateAssetMenu(menuName = "TopDownFunk/Enemy/Enemy")]
    public class EnemyScriptableObject : ScriptableObject
    {
        public string EnemyName;
        public string EnemyType;
        public string EnemyTag;
        public EnemyStats stats;
    }
}


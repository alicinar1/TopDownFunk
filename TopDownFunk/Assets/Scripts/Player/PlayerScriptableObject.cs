using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownFunk.Statics;

namespace TopDownFunk.PlayerController
{
    [CreateAssetMenu(menuName = "TopDownFunk/Player/Player Scriptable Object")]
    public class PlayerScriptableObject : ScriptableObject
    {
        public PlayerStats stats;
        public Stats generalStats;
    }
}


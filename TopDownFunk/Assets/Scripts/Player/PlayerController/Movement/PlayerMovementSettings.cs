using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownFunk.PlayerController
{
    [CreateAssetMenu(menuName = "TopDownFunk/PlayerController/Player Controller Settings")]
    public class PlayerMovementSettings : ScriptableObject
    {
        public float playerMovementSpeed;
        public float playerRotationSpeed;
    }
}
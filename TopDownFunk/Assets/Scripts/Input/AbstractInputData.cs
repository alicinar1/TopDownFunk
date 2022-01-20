using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownFunk.PlayerInput
{
    public abstract class AbstractInputData : ScriptableObject
    {
        public float Horizontal;
        public float Vertical;
        public Vector3 MousePosition;

        public abstract void ProcessInput();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownFunk.PlayerInput
{
    [CreateAssetMenu(menuName = "TopDownFunk/Input/Player Mouse Input Data")]
    public class MousePositionInputData : AbstractInputData
    {
        [SerializeField] private Camera _camera;
        public override void ProcessInput()
        {
            MousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);
        }
    }
}

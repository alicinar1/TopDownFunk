using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownFunk.PlayerInput
{
    [CreateAssetMenu(menuName = "TopDownFunk/Input/Button Input Data")]
    public class ButtonInputData : AbstractInputData
    {
        [SerializeField] private bool buttonActieve;
        [SerializeField] private KeyCode _buttonKeyCode;
        public override void ProcessInput()
        {
            if (buttonActieve)
            {
                KeyBaseControl(_buttonKeyCode, ref Horizontal);
            }
        }

        private void KeyBaseControl(KeyCode positiveKey, ref float value)
        {
            bool positiveActieve = Input.GetKeyDown(positiveKey);

            if (positiveActieve)
            {
                value = 1;
            }
            else
            {
                value = 0;
            }
        }
    }
}

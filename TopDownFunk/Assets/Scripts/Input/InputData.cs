using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownFunk.PlayerInput
{
    [CreateAssetMenu(menuName = "TopDownFunk/Input/Player Input Data")]
    public class InputData : AbstractInputData
    {
        [Header("Axis base control")]
        [SerializeField] private bool _axisActieve;
        [SerializeField] private string AxisNameHorizontal;
        [SerializeField] private string AxisNameVertical;

        [Header("Key base control")]
        [SerializeField] private bool _keyBaseHorizontalActieve;
        [SerializeField] private KeyCode _positiveHorizontalKeyCode;
        [SerializeField] private KeyCode _negativeHorizontalKeyCode;
        [SerializeField] private bool _keyBaseVerticalActieve;
        [SerializeField] private KeyCode _positiveVerticalKeyCode;
        [SerializeField] private KeyCode _negativeVerticalKeyCode;

        public override void ProcessInput()
        {
            if (_axisActieve)
            {
                AxisBaseControl();
            }
            else
            {
                if (_keyBaseHorizontalActieve)
                {
                    KeyBaseControl(_positiveHorizontalKeyCode, _negativeHorizontalKeyCode, ref Horizontal);
                }
                if (_keyBaseVerticalActieve)
                {
                    KeyBaseControl(_positiveVerticalKeyCode, _negativeVerticalKeyCode, ref Vertical);
                }
            }
        }

        private void AxisBaseControl()
        {
            Horizontal = Input.GetAxis(AxisNameHorizontal);
            Vertical = Input.GetAxis(AxisNameVertical);
        }

        private void KeyBaseControl(KeyCode positiveKey, KeyCode negativeKey, ref float value)
        {
            bool positiveActieve = Input.GetKey(positiveKey);
            bool negativeActieve = Input.GetKey(negativeKey);

            if (positiveActieve)
            {
                value = 1;
            }
            else if (negativeActieve)
            {
                value = -1;
            }
            else
            {
                value = 0;
            }
        }

    }
}

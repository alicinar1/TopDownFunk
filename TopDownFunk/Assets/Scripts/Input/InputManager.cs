using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TopDownFunk.PlayerInput
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private AbstractInputData[] _abstractInputDatas;

        private void Update()
        {
            for (int i = 0; i < _abstractInputDatas.Length; i++)
            {
                _abstractInputDatas[i].ProcessInput();
            }
        }
    }
}

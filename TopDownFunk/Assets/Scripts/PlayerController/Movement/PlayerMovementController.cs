using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownFunk.PlayerInput;

namespace TopDownFunk.PlayerController
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private AbstractInputData _playerInputData;
        [SerializeField] private PlayerMovementSettings _playerMovementSettings;
        [SerializeField] private CharacterController _player;

        private void FixedUpdate()
        {
            Vector3 direction = new Vector3(_playerInputData.Horizontal, 0, _playerInputData.Vertical);
            direction.Normalize();
            _player.Move(direction * _playerMovementSettings.playerMovementSpeed *Time.fixedDeltaTime);
        }
    }
}
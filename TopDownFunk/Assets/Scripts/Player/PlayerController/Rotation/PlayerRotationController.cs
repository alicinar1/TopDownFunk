using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownFunk.PlayerInput;

namespace TopDownFunk.PlayerController
{
    public class PlayerRotationController : MonoBehaviour
    {
        [SerializeField] private AbstractInputData _playerInputData;
        [SerializeField] private PlayerMovementSettings _playerMovementSettings;
        [SerializeField] private Transform _player;
        [SerializeField] private Camera _camera;

        private void Update()
        {
            Vector2 lookDirection = new Vector2(_playerInputData.MousePosition.x - _player.position.x, _playerInputData.MousePosition.y - _player.position.z);
            float angle = Mathf.Atan2(lookDirection.x, lookDirection.y) * Mathf.Rad2Deg - 90f;
            _player.rotation = Quaternion.Euler(0, angle, 0);
        }
    }
}

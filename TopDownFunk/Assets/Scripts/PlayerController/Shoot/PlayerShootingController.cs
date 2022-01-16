using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownFunk.PlayerInput;
using TopDownFunk.Manager;
using TopDownFunk.Bullets;

namespace TopDownFunk.PlayerController
{
    public class PlayerShootingController : MonoBehaviour
    {
        [SerializeField] private AbstractInputData _shootingInput;
        [SerializeField] private Transform gunBarrel;
        private float _bulletTimer = 0;

        private void Update()
        {
            if (_shootingInput.Horizontal > 0)
            {
                if (Time.time - _bulletTimer > BulletObjectPool.Instance.GetSampleBullet().BulletFireRate)
                {
                    ScriptableShootingManager.Instance.Shoot(gunBarrel, BulletObjectPool.Instance.GetSampleBullet());
                    _bulletTimer = 0;
                    _bulletTimer += Time.deltaTime;
                }                
            }
            
        }
    }
}

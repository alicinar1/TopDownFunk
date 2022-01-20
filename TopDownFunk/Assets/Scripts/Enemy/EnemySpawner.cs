using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownFunk.Enemy
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private ObjectPool _enemyObjectPool;
        [SerializeField] private Vector2 _range;
        [SerializeField] private float _spawnTime;
        private float _timer;

        private void Update()
        {
            if (_timer > _spawnTime)
            {
                Vector3 position = RandomPosition();
                var obj = _enemyObjectPool.GetObject();
                obj.transform.position = position;
                obj.SetActive(true);

                _timer = 0;
            }
            _timer += Time.deltaTime;
        }

        private Vector3 RandomPosition()
        {
            float degree = Random.Range(-180, 180) * Mathf.Deg2Rad;
            float distance = Random.Range(_range.x, _range.y);
            return new Vector3(distance * Mathf.Cos(degree), 1, distance * Mathf.Sin(degree));
        }
    }
}
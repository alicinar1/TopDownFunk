using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownFunk.Bullets;

namespace TopDownFunk.Manager
{
    [CreateAssetMenu(menuName = "TopDownFunk/Manager/Shooting Manager")]
    public class ScriptableShootingManager : AbstractScriptableManager<ScriptableShootingManager>
    {
        public void Shoot(Transform spawnPosition, AbstractBulletMono bullet)
        {
            Debug.Log(bullet.BulletStat.bulletPerShot);
            for (int i = 0; i < bullet.BulletStat.bulletPerShot; i++)
            {
                GameObject[] bullets = new GameObject[bullet.BulletStat.bulletPerShot];
                bullets[i] = BulletObjectPool.Instance.GetObject().gameObject;
                bullets[i].SetActive(true);
                bullets[i].GetComponent<Rigidbody>().velocity = Vector3.zero;
                bullets[i].transform.position = spawnPosition.position;
                bullets[i].transform.rotation = spawnPosition.rotation;

                Vector3 bulletDirection = spawnPosition.up;
                bullets[i].GetComponent<Rigidbody>().AddForce(bulletDirection * bullet.BulletStat.Speed, ForceMode.Impulse);
            }
        }
    }
}

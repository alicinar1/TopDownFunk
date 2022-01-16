using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownFunk.Bullets
{
    [CreateAssetMenu(menuName = "TopDownFunk/Bullet/Bullet Scriptable Object")]
    public class BulletScriptableObject : ScriptableObject
    {
        //[SerializeField] private BulletObjectPool _bulletObjectPool;
        #region Variables
        [SerializeField] public string bulletName;
        [SerializeField] public string bulletTag;
        [SerializeField] public string bulletType;
        [SerializeField] public Material bulletMaterial;
        [SerializeField] public int bulletPerShot;
        [SerializeField] public int bulletPerMagazine;
        [SerializeField] public float reloadTime;
        [SerializeField] public float bulletSpeedRate;
        [SerializeField] public float bulletInaccuracyRate;
        [SerializeField] public float bulletDamageRate;
        [SerializeField] public float bulletFireRate;
        #endregion


        public void SetBullet(AbstractBulletMono bullet)
        {
            bullet.name = this.bulletName;
            bullet.tag = this.bulletTag;
        }
    }
}

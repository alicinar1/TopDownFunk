using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownFunk.Bullets
{
    public abstract class AbstractBulletMono : MonoBehaviour
    {
        [SerializeField] public BulletScriptableObject bulletScriptableObject;
        public string BulletName { get { return bulletScriptableObject.bulletName; } }
        public string BulletTag { get { return bulletScriptableObject.bulletTag; } }
        public string BulletType { get { return bulletScriptableObject.bulletType; } }
        public Material BulletMaterial { get { return bulletScriptableObject.bulletMaterial; } }
        public int BulletPerShot { get { return bulletScriptableObject.bulletPerShot; } }
        public int BulletPerMagazine { get { return bulletScriptableObject.bulletPerMagazine; } }
        public float ReloadTime { get { return bulletScriptableObject.reloadTime; } }
        public float BulletSpeedRate { get { return bulletScriptableObject.bulletSpeedRate; } }
        public float BulletInaccuracyRate { get { return bulletScriptableObject.bulletInaccuracyRate; } }
        public float BulletDamageRate { get { return bulletScriptableObject.bulletDamageRate; } }
        public float BulletFireRate { get { return bulletScriptableObject.bulletFireRate; } }

        private void OnEnable()
        {
            bulletScriptableObject.SetBullet(this);
        }
    }
}

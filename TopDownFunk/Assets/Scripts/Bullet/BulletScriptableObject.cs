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
        [SerializeField] public Color color;
        

        [SerializeField]private BulletStats _stats;
        public BulletStats bulletStats => _stats;
        #endregion


        public void SetBullet(AbstractBulletMono bullet)
        {
            bullet.name = this.bulletName;
            bullet.tag = this.bulletTag;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownFunk.Bullets;
using TopDownFunk.Collectable;

namespace TopDownFunk.Manager
{
    [CreateAssetMenu(menuName = "TopDownFunk/Manager/Bullet Manager")]
    public class ScriptableBulletManager : AbstractScriptableManager<ScriptableBulletManager>
    {
        [SerializeField] private AbstractBulletMono standartBullet;
        private AbstractBulletMono _actieveBullet;

        public AbstractBulletMono ActieveBullet
        {
            get { return _actieveBullet; }
        }

        public override void InitializeManager()
        {
            base.InitializeManager();
            SetActieveBullet(standartBullet);
            CollectableBullet.OnBulletChange += SetActieveBullet;
            Debug.Log(standartBullet.name);
        }

        public void SetActieveBullet(AbstractBulletMono bullet)
        {
            _actieveBullet = bullet;
            BulletObjectPool.Instance.CleanPool();
            BulletObjectPool.Instance.CreateObjectPool(_actieveBullet);
        }
    }
}

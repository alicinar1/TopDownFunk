using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownFunk.Bullets;

namespace TopDownFunk.Manager
{
    [CreateAssetMenu(menuName = "TopDownFunk/Manager/ObjectPool Manager")]
    public class ScriptableObjectPoolManager : AbstractScriptableManager<ScriptableObjectPoolManager>
    {
        public override void InitializeManager()
        {
            base.InitializeManager();
        }

        public void CreateBulletObjectPool(AbstractBulletMono bullet)
        {
            BulletObjectPool.Instance.CreateObjectPool(bullet);
            Debug.Log("Manager Create object pool");
        }

        public AbstractBulletMono GetObjectFromPool() 
        {
            return BulletObjectPool.Instance.GetObject();
            Debug.Log("Manager get object from object pool");
        }

        public void ClearObjectPool()
        {
            BulletObjectPool.Instance.CleanPool();
            Debug.Log("Manager Clean object pool");
        }
    }
}

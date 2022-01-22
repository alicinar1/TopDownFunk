using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownFunk.Bullets
{
    public class BulletObjectPool : MonoSingleton<BulletObjectPool>
    {
        [SerializeField] private Transform parent;
        [SerializeField] private int poolSize;

        public Queue<AbstractBulletMono> objectQueue = new Queue<AbstractBulletMono>(); 

        public void CreateObjectPool(AbstractBulletMono bullet)
        {
            Debug.Log("Create object pool" + bullet.name);
            for (int i = 0; i < poolSize; i++)
            {
                var obj = Instantiate(bullet, Vector3.zero, Quaternion.identity, this.transform);
                obj.gameObject.SetActive(false);
                objectQueue.Enqueue(obj);
                //Debug.Log(i);
            }
        }

        public void CleanPool()
        {
            if (objectQueue.Count > 0)
            {
                int count = objectQueue.Count;
                for (int i = 0; i < count; i++)
                {
                    Debug.Log(objectQueue.Count);
                    Destroy(objectQueue.Dequeue().gameObject);
                    Debug.Log(i);
                }
            }
            Debug.Log("Clean Function!");
        }

        public virtual AbstractBulletMono GetObject()
        {
            AbstractBulletMono obj = objectQueue.Dequeue();
            objectQueue.Enqueue(obj);
            return obj;
        }

        public AbstractBulletMono GetSampleBullet()
        {
            return objectQueue.Peek();
        }
    }
}

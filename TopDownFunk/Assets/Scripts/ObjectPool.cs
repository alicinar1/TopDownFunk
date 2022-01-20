using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TopDownFunk
{
    public class ObjectPool : MonoSingleton<ObjectPool>
    {
        [SerializeField] private Transform parent;
        [SerializeField] private int poolSize;
        [SerializeField] private GameObject[] gameObjectArray;

        public Queue<GameObject> objectQueue = new Queue<GameObject>();

        private void Start()
        {
            CreateObjectPool();
        }
        public void CreateObjectPool()
        {
            for (int i = 0; i < poolSize; i++)
            {
                var obj = Instantiate(gameObjectArray[Random.Range(0, gameObjectArray.Length)], Vector3.zero, Quaternion.identity, this.transform);
                obj.gameObject.SetActive(false);
                objectQueue.Enqueue(obj);
                Debug.Log(i);
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

        public virtual GameObject GetObject()
        {
            GameObject obj = objectQueue.Dequeue();
            objectQueue.Enqueue(obj);
            return obj;
        }

        public GameObject GetSampleBullet()
        {
            return objectQueue.Peek();
        }
    }
}
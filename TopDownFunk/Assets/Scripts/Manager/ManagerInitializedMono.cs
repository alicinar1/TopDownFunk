using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownFunk.Manager;


namespace TopDownFunk
{
    public class ManagerInitializedMono : MonoBehaviour
    {
        [SerializeField] private AbstractScriptableManagerBase[] _managers;
        private List<AbstractScriptableManagerBase> _initializedManagers;

        private void Start()
        {
            _initializedManagers = new List<AbstractScriptableManagerBase>(_managers.Length);
            //Debug.Log(_managers.Length);
            for (int i = 0; i < _managers.Length; i++)
            {
                //Debug.Log("Inside the loop");
                var instantiated = Instantiate(_managers[i]);
                //Debug.Log(instantiated.GetType());
                instantiated.InitializeManager();
                _initializedManagers.Add(instantiated);
                //Debug.Log(_initializedManagers.Count);
                //Debug.Log(instantiated.name + "initialized");
            }
        }

        private void OnDestroy()
        {
            if (_initializedManagers != null)
            {
                for (int i = 0; i < _initializedManagers.Count; i++)
                {
                    _initializedManagers[i].DestroyManager();
                }
            }
        }


    }
}

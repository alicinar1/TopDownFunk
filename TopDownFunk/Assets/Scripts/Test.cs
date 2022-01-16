using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownFunk.PlayerInput;
using TopDownFunk.Manager;
using TopDownFunk.Bullets;

public class Test : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(ScriptableBulletManager.Instance.name);
    }
}


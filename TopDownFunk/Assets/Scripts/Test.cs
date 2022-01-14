using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownFunk.PlayerInput;

public class Test : MonoBehaviour
{
    [SerializeField] private AbstractInputData abstractInput;

    private void Update()
    {
        if (abstractInput.Horizontal == 1)
        {
            Debug.Log("Falanfilan");
        }
    }
}

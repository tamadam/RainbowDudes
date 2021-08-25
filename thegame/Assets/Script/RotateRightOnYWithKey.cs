using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRightOnYWithKey : MonoBehaviour
{
    [SerializeField]
    KeyCode rotateKey;

    void Update()
    {
        if(Input.GetKeyDown(rotateKey)){
            transform.Rotate(0,-90,0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyPosition : MonoBehaviour
{
    [SerializeField]
    Transform target;

    void Update()
    {
        GetComponent<Transform>().position = target.position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControlledVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;

    [SerializeField]
    KeyCode keyPositive;

    [SerializeField]
    KeyCode keyNegative;

    void Update()
    {
        if (Input.GetKey(keyPositive))  
            GetComponent<Rigidbody>().velocity = 1;

        if (Input.GetKey(keyNegative))
            GetComponent<Rigidbody>().velocity = -1;
    }
}

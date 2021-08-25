using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControlledVelocity : MonoBehaviour
{
    [SerializeField]
    Transform helperObject;

    [SerializeField]
    float speed;

    [SerializeField]
    KeyCode keyForward;

    [SerializeField]
    KeyCode keyBackward;

    [SerializeField]
    KeyCode keyLeft;

    [SerializeField]
    KeyCode keyRight;

    void Update()
    {
        if (Input.GetKey(keyForward))  
            GetComponent<Rigidbody>().velocity += helperObject.forward * speed;
        if (Input.GetKey(keyBackward))  
            GetComponent<Rigidbody>().velocity += -helperObject.forward * speed;
        if (Input.GetKey(keyLeft))  
            GetComponent<Rigidbody>().velocity += -helperObject.right * speed;
        if (Input.GetKey(keyRight))  
            GetComponent<Rigidbody>().velocity += helperObject.right * speed;
    }
}

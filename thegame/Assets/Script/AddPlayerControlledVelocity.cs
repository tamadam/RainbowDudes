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
    
    /*public float speed = 2;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement * speed);
    }*/
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddConstantVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //contact to Rigidbody
        //GetComponent<Rigidbody>().velocity = new Vector3(2, 10, -6); //horizontal, vertical, Z speed
        //GetComponent<Rigidbody>().velocity += new Vector3(0.01f, 0, 0);
        GetComponent<Rigidbody>().velocity += v3Force; //+= framenkent annyival gyorsul
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    /*
    [SerializeField]
    float jumpForce;
    Vector3 jump;
    bool isGrounded;
    Rigidbody rb;

    void Start(){
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
        isGrounded = false;
    }

    void OnCollisionEnter(){
        isGrounded = true;
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded){
            isGrounded = false;
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
        }
    }
    */

    private Rigidbody rb;

    public LayerMask groundLayers;

    public float jumpForce = 7;

    public SphereCollider col;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<SphereCollider>();
    }

    void Update()
    {
        if(IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private bool IsGrounded()
    {
        return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x,
            col.bounds.min.y, col.bounds.center.z), col.radius * .9f, groundLayers);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    [SerializeField]
    string strTag;
    private void OnCollisionEnter(Collision collision){
        if(collision.collider.tag == strTag){
            Object.Destroy(gameObject,0.5f);
        }
    }
}

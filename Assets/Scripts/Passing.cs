using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passing : MonoBehaviour
{
    Renderer renderer;
    BoxCollider boxCollider;
    [SerializeField] GameObject player;

    private void Start() {
        renderer = GetComponent<Renderer>();
        boxCollider = GetComponent<BoxCollider>();
    }

    private void OnCollisionEnter(Collision other) {
        
        if(other.transform.tag=="Player" && renderer.material.color == Color.red )
        {
            boxCollider.isTrigger = true;
        }
    }
    // public void LetingPass()
    // {
    //     if(transform.tag=="Player" && renderer.material.color == Color.red )
    //     {
    //         boxCollider.isTrigger = true;
    //     }
    // }
}

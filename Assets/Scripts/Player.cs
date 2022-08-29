using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void FixedUpdate() {
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xDirection*Time.deltaTime*speed,0.0f,zDirection*Time.deltaTime*speed);

        transform.position += moveDirection;
    }
}

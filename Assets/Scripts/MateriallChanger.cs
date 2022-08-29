using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MateriallChanger : MonoBehaviour
{
    private Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("z"))
        {
            renderer.material.color = Color.red;
        }

        if(Input.GetKey("c"))
        {
            renderer.material.color = Color.yellow;
        }

        if(Input.GetKey("v"))
        {
            renderer.material.color = Color.black;
        }
    }
}

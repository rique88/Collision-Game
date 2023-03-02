using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingCube : MonoBehaviour
{
     private Rigidbody rigidbody;
    private MeshRenderer mr;
    float timeToFall;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;


        mr = GetComponent<MeshRenderer>();
        mr.enabled = false;  
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >=timeToFall)
        {
            rigidbody.useGravity = true;
            mr.enabled=true;    
        }
    }

   
}

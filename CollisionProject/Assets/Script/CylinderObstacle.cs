using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderObstacle : MonoBehaviour
{
    public float rotationForce = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotationForce * Time.deltaTime);
    }
}

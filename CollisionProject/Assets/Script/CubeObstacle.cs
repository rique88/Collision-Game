using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeObstacle : MonoBehaviour
{
    public float moveForce = 10;
    private Vector3 direction = Vector3.back;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * moveForce * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            direction *= -1;
        }
    }
}

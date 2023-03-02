using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float moveX;
    float moveZ;
    public int force;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Vertical");
        moveZ = Input.GetAxis("Horizontal");
        transform.Translate(moveX * force * Time.deltaTime, 0, moveZ * -1 *force * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            gameObject.transform.position = new Vector3(-39, 1, 0);
        }
    }
}

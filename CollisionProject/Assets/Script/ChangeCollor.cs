using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCollor : MonoBehaviour
{
    public Color startColor;
    public Color colisionColor;
    public float colisionTimer;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = startColor;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            StartCoroutine(ChangeColorCollision());
        }
    }

    IEnumerator ChangeColorCollision()
    {
        float elapsedTime = 0;
        while (elapsedTime < colisionTimer)
        {
            rend.material.color = colisionColor;
            elapsedTime += Time.deltaTime;
            rend.material.color = Color.Lerp(colisionColor, startColor, elapsedTime / colisionTimer);
            yield return null;
        }
        rend.material.color = startColor;

    }
}

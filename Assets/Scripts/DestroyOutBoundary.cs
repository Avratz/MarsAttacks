using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutBoundary : MonoBehaviour
{
    private float horizontalBoundary = 35f;

    void Update()
    {
        float xPosition = transform.position.x;
        if (xPosition < -horizontalBoundary || xPosition > horizontalBoundary)
        {
            Destroy(gameObject);
        }
    }
}

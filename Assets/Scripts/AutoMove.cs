using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private Vector3 direction = Vector3.left;

    private void Update() {
        transform.Translate(direction * (speed * Time.deltaTime), Space.World);
    }
}

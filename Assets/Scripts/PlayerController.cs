using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float speed = 10f;
    private float zBoundary = 10f;
    
    private void Awake() {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        HandlePlayerMovement();
    }

    void HandlePlayerMovement()
    {
        float zPosition = transform.position.z;
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) && zPosition < zBoundary) 
        {
            MovePlayer("up");
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S) && zPosition > -zBoundary)
        {
            MovePlayer("down");
        }
    }

    void MovePlayer(string direction) 
    {
        Vector3 movementDirection = Vector3.forward;

        if (direction == "down")
        {
            movementDirection = Vector3.back;
        }

        _rigidbody.MovePosition(transform.position + movementDirection * (Time.deltaTime * speed));
    }
}

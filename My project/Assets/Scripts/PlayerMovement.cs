using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // The speed at which the character moves

    private Vector3 movement; // The movement vector

    private void Update()
    {
        // Get the horizontal and vertical input axes
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Calculate the movement vector based on the input axes
        movement = new Vector3(horizontal, 0f, vertical);

        // Normalize the movement vector to prevent faster movement when moving diagonally
        movement.Normalize();

        // Move the character
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
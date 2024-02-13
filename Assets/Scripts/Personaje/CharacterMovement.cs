using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{

    private Rigidbody rb;

    private Vector2 moveInput;

    private Vector3 movimiento;

    public float movementSpeed;




    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }

    private void OnMover(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }


    void Update()
    {

        movimiento = new Vector3(moveInput.x * movementSpeed, rb.velocity.y, moveInput.y * movementSpeed);

        movimiento = transform.rotation * movimiento;

        rb.velocity = movimiento;
    }
}

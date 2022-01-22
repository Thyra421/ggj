using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;
    public Rigidbody rigidbody;
    private float _rotationY;

    private void Move()
    {
        Vector3 dir = Vector3.zero;
        if (Input.GetKey("w") || Input.GetKey("z"))
            dir += movementSpeed * transform.forward;
        if (Input.GetKey("a") || Input.GetKey("q"))
            dir -= movementSpeed * transform.right;
        if (Input.GetKey("s"))
            dir -= movementSpeed * transform.forward;
        if (Input.GetKey("d"))
            dir += movementSpeed * transform.right;
        rigidbody.MovePosition(transform.position + dir);
    }

    private void RotateView()
    {
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        _rotationY += mouseX;
        Vector3 tmp = transform.eulerAngles;
        tmp.y = _rotationY;
        transform.eulerAngles = tmp;
    }

    private void FixedUpdate()
    {
        RotateView();
        Move();
    }

    private void Start()
    {
        _rotationY = 0;
    }
}
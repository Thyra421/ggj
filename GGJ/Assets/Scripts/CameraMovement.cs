using System;
using TMPro;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float rotationSpeed;
    private float _rotationX;

    private void RotateView()
    {
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;
        _rotationX -= mouseY;
        _rotationX = Mathf.Clamp(_rotationX, -90, 90);
        Vector3 tmp = transform.eulerAngles;
        tmp.x = _rotationX;
        transform.eulerAngles = tmp;
    }

    private void FixedUpdate()
    {
        RotateView();
    }

    private void Start()
    {
        _rotationX = 0;
    }
}
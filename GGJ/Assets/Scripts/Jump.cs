using System;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float jumpForce;

    private bool _isGrounded;

    private void CheckJump()
    {
        if (_isGrounded && Input.GetKey(KeyCode.Space))
        {
            rigidbody.AddForce(0, jumpForce, 0);
            _isGrounded = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (!_isGrounded && other.gameObject.layer != LayerMask.NameToLayer("Body"))
            _isGrounded = true;
    }

    private void Start()
    {
        _isGrounded = true;
    }

    void Update()
    {
        CheckJump();
    }
}
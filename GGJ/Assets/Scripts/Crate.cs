using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour
{
    public Transform ball;

    void Update()
    {
        transform.position = new Vector3(ball.position.x, ball.position.y, -ball.position.z);
    }
}
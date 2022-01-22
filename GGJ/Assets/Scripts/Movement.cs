using UnityEngine;

public class Movement : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("W") || Input.GetKey("Z")) ;
        if (Input.GetKey("A") || Input.GetKey("Q")) ;
        if (Input.GetKey("S")) ;
        if (Input.GetKey("D")) ;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutAtCheckpoint : MonoBehaviour
{
    public Checkpoint checkpoint;
    public GameObject player;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.transform.position = checkpoint.pos;
        }
    }
}

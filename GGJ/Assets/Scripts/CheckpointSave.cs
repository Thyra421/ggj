using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointSave : MonoBehaviour
{
    public Checkpoint checkpoint;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            checkpoint.pos = this.transform.position;
        }
    }
}

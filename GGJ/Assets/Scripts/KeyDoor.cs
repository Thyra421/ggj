using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    public OpenDoor open;

    private IEnumerator WaitAndDestroy()
    {
        yield return new WaitForSeconds(3f);
        Destroy(this);
    }

    void OnGUI()
    {
        if (open.isClose == false)
            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 120, 155, 30), "The door unlocks !");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            open.isClose = false;
            StartCoroutine(WaitAndDestroy());
            Destroy(other.gameObject);
        }
    }
}

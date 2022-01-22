using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogPoint : MonoBehaviour
{
    public float delay = 5.0f; //This implies a delay of 2 seconds.
    public string text;
    private bool enter = false;

    private IEnumerator WaitAndDestroy()
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }

    void OnGUI()
    {
        if (enter)
            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 155, 30), text);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enter = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(WaitAndDestroy());            
        }
    }
}

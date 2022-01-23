using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activatemenu : MonoBehaviour
{
    public GameObject menu;
    void Update()
    {
        if (Input.GetKeyDown("escape") || Input.GetKeyDown(KeyCode.Escape))
        {
            menu.SetActive(!menu.activeSelf);
        }


    }
}

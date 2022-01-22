using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class State_button : MonoBehaviour
{
    bool state = false;
    public Button lone;
    public Button ltwo;
    public Button lthree;
    // Update is called once per frame
    public void check()
    {
        lone.interactable = state;
        ltwo.interactable = state;
        lthree.interactable = state;


    }
}

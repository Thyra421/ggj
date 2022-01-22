using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class State_button : MonoBehaviour
{
    bool state = false;
    public Button btn;
    // Update is called once per frame
    public void Update()
    {
        btn.interactable = state;

        
    }
}

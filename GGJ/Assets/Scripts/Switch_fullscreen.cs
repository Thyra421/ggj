using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Switch_fullscreen : MonoBehaviour { 
   public void Click()
    {
        if (Screen.fullScreen == false)
            Screen.fullScreen = true;
        else
            Screen.fullScreen = false;
    }
}

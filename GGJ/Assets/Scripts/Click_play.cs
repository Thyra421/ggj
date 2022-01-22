using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Click_play : MonoBehaviour
{
    public GameObject main_menu;
    public GameObject level;
    // Start is called before the first frame update
   public void click()
    {
        main_menu.SetActive(false);
        level.SetActive(true);
    }

}

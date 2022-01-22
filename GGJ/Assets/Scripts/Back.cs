using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Back : MonoBehaviour
{
    public GameObject main_menu;
    public GameObject level;

    public void Click()
    {
        main_menu.SetActive(true);
        level.SetActive(false);


    }
}

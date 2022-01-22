using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keep_music : MonoBehaviour
{
    public Object objet;
    void Awake()
    {
        DontDestroyOnLoad(objet);
    }
}

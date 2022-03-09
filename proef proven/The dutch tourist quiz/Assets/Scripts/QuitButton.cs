using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    [SerializeField]
    private Button button;
    public void Quit()
    {
        Application.Quit();
        Debug.Log("it should quit now");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class QuitButton : Buttons
{
    private Action func;
    void Start()
    {
        func += Quit;
        InitializeButton(func);
    }

    // Update is called once per frame
    void Quit()
    {
        Application.Quit();
        Debug.Log("it should quit now");
    }
}

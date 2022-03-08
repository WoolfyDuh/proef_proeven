using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
public class RedirectButton : Buttons
{   [SerializeField]
    private string scene; //in the editor, put in the name of the scene you would like the button to redirect to.
    private Action func;
    void Start()
    {
        func += Redirect; //makes the function below an action
        InitializeButton(func); //initializes the button with the function below. Which will be run when clicked
    }

    // Update is called once per frame
    private void Redirect()
    {
        SceneManager.LoadScene(scene); //redirects to the scene given.
    }
}

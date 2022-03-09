using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class RedirectButton : MonoBehaviour
{   [SerializeField]
    private string scene; //in the editor, put in the name of the scene you would like the button to redirect to.
    [SerializeField]
    private Button button;

    // Update is called once per frame
    public void Redirect()
    {
        SceneManager.LoadScene(scene); //redirects to the scene given.
    }
}

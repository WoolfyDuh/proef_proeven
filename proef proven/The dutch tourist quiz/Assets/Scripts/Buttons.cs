using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Buttons : MonoBehaviour
{
    [SerializeField]
    protected Button button;
    protected static Action action;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    public void TaskOnClick()
    {
        Debug.Log("works");
        action();
    }
    protected void InitializeButton(Action func)
    {
        action = func;
    }
}

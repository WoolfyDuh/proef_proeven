using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionButton : MonoBehaviour
{
    [SerializeField]
    private QuestionHandler Question;
    public void OnClick()
    {
        if (this.gameObject.tag == "Correct")
        {
            Question.Answer(true);
        }
        else 
        {
            Question.Answer(false);
        }
    }
}

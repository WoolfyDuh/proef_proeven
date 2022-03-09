using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject CurrentQuestion;
    [SerializeField]
    private GameObject AnswerA, AnswerB, AnswerC;
    private GameObject[] Answers;
    void Start()
    {
        Answers[0] = AnswerA;
        Answers[1] = AnswerB;
        Answers[2] = AnswerC;

    }
    public void SetQuestion(string question)
    {
        CurrentQuestion.GetComponent<Text>().text = question;
    }
    public void SetAnswers(string Answer1, string Answer2, string Answer3, string CorrectAnswer)
    {
        Text text = RandomAnswer().GetComponent<Text>();
        Text one = text;
        text.text = Answer1;
        Text two = null;
        while (two == null)
        {
            text = RandomAnswer().GetComponent<Text>();
            if (text != one)
            {
                two = text;
                text.text = Answer2;
                Text three = null;
                while (three == null)
                {
                    text = RandomAnswer().GetComponent<Text>();
                    if (text != one && text != two)
                    {
                        three = text;
                        text.text = Answer3;
                    }
                }
            }

        }
    }

    private GameObject RandomAnswer()
    {
       GameObject answer = Answers[Random.Range(0, 3)];
        return answer;
        
    }
    public void WrongAnswer(GameObject Answer)
    {
        if (Answer.gameObject.tag == "Correct")
        {
            //display info about question
            //give points
            //load next question


        }
        else { 
        //display info
        //load next question
        }
    }
}

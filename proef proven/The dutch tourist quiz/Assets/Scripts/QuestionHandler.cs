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
    [SerializeField]
    private Question Question;
    [SerializeField]
    public int i = 1;
    private GameObject[] Answers = new GameObject[3];
    private List<string> Q1;
    private bool question;
    void Start()
    {
        Answers[0] = AnswerA;
        Answers[1] = AnswerB;
        Answers[2] = AnswerC;
        Q1 = Question.GetQuestion(i);
        if (Q1 != null)
        {
            SetQuestion(Q1[0]);
            Debug.Log(Q1[3]);
            SetAnswers(Q1[1], Q1[2], Q1[3]);
        }
   
    }
    public void SetQuestion(string question)
    {
        CurrentQuestion.GetComponent<Text>().text = question;
    }
    public void SetAnswers(string Answer1, string Answer2, string CorrectAnswer)
    {
        GameObject text = RandomAnswer();
        Text one = text.GetComponentInChildren<Text>();
        one.text = Answer1;

        Text two = null;
        while (two == null)
        {
            text = RandomAnswer();
            if (text != one)
            {
                two = text.GetComponentInChildren<Text>();
                two.text = Answer2;
                Text three = null;
                while (three == null)
                {
                    text = RandomAnswer();
                    if (text != one && text != two)
                    {
                        Debug.Log(text);
                        three = text.GetComponentInChildren<Text>();
                        three.text = CorrectAnswer;
                        text.gameObject.tag = "Correct";
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
    private void Update()
    {
        while (Q1 == null)
        {
            Q1 = Question.GetQuestion(i);
        }
        if(Q1 != null && !question)
        {
            SetQuestion(Q1[0]);
            Debug.Log(Q1[3]);
            SetAnswers(Q1[1], Q1[2], Q1[3]);
            question = true;
        }
    }
}

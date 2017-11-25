using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizAnswer : MonoBehaviour
{
    private SubmitQuiz _submitQuiz;

    private void Start()
    {
        _submitQuiz = FindObjectOfType<SubmitQuiz>();
    }

    public enum QuizButtonType
    {
        Correct,
        Incorrect
    }

    public QuizButtonType Type;

    public void SendMyselfTest()
    {
        _submitQuiz.Submit(this);
    }
}

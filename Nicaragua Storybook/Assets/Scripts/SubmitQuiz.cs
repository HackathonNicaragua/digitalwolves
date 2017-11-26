using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class SubmitQuiz : MonoBehaviour
{
    public Quiz.Answer Answer;
    private int index = 0;

    private void Update()
    {
        GetComponent<Button>().onClick.AddListener(CheckIfQuestionIsCorrect);
    }

    private void CheckIfQuestionIsCorrect()
    {
        if (Answer.IsCorrect)
        {
            index++;
            GameObject.Find("Quiz").GetComponent<Quiz>().SetUpQuestions(index);
            Debug.Log("Correct answer!");
            //Dar puntaje
        }
        else
        {
            index++;
            GameObject.Find("Quiz").GetComponent<Quiz>().SetUpQuestions(index);
            Debug.Log("Incorrect answer!");
        }
    }
}

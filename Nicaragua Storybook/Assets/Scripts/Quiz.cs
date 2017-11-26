using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class Quiz : MonoBehaviour
{
    // Using Serializable allows us to embed a class with sub properties in the inspector.
    [Serializable]
    public class Question
    {
        public string QuestionTitle;             //The actual question
        public Answer[] Answers;        //Its answers
        //public bool IsCorrect;

        //Assignment constructor.
        public Question(string questionTitle)
        {
            QuestionTitle = questionTitle;
        }
    }

    [Serializable]
    public class Answer
    {
        public bool IsCorrect;
        public string AnswerText;
    }

    public Transform AnswersContainer; //The order is important
    public Text QuestionTitle;
    public int Score;

    [Tooltip("All questions from the current quiz")] public List<Question> Questions;

    public void ShowQuestion(int index)
    {
        Debug.Log(Questions.Count);

        Debug.Log(Questions[0]);
        Question question = Questions[index];

        var q = question;

        //An array of answer objects
        var ans = q.Answers;

        Debug.Log(ans.Length);

        //Create a new list of answer buttons
        List<Transform> a = new List<Transform>();

        //Get every button from transform container
        foreach (Transform answer in AnswersContainer)
        {
            a.Add(answer);
            Debug.Log(a.Count);
        }

        //Insert an individual answer in each button
        for (int i = 0; i <= 3; i++)
        {
            a[i].GetComponent<AnswerButton>().OwnAnswer = ans[i];
        }
    }

    private void Start()
    {
        ShowQuestion(0);
    }
}
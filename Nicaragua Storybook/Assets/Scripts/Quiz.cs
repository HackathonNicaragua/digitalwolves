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

    public Transform Answers; //The order is important
    public Text QuestionTitle;
    public int Score;

    public List<Question> Questions = new List<Question>();

    private void Start()
    {
       SetUpQuestions(0);
    }


    public void SetUpQuestions(int questionIndex)
    {
        if (questionIndex > Questions.Count - 1) //Doesn't allow to go any further
            return;

        QuestionTitle.text = Questions[questionIndex].QuestionTitle;

        var index = 0;

        foreach (Transform answer in Answers)
        {
            answer.GetComponent<QuestionButton>().Question = Questions[questionIndex].Answers[questionIndex];
            answer.GetChild(0).GetComponent<Text>().text = Questions[questionIndex].Answers[index].AnswerText;
            index++;
        }

        Debug.Log("We are at question: " + questionIndex);
    }
}
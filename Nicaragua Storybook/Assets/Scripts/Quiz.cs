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
    public float Score; //No tiene funcionalidad... RIP

    [Tooltip("All questions from the current quiz")] public List<Question> Questions;

    public void ShowQuestion(int index)
    {
        Question question = Questions[index];

        var q = question;

        //An array of answer objects
		var answers = q.Answers;

        //Create a new list of answer buttons
        List<Transform> answersButtonArray = new List<Transform>();

        //Get every button from transform container
        foreach (Transform answer in AnswersContainer)
        {
			answersButtonArray.Add(answer);
            Debug.Log(answersButtonArray.Count);
        }

        //Insert an individual answer in each button
        for (int i = 0; i <= 3; i++)
        {
            answersButtonArray[i].GetComponent<AnswerButton>().OwnAnswer = answers[i];
			answersButtonArray [i].GetChild (0).GetComponent<Text> ().text = answers [i].AnswerText;
        }

		QuestionTitle.text = q.QuestionTitle;
    }

    private void Start()
    {
        ShowQuestion(0);
    }
}
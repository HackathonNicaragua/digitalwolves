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
        public string Title;             //The actual question
        public string[] Answers;        //Its answers


        //Assignment constructor.
        public Question(string title)
        {
            Title = title;
        }
    }

    public Transform Answers; //The order is important
    public Text QuestionTitle;
    public int Score;

    public Question TestQuestion = new Question("Test");

    public List<Question> Questions = new List<Question>();

    private void Start()
    {
       TestSetUp(0);
    }


    public void TestSetUp(int questionIndex)
    {
        if (questionIndex > Questions.Count - 1) //Doesn't allow to go any further
            return;

        QuestionTitle.text = Questions[questionIndex].Title;

        var index = 0;

        foreach (Transform answer in Answers)
        {
            answer.GetChild(0).GetComponent<Text>().text = Questions[questionIndex].Answers[index];
            index++;
        }
    }
}
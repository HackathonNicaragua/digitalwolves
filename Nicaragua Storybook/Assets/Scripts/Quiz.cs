﻿using UnityEngine;
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
       // TestSetUp();
    }

    
    public void TestSetUp()
    {
        QuestionTitle.text = TestQuestion.Title;

        int index = 0;

        foreach (Transform answer in Answers)
        {
            answer.GetChild(0).GetComponent<Text>().text = TestQuestion.Answers[index];
            index++;
        }
    }
}
using UnityEngine;
using System;
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
        public Question(string min, int max)
        {
            Title = min;
        }
    }

    public Transform Answers; //The order is important
    public Text QuestionTitle;

    public Question TestQuestion = new Question("Test", 9);

    private void Start()
    {
        TestSetUp();
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

        /*for (int i = 0; i < TestQuestion.Answers.Length; i++)
        {
            Answers[i].GetComponent<Text>().text = TestQuestion.Answers[i];
        }*/
    }
}
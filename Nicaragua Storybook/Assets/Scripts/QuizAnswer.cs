using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizAnswer : MonoBehaviour
{
    public enum QuizButtonType
    {
        Correct,
        Incorrect
    }

    public QuizButtonType Type;

    public void SendMyselfTest()
    {
        if (Type == QuizButtonType.Correct)
        {
            //Correct answer logic
        }
        else
        {
            //Incorrect answer logic
        }
    }
}

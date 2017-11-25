using UnityEngine;
using System.Collections;

public class SubmitQuiz : MonoBehaviour
{
    public Quiz StoryQuiz;

    public void Submit(QuizAnswer answer)
    {
        if (answer.Type == QuizAnswer.QuizButtonType.Correct)
        {
            StoryQuiz.Score += 25;
        }
        if (answer.Type == QuizAnswer.QuizButtonType.Incorrect)
        {
            //Load next question
        }
    }
}

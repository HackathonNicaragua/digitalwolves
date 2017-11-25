using UnityEngine;
using System.Collections;

public class SubmitQuiz : MonoBehaviour
{
    public Quiz StoryQuiz;

    public void Submit(QuizAnswer answer)
    {
        if (answer == null) //Doesn't allow to go any further
            return;

        var quizIndex = 0;

        switch (answer.Type)
        {
            case QuizAnswer.QuizButtonType.Correct:
                StoryQuiz.Score += 25;
                Debug.Log("El puntaje es: " + StoryQuiz.Score);
                quizIndex++;
                StoryQuiz.TestSetUp(quizIndex);
                break;
            case QuizAnswer.QuizButtonType.Incorrect:
                quizIndex++;
                StoryQuiz.TestSetUp(quizIndex);
                break;
        }
    }
}

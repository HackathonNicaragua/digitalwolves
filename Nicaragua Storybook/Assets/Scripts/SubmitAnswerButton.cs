using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SubmitAnswerButton : MonoBehaviour
{
	public Quiz.Answer Answer;

	private Quiz _quiz;

	private void Start() 
	{
		_quiz = FindObjectOfType<Quiz> ();

		GetComponent<Button> ().onClick.AddListener (CheckAnswers);
	}
		
	public void CheckAnswers() 
	{
		if (Answer.IsCorrect) 
		{
			_quiz.Score += 2.5f;

			//Go to next question
			_quiz.ShowQuestion(2);
		}
	}
}


using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SubmitAnswerButton : MonoBehaviour
{
	[HideInInspector]
	public Quiz.Answer Answer;

	public GameObject Results;

	private int _questionIndex = 0;

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
			_questionIndex++;

			//Go to next question
			if (_questionIndex > 5) 
			{
				Results.SetActive(true);
				GameObject.Find ("QuizHolder").SetActive(false);
			} else 
			{
				_quiz.ShowQuestion (_questionIndex);
				_quiz.AnsweredCorrectly++;
			}
		} 
		else if (!Answer.IsCorrect)
		{
			_questionIndex++;

			if (_questionIndex > 4) 
			{
				Results.SetActive(true);
				GameObject.Find ("QuizHolder").SetActive (false);
			} 
			else 
			{
				Debug.Log ("Incorrect!");
				_quiz.ShowQuestion (_questionIndex);
			}
		}
	}
}


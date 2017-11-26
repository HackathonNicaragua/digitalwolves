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
		if (Answer != null) {
			if (Answer.IsCorrect) 
			{
				_quiz.Score += 20;
				_questionIndex++;
				_quiz.AnsweredCorrectly++;
				Debug.Log("You have " + _quiz.AnsweredCorrectly + " correct answers");
				Debug.Log("Score " + _quiz.Score);

				//Go to next question
				if (_questionIndex > 4) 
				{
					Answer = null;
					Results.SetActive(true);
					GameObject.Find ("QuizHolder").SetActive(false);
				} else 
				{
					Answer = null;
					_quiz.ShowQuestion (_questionIndex);
				}
			} 
			else if (!Answer.IsCorrect)
			{
				_questionIndex++;

				if (_questionIndex > 4) 
				{
					Answer = null;
					Results.SetActive(true);
					GameObject.Find ("QuizHolder").SetActive (false);
				} 
				else 
				{
					Answer = null;
					Debug.Log ("Incorrect!");
					_quiz.ShowQuestion (_questionIndex);
				}
			}
		}
	}
}


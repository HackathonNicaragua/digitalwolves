using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SubmitAnswerButton : MonoBehaviour
{
	[HideInInspector]
	public Quiz.Answer Answer;

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
			if (_questionIndex >= _quiz.Questions.Count) 
			{
				//Show results screen
			} else 
			{
				_quiz.ShowQuestion (_questionIndex);
			}
		} 
		else if (!Answer.IsCorrect)
		{
			_questionIndex++;

			Debug.Log ("Incorrect!");
			_quiz.ShowQuestion (_questionIndex);
		}
	}
}


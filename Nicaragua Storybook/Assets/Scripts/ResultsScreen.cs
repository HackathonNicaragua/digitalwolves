using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultsScreen : MonoBehaviour 
{
	public Text Score;
	public Text CorrectQuestions;

	private Quiz _quiz;

	private void OnEnable() 
	{
		_quiz = GameObject.Find ("Quiz").GetComponent<Quiz> ();

		Score.text = "Puntaje . . . . . . . . " + _quiz.Score + "/" + 10;
		CorrectQuestions.text = "Preguntas correctas . . . . " + _quiz.AnsweredCorrectly + "/" + 5;
	}
}

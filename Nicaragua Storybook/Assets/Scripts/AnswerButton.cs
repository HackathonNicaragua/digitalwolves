using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour
{
    [HideInInspector] public Quiz.Answer OwnAnswer;

	public SubmitAnswerButton SubmitButton;

    private void Update()
    {
        GetComponent<Button>().onClick.AddListener(Submit);
    }

    private void Submit()
    {
		SubmitButton.Answer = OwnAnswer;
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuestionButton : MonoBehaviour
{
    [HideInInspector]
    public Quiz.Answer Question;

    private void Update()
    {
        GetComponent<Button>().onClick.AddListener(SendToSubmit);
    }

    private void SendToSubmit()
    {
        GameObject.FindObjectOfType<SubmitQuiz>().Answer = Question;
    }
}

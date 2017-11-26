using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour
{
    [HideInInspector] public Quiz.Answer OwnAnswer;

    private void Update()
    {
        GetComponent<Button>().onClick.AddListener(TestAnswer);
    }

    private void TestAnswer()
    {
        Debug.Log(OwnAnswer.IsCorrect);
    }
}

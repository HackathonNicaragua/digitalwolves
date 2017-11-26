using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameCard : MonoBehaviour
{
    public enum CardTypes
    {
        Nicaragua,
        Guardabarranco,
        Madrono,
        Sacuanjoche
    }

    public CardTypes Type;

    private Animator _animator;
    private GameController _controller;
    private bool _flipped;


    // Use this for initialization
    private void Start()
    {
        _animator = GetComponent<Animator>();
        _flipped = false;
        _controller = FindObjectOfType<GameController>();
    }

    private void OnMouseDown()
    {
        if (!_flipped)
        {
            _controller.GameCardSelected(this);

            _animator.Play("Card flip");
            _flipped = true;
        }
    }

    public void OnCardFlipped()
    {
        _animator.Play("Card Flipped");
    }

    public void RevertToOriginalState()
    {
        _animator.Play("Card Idle");
        _flipped = false;
    }
}

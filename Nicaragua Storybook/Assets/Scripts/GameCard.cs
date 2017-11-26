using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

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

	public Sprite[] CardCovers;

	public Image OwnImage;

    // Use this for initialization
    private void Start()
    {
		switch (Type) {
		case CardTypes.Nicaragua:
			OwnImage.sprite = CardCovers [0];
			break;
		case CardTypes.Guardabarranco:
			OwnImage.sprite = CardCovers [1];
			break;
		case CardTypes.Madrono:
			OwnImage.sprite = CardCovers [2];
			break;
		case CardTypes.Sacuanjoche:
			OwnImage.sprite = CardCovers [3];
			break;
		}

        _animator = GetComponent<Animator>();
        _flipped = false;
        _controller = FindObjectOfType<GameController>();
    }

    private void OnMouseDown()
    {
        if (!_flipped)
        {
            _controller.GameCardSelected(this);

            _animator.Play("Card Flip");
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

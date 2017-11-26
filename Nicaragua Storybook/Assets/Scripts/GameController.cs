using System;
using UnityEngine;
using System.Collections;
using Boo.Lang;

public class GameController : MonoBehaviour
{
    public GameObject CardPrefab;

    private readonly List<GameCard> _selectedGameCards = new List<GameCard>();

    private readonly Vector3[] _cardPositions = 
    {
        new Vector3(-5, 3),
        new Vector3(-2, 3),
        new Vector3(2, 3),
        new Vector3(5, 3),
        new Vector3(-5, -3),
        new Vector3(-2, -3),
        new Vector3(2, -3),
        new Vector3(5, -3)
    };

    private readonly GameCard.CardTypes[] _availableCardTypes = (GameCard.CardTypes[]) Enum.GetValues(typeof(GameCard.CardTypes));

    private void Start()
    {
        GameSetUp();
    }

    private void GameSetUp()
    {
        for (var i = 0; i < _cardPositions.Length; i++)
        {
            var pos = _cardPositions[i];
            var card = Instantiate(CardPrefab, pos, Quaternion.identity);
            switch (i)
            {
                case 0:
                    card.GetComponent<GameCard>().Type = GameCard.CardTypes.Guardabarranco;
                    break;
                case 1:
                    card.GetComponent<GameCard>().Type = GameCard.CardTypes.Guardabarranco;
                    break;
                case 2:
                    card.GetComponent<GameCard>().Type = GameCard.CardTypes.Madrono;
                    break;
                case 3:
                    card.GetComponent<GameCard>().Type = GameCard.CardTypes.Madrono;
                    break;
                case 4:
                    card.GetComponent<GameCard>().Type = GameCard.CardTypes.Nicaragua;
                    break;
                case 5:
                    card.GetComponent<GameCard>().Type = GameCard.CardTypes.Nicaragua;
                    break;
                case 6:
                    card.GetComponent<GameCard>().Type = GameCard.CardTypes.Sacuanjoche;
                    break;
                case 7:
                    card.GetComponent<GameCard>().Type = GameCard.CardTypes.Sacuanjoche;
                    break;
            }
        }
    }

    private IEnumerator CompareCards(GameCard a, GameCard b)
    {
        yield return new WaitForSeconds(1.0f);

        if (a.Type == b.Type)
        {
            Destroy(a.gameObject);
            Destroy(b.gameObject);
        }
        else
        {
            a.RevertToOriginalState();
            b.RevertToOriginalState();
        }
    }

    public void GameCardSelected(GameCard card)
    {
        _selectedGameCards.Add(card);

        if (_selectedGameCards.Count == 2)
        {
            StartCoroutine(CompareCards(_selectedGameCards[0], _selectedGameCards[1]));
            _selectedGameCards.Clear(); //So we don't keep old information
        }
    }
}

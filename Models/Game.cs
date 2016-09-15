using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Game {

    int numberOfPlayers;
    Player[] players;
    List<Card> cardsAgeOne = new List<Card>();
    List<Card> cardsAgeTwo;
    List<Card> cardsAgeThree;
    int currentAge;
    int currentRound;
    private static System.Random rng = new System.Random();

    Dictionary<string, Card> cardDictionary;

    public int NumberOfPlayers {
        get {
            return numberOfPlayers;
        }

        set {
            this.numberOfPlayers = value;
        }
    }

    public Player[] Players {
        get {
            return players;
        }

        set {
            this.players = value;
        }
    }

    public int CurrentAge {
        get {
            return currentAge;
        }

        set {
            this.currentAge = value;
        }
    }

    public int CurrentRound {
        get {
            return currentRound;
        }

        set {
            this.currentRound = value;
        }
    }

    public List<Card> CardsAgeOne {
        get {
            return cardsAgeOne;
        }

        set {
            this.cardsAgeOne = value;
        }
    }

    void createPlayers(int numberOfPlayers) {
        for ( int i = 0; i < this.numberOfPlayers; i++ )
        {
            this.Players[i] = new Player(i, "Player_" + i);

        }
    }

    void initializeCards(int numberOfPlayers) {
        cardDictionary = new Dictionary<string, Card>();
        for ( int cardsCount = 0; cardsCount < numberOfPlayers * 7; cardsCount++ )
        {
            Card card = new Card(currentAge, numberOfPlayers);
            cardDictionary.Add("Card_" + cardsCount, card);
            card.cardName = "Card_" + cardsCount.ToString();
            Debug.Log(card.cardName);
            //cardsAgeOne.Add(card);
        }
        foreach ( KeyValuePair<string, Card> pair in cardDictionary )
        {
            cardsAgeOne.Add(pair.Value);
            //Debug.Log(pair.Key.ToString() + " - " + pair.Value.ToString());
        }
    }

    void distributeCards(int currentAge) {
        foreach ( Card carte in cardsAgeOne )
        {
            //Debug.Log("Type de carte = " + carte.cardType);
        }
        Debug.Log("Debut du shuffle");
        shuffleCards(cardsAgeOne);
        int playerCount = 0;
        foreach ( Card carte in cardsAgeOne )
        {
            //Debug.Log("Carte = " + carte.cardName);
            //Debug.Log("Type de carte = " + carte.cardType);
            Players[playerCount % 4].PlayerHand.Add(carte);
            playerCount++;
        }
    }

    void shuffleCards<Card>(List<Card> cardsToShuffle) {

        int n = cardsToShuffle.Count;
        while ( n > 1 )
        {
            n--;
            int k = rng.Next(n + 1);
            Card value = cardsToShuffle[k];
            cardsToShuffle[k] = cardsToShuffle[n];
            cardsToShuffle[n] = value;
        }
    }

    public Game(int numberOfPlayers) {
        this.numberOfPlayers = numberOfPlayers;
        players = new Player[numberOfPlayers];

        Debug.Log("Game created with " + this.NumberOfPlayers
            + " players");
    }

    public void newGame() {
        currentAge = 1;
        currentRound = 1;
        createPlayers(numberOfPlayers);
        initializeCards(numberOfPlayers);
        distributeCards(currentAge);
        foreach ( Player player in players )
        {
            Debug.Log("Main du joueur " + player.PlayerNumber + " = ");
            foreach ( Card carte in player.PlayerHand )
            {
                Debug.Log(carte.cardName);
            }
        }
    }
}

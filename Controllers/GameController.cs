using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

    public static GameController Instance {
        get;
        protected set;
    }

    public int numberOfPlayers;

    public List<Card> cardsAgeOne;

    //Player Sprite
    public Sprite playerSprite;
    //Cards sprites
    public Sprite scienceCardSprite;
    public Sprite commonResourceCardSprite;
    public Sprite rareResourceCardSprite;
    public Sprite militaryCardSprite;
    public Sprite civilianCardSprite;
    public Sprite commercialCardSprite;
    public Sprite guildCardSprite;

    Dictionary<Card, GameObject> cardGameObjectMap;
    Dictionary<Player, GameObject> playerGameObjectMap;


    //The Game
    public Game TheGame {
        get;
        protected set;
    }

	// Use this for initialization
	void Start () {
        if ( Instance != null )
        {
            Debug.LogError("There should never be two games controllers");
        }
        Instance = this;


        //Create a game
        TheGame = new Game(numberOfPlayers);
        cardGameObjectMap = new Dictionary<Card, GameObject>();
        playerGameObjectMap = new Dictionary<Player, GameObject>();
        TheGame.newGame();

       
            foreach ( Card card in cardsAgeOne )
            {
                Instantiate(card, transform.position, Quaternion.identity);
            }
        
        foreach ( Player player in TheGame.Players )
        {
            Player player_data = player;
            GameObject player_go = new GameObject();
            playerGameObjectMap.Add(player_data, player_go);
            player_go.name = "Player_" + player_data.PlayerNumber;
            Canvas player_canvas = player_go.AddComponent<Canvas>();
            player_go.transform.SetParent(this.transform, true);
        }
        for ( int i = 0; i < TheGame.CardsAgeOne.Count; i++ )
        {
            //string cardName = "Card_" + i;
            Card card_data = TheGame.CardsAgeOne[i];
            GameObject card_go = new GameObject();
            cardGameObjectMap.Add(card_data, card_go);
            card_go.name = card_data.cardName;
            card_go.transform.position = new Vector3(i % 2, i % 3, 0);
            card_go.transform.SetParent(this.transform, true);
            SpriteRenderer card_sr = card_go.AddComponent<SpriteRenderer>();
            setCardSprite(card_data);
        }


	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void setCardSprite(Card card_data) {
        GameObject card_go = cardGameObjectMap[card_data];
        switch ( card_data.cardType )
        {
            case Card.CardTypes.Civilian:
                card_go.GetComponent<SpriteRenderer>().sprite = civilianCardSprite;
                break;
            case Card.CardTypes.Commercial:
                card_go.GetComponent<SpriteRenderer>().sprite = commercialCardSprite;
                break;
            case Card.CardTypes.CommonResource:
                card_go.GetComponent<SpriteRenderer>().sprite = commonResourceCardSprite;
                break;
            case Card.CardTypes.Guild:
                card_go.GetComponent<SpriteRenderer>().sprite = guildCardSprite;
                break;
            case Card.CardTypes.Military:
                card_go.GetComponent<SpriteRenderer>().sprite = militaryCardSprite;
                break;
            case Card.CardTypes.RareResource:
                card_go.GetComponent<SpriteRenderer>().sprite = rareResourceCardSprite;
                break;
            case Card.CardTypes.Science:
                card_go.GetComponent<SpriteRenderer>().sprite = scienceCardSprite;
                break;
        }
    }
}

using UnityEngine;
using System.Collections;

public class CardController : MonoBehaviour {

    public Sprite scienceCardSprite;
   
    Card card;
    // Use this for initialization
    void Start () {
        //card = new Card(1, 3, Card.CardTypes.Science);
        card = new Card();

        GameObject card_go = new GameObject();
        card_go.name = card.cardType + "_Card";

        SpriteRenderer card_sr =  card_go.AddComponent<SpriteRenderer>();
        card_sr.sprite = scienceCardSprite;
        }
	
	// Update is called once per frame
	void Update () {
	
	}
}

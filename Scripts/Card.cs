using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour {

    public int ageAvailability;
    //public int numberOfPlayersAvailability; On s'en passe pour l'instant
    public string cardName;

    // TODO : move elsewhere
    public enum Resources {
        Wood, Stone, Clay, Ore, Glass, Loom, Papyrus
    }

    public enum CardTypes {
        CommonResource, RareResource, Science, Commercial, Civilian, Military, Guild
    }

    public CardTypes cardType;
    /* On va essayer de s'en passer dans un premier temps
    private CardTypes CardType
    {
        get
        {
            return cardType;
        }
        set
        {
            cardType = value;
        }
    }*/

    
    // Array costs:

    public int[] resourcesCost = new int[System.Enum.GetNames(typeof(Resources)).Length];

    private SpriteRenderer card_sr;

    void Start () {
        card_sr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

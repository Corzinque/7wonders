using System.Collections;
using UnityEngine;

public enum Resources
{
    Wood, Stone, Clay, Ore, Glass, Loom, Papyrus
}

public class Card
{
    public int ageAvailability;
    public int numberOfPlayersAvailability;
    public string cardName;
    public enum CardTypes
    {
        CommonResource, RareResource, Science, Commercial, Civilian, Military, Guild
    }
    public CardTypes cardType;
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
    }

    // Array costs:
    private int[] resourcesCost = new int[System.Enum.GetNames(typeof(Resources)).Length];
    public int[] ResourceCost
    {
        get
        {
            return resourcesCost;
        }
        set
        {
            for (int i = 0; i < value.Length; i++)
            {
                resourcesCost[i] = value[i];
            }
        }
    }
    
    public Card(int age, int numberOfPlayers)
    {
        this.ageAvailability = age;
        this.numberOfPlayersAvailability = numberOfPlayers;
        this.CardType = (CardTypes)Random.Range(0, 6);
        Debug.Log("New card of type " + CardType + " created !");
    }
    public Card(int age, int numberOfPlayers, CardTypes type)
    {
        this.ageAvailability = age;
        this.numberOfPlayersAvailability = numberOfPlayers;
        this.cardType = type;
        Debug.Log("New card of type " +cardType+" created !");

    }
    /*
    // Various costs :
    private int stoneCost;
    private int woodCost;
    private int clayCost;
    private int oreCost;
    private int glassCost;
    private int loomCost;
    private int papyrusCost;

    public void setCosts(int[] Costs)
    {
        for (int i = 0; i < Costs.Length; i++)
        {
            ResourcesCost[i] = Costs[i];
        }

        switch (resource)
        {
            case stone :
                stoneCost = cost;
                break;
            case wood:
                woodCost = cost;
                break;
            case clay:
                clayCost = cost;
                break;
            case ore:
                oreCost = cost;
                break;
            case glass:
                glassCost = cost;
                break;
            case loom:
                loomCost = cost;
                break;
            case papyrus:
                papyrusCost = cost;
                break;
        }
    }

    public int[] getCost(Card card)
    {
        return card.ResourcesCost[];
    }
    */
}
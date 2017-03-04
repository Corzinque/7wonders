using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player {

    string name;
    public string Name {
        get {
            return name;
        }

        set {
            this.name = value;
        }
    }

    int playerNumber;

    public int PlayerNumber
    {
        get {
            return playerNumber;
        }

        set {
            playerNumber = value;
        }
    }

    int rawScore;

    public int RawScore {
        get {
            return rawScore;
        }

        set {
            this.rawScore = value;
        }
    }
    /*
    public int[] PermanentResources {
        get {
            return permanentResources;
        }

        set {
            this.permanentResources = value;
        }
    }

    int[] permanentResources = new int[System.Enum.GetNames(typeof(Resources)).Length];
    
    public int[] TemporaryResources {
        get {
            return temporaryResources;
        }

        set {
            this.temporaryResources = value;
        }
    }
    */
    public int MilitaryScore {
        get {
            return militaryScore;
        }

        set {
            this.militaryScore = value;
        }
    }

    public int Coins {
        get {
            return coins;
        }

        set {
            this.coins = value;
        }
    }

    public List<Card> PlayerBoard {
        get {
            return playerBoard;
        }

        set {
            this.playerBoard = value;
        }
    }

    public List<Card> PlayerHand {
        get {
            return playerHand;
        }

        set {
            this.playerHand = value;
        }
    }
    /*
    int[] temporaryResources = new int[System.Enum.GetNames(typeof(Resources)).Length];*/
    int militaryScore;
    int coins;
    List<Card> playerBoard;
    List<Card> playerHand;

    public Player(int playerNumber, string name) {
        this.playerNumber = playerNumber;
        this.name = name;
        this.playerHand = new List<Card>();
        Debug.Log("Player " + name + " created !");
    }
}

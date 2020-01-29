using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Camel : MonoBehaviour
{

    public int movement;
     int spaceValue = 0;


     [SerializeField]
     GameBoard myGameBoard;

     [SerializeField]
     spaces currentSpaceValue;
     
     


    // Start is called before the first frame update
    void Start()
    {
          currentSpaceValue = myGameBoard.game_board[spaceValue + movement];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

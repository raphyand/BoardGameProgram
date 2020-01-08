using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diice_holder : MonoBehaviour
{
     // Need to have 5 out of 7 objects get spit out.
     public GameObject[] diceHolder;
     enum DiceColors { BLUE, ORANGE, YELLOW, RED, GREEN, BLACK, WHITE};



     


     int randomGenerator() // Randomly take out a die
     {
          int diceSelected = new System.Random().Next(0, 6);
          return diceSelected;
     }

     GameObject throwDice()
     {
          int numberThrown = randomGenerator();
          return diceHolder[numberThrown];
     }



     // Start is called before the first frame update
     void Start()
    {
          for (int i = 0; i < 5; i++)
          {
               GameObject myObject = throwDice();
               string objName = myObject.name;
               Debug.Log("The name of this element is " + objName);
          }

    }

    // Update is called once per frame
    void Update()
    {
        
    }


}

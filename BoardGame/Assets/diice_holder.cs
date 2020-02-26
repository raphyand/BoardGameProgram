using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diice_holder : MonoBehaviour
{
     // Need to have 5 out of 7 objects get spit out.
     public dice[] diceHolder;

     // Start is called before the first frame update
     void Start()
    {
          rollDice();
    }

    // Update is called once per frame
    void Update()
    {

    }

     void rollDice() 
     {// my python crap. was trrying to translate it but i decided i would wait because c# does not have some of the functions
          dieColor = () // in python i have this as dieColor = [] but u said [] does not work here
          while len(dieColor)<5:
          {
            
            int tempValue = Random.Range(1, 8);
            dieColor.append(tempValue)
            dieColor = list(set(dieColor)) // this removes duplicates in python
            dieColor = dieColor[:5] // is keeps the list to 5 elements
                if len(dieColor)==5
                    break              //end loop so it does not keep running even though we thechnically cam





            diceHolder[tempValue].generateMovementValue();
                    

          }
          

     }


}

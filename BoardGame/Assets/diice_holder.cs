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
     {
          
          for (int i = 0; i < 5; i++)
          {// my python crap
            dieColor = ()
            count = 0
            int tempValue = Random.Range(1, 8);
            a.append(tempValue)
            for i in a:
                if(i==tempValue):
                    count = count + 1
                    if(count!=2):
                        

               diceHolder[tempValue].generateMovementValue();
                    

          }
          

     }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dice : MonoBehaviour
{
    // Start is called before the first frame update
    // creating a random number... will move to dice class

    [SerializeField] int movementValue;
     public bool positive;
     [SerializeField] 

     public void generateMovementValue()
     {
          if (positive == true)
               movementValue = Random.Range(1, 4);
          //if
          else (positive == false)
               movementValue = Random.Range(1, 4) * -1;
     }

     void Start()
     {
         // generateMovementValue();
     }


}

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
               movementValue = new System.Random().Next(1, 3);
          if (positive == false)
               movementValue = new System.Random().Next(1, 3) * -1;
     }

     void Start()
     {
          generateMovementValue();
     }


}

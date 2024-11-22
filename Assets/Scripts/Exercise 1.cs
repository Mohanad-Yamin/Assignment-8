using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        System.Random random = new System.Random();
        int number;

        while (true)
        {
            number = random.Next(1, 21);

            if (number == 5)
            {
                continue; 
            }

            Debug.Log(number);

            if (number == 15)
            {
                break; 
            }
        }
    }
}

   

   
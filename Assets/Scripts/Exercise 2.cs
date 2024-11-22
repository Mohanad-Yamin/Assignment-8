using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        System.Random random = new System.Random();
        string sentence = "";
        int count = 0;

        while (count < 7)
        {
            int index = random.Next(words.Length);
            sentence += words[index] + " ";
            count++;
        }

        Debug.Log("Funny sentence: " + sentence);
    }
}
 

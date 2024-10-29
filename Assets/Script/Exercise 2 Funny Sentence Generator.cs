using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2FunnySentenceGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        int counter = 0;
        while (counter < 7)
        {
            string sentence += words[Random.Range(0, words.Length)] + " ";
            counter++;
        }
    }


}

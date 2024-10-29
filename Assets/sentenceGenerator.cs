using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class sentenceGenerator : MonoBehaviour
{
    void Start()
    {
        string[] funny = {"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
        string[] randomWords = {};

        int i = 0;
        while(i < randomWords.Length){
            int rand = Random.Range(i, funny.Length);
            randomWords[i] = funny[rand];
            i++;
        }

        int j=0;
        while(j < randomWords.Length){
            Debug.Log(randomWords[j]);
            j++;
        }
    }

   
}

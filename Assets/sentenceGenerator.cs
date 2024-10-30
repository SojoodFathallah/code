using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class sentenceGenerator : MonoBehaviour
{
    void Start()

    {   
        string[] funny = {"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
        string randSentene;
        
        int i = 0;
        while(i < funny.Length){
            int rand = Random.Range(i,funny.Length);
            randSentene = funny[rand] + " ";
            i++;
        }
    }

   
}

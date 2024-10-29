using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numberGenerator : MonoBehaviour
{
    void Start()
    {
        int i = 1;
        while(i<20){
            i++;
            int rand = Random.Range(1,20);
            if(rand == 5) continue;
            else if(rand == 15) break;
            Debug.Log(rand);
            

        }
    }
}

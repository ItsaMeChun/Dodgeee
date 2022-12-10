using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int i = 0;
    private void OnCollisionEnter(Collision other)
    {
        if(gameObject.tag != "Hit!"){
            i++;
            Debug.Log("You're bumped into me this many time: " + i);
        }
    }
}

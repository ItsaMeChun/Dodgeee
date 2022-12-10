using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    private float xValue = 0f;
    private float yValue = 5f;
    private float zValue = 0f;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xValue, yValue, zValue);
    }
}

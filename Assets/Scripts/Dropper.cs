using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    private float timeToPass = 5f;
    private MeshRenderer r;
    private Rigidbody ri;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<MeshRenderer>();
        ri = GetComponent<Rigidbody>();
        ri.useGravity = false;
        r.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Time is: " + Time.time);
        if(Time.time > timeToPass){
            // Debug.Log($"ok");
            r.enabled = true;
            ri.useGravity = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    //The spin speed of the propeller
    public float spinSpeed = 1000.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate the propeller 
        transform.Rotate(Vector3.forward, Time.deltaTime * spinSpeed);
    }
}

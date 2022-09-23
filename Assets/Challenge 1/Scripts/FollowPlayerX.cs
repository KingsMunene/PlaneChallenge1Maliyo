using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    //GameObject containing to reference the plane object
    public GameObject plane;

    // Offset vector variable containing a vector position to elavate the camera
    public Vector3 offset = new Vector3(30, 0, 10);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Transform the position of the camera to the plane position plus the offset position
        transform.position = plane.transform.position + offset;
    }
}

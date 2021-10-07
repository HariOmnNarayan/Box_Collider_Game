using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour
{
    public Transform player;//Transform is a type of datatype to contain transform of anything,
    // Update is called once per frame

    public Vector3 offset;// has 3numbers 
    void Update()
    {
        //transform refers to object transform 
        transform.position = player.position + offset;
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float forwardforce =-500;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello world");
        rigidbody.useGravity = true; 
        
    }

    // Update is called once per frame
    void Update()
    {
        //rigidbody.AddForce(forwardforce*Time.deltaTime ,2,0);
       // rigidbody.AddForce(10,0,0);
       if(Input.GetKey("up")){
           rigidbody.AddForce(forwardforce*Time.deltaTime ,0,0,ForceMode.VelocityChange);
       }
       if(Input.GetKey("down")){
           rigidbody.AddForce(-forwardforce*Time.deltaTime ,0,0,ForceMode.VelocityChange);
       }
       if(Input.GetKey("left")){
           rigidbody.AddForce(0,0,(forwardforce/10)*Time.deltaTime ,ForceMode.VelocityChange);
       }
       if(Input.GetKey("right")){
           rigidbody.AddForce(0,0,-(forwardforce/10)*Time.deltaTime,ForceMode.VelocityChange );
       }
       if(Input.GetKey("space")){
           rigidbody.AddForce(0,650*Time.deltaTime,0,ForceMode.VelocityChange );
       }
    }
}

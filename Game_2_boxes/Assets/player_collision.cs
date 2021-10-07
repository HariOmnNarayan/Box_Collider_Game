using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_collision : MonoBehaviour
{
    public Player_Movement movement;

    //this will be called if it collides with any rigid body and collider on
    /*void OnCollisionEnter(Collision other){
        Debug.Log(other.collider.name);
        //here name can be not that handy so instead of using name we 
        // should use tag 
        /*if(other.collider.tag=="obstacle"){
            Debug.Log("we hit obstacle");
            movement.enabled =false;
        }
    }*/
        
}

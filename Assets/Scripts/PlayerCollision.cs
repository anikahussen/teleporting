﻿using UnityEngine;

public class PlayerCollision : MonoBehaviour
{


    // Update is called once per frame

    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.gameObject.tag == "border") //anything with the tag "border"
        {
            Debug.Log("HIT");
        }
    }




}

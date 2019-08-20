using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporting : MonoBehaviour
{
    public Transform teleportTarget; //new spot
    public GameObject thePlayer; //the object that is moving

    private void OnTriggerEnter(Collider other)//collision
    {
        thePlayer.transform.position = teleportTarget.transform.position; //translate (equate the location to new location)
    }
}

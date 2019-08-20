using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform player; //get all the changes from the player 
    public Vector3 offset; //


    private void Update()
    {
        transform.position = player.position + offset; 
    }
}

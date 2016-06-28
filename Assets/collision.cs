using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {

    public Dandelion dand;
    public PlayerMovement player;


    void OnCollisionEnter (Collision collision)
    {
        //if (other.attachedRigidbody)
        dand.isCollided = true;
        player.weighedDownBy++;
        player.rb.drag--;
        Debug.Log(player.weighedDownBy);
    }

   
}

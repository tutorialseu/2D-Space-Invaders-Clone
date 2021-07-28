using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        //Debug.Log("Collision with wall");
        // Destroys the gameobject that collides with this wall/ the gameobject that holds this script
        if (collision.gameObject.tag != "Player")
            Destroy(collision.gameObject);
        
        //Debug.Log("Collision with wall");

    }
}

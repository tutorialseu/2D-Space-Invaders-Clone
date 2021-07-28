using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPlayerWithEnemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Monster")
        {   
            // Destroy player (as he holds this script)
            Destroy(gameObject);
            // Destroy enemy as he is the one the play collides with in this case
            Destroy(collision.gameObject);
        }
    }


}

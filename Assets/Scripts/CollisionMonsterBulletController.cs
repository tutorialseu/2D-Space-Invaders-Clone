using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMonsterBulletController : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Monster" || collision.gameObject.tag == "Bullet")
        {
            Physics2D.IgnoreCollision(collision.transform.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else
        {
            // Destroy the Bullet
            Destroy(gameObject);
            // if it's not a wall that you are hitting, destroy that gameobject as well
            if (collision.gameObject.tag != "Wall")
            {
                Destroy(collision.gameObject);
            }
        }
    }

}

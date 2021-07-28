using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonstersController : MonoBehaviour
{
    public GameObject monster1;
    public GameObject monster2;
    public float interval = 3;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMonster", interval, interval);
    }

    private void SpawnMonster()
    {
        float myRan = Random.value;

        if(myRan < 0.2)
        {
            // Spawns monster 1 in 20% of the time
            GameObject g = Instantiate(monster1, transform.position, Quaternion.identity);
        }          
        else if (myRan < 0.4)
        {
            // Spawns monster 2 in 20% of the time
            GameObject g = Instantiate(monster2, transform.position, Quaternion.identity);
        }
        else
        {
            // Spawn nothing in 60% of the time
        }
    }


}

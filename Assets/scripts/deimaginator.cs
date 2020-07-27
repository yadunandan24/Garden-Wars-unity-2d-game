using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deimaginator : MonoBehaviour
{
   
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject other_thing = collision.gameObject;

        if (other_thing.GetComponent<defender>())
        {
            GetComponent<enemy>().Attacking(other_thing);
        }
        if (other_thing.GetComponent<projectile>())
        {
            GetComponent<AudioSource>().Play();
        }

    }
}

          

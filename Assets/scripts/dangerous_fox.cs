using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dangerous_fox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject other_thing = collision.gameObject;

        

        if (other_thing.GetComponent<beryl>())
        {
            GetComponent<Animator>().SetTrigger("triggerjump");

        }

        else if (other_thing.GetComponent<defender>())
        {
            GetComponent<enemy>().Attacking(other_thing);
        }
    }
}

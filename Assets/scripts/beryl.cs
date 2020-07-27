using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beryl : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        enemy enemi = collision.GetComponent<enemy>();

        if(enemi)
        {
            /////to do something
            

        }
    }

}

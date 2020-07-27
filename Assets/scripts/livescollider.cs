using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class livescollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collison)
    {
        FindObjectOfType<lives_display>().Spend_live();
        Destroy(collison.gameObject);
    }

}

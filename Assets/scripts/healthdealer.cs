using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthdealer : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] GameObject deadVFX;
    public void Damagehandler(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            
            TriggerdeadVFX();
            Destroy(gameObject);

            Debug.Log("AA");
        }
    }

    public void TriggerdeadVFX()
    {
        GameObject v = Instantiate(deadVFX, transform.position, Quaternion.identity);
        
    }

}


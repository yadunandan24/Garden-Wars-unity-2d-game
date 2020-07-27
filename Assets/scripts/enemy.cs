using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [Range(0,5f)]  [SerializeField] float walkvelocity=1f;

    GameObject curr_target;

   

    private void Awake()
    {
        FindObjectOfType<levelcontrol>().Enemyspawned();

    }

    private void OnDestroy()
    {
       levelcontrol level= FindObjectOfType<levelcontrol>();
       if(level!=null)
        {
            level.Enemykilled();
        }
    }
    void Start()
    {
        
    }

   

    void Update()
    {
        transform.Translate(Vector2.left * walkvelocity * Time.deltaTime);
        ChangeAnimationState();                   //to continue walk after attack
            
    }

    private void ChangeAnimationState()
    {
        if(!curr_target)
        {
            GetComponent<Animator>().SetBool("Isattacking", false);
        }
    }

    public void Setwalkspeed(float speed)
    {
        walkvelocity = speed;
    }

    public void Attacking(GameObject target)
    {
        GetComponent<Animator>().SetBool("Isattacking", true);
        curr_target = target;
    }

    public void Deplete_current_target(float damage)
    {
        if (!curr_target) { return; }
        healthdealer health = curr_target.GetComponent<healthdealer>();
        if(health)
        {
            health.Damagehandler(damage);
        }
        else
        {
            
        }
    }
}

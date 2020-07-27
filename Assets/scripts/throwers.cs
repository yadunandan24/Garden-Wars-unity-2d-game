using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwers : MonoBehaviour
{
    [SerializeField] GameObject bullet, gun;

    enemyspawner my_lane_spawner;

    Animator anime;

    GameObject projectile_parent;
    const string PROJECTILE_PARENT_NAME = "parent_projectile";

    // Start is called before the first frame update
    void Start()
    {
        Set_lane_spawner();
        anime = GetComponent<Animator>();

        Create_parent_projectile();
        
    }

    private void Create_parent_projectile()
    {
        projectile_parent = GameObject.Find(PROJECTILE_PARENT_NAME);
        if (!projectile_parent)
        {
            projectile_parent = new GameObject(PROJECTILE_PARENT_NAME);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Is_enemy_in_lane())
        {
            Debug.Log("shoot");
            anime.SetBool("Isattacking", true);
        }
        else
        {
           Debug.Log("bbb");
            anime.SetBool("Isattacking", false);
        }
       
    }

    private void Set_lane_spawner()
    {
        enemyspawner[] spawner_array = FindObjectsOfType<enemyspawner>();

        foreach(enemyspawner e in spawner_array)
        {
            bool close_enough = (Mathf.Abs(e.transform.position.y - transform.position.y)<Mathf.Epsilon);

            if(close_enough)
            {
                my_lane_spawner = e;
            }
        }
    }

    private bool Is_enemy_in_lane()
    {
        if(my_lane_spawner.transform.childCount<=0)
        {
            return false;
        }
        else
        {
            return true;
        }

    }
    public void Throw()
    {
        GameObject weapon= Instantiate(bullet, gun.transform.position, transform.rotation) as GameObject;
        weapon.transform.parent = projectile_parent.transform;

        
        
        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] float min_time_spawn = 1f;
    [SerializeField] float max_time_spawn = 5f;

    [SerializeField] enemy[] enemy_prefab_array;



    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(min_time_spawn, max_time_spawn));  //for randomness between spawnings
            Spawn_enemy();
        }
    }

    public void StopSpawning()
    {
        spawn = false;
    }

    private void Spawn_enemy()
    {
        var enemy_index = UnityEngine.Random.Range(0, enemy_prefab_array.Length);
        Spawn(enemy_prefab_array[enemy_index]);
    }

    private void Spawn(enemy my_enemy)
    {
        enemy new_enemy = Instantiate(my_enemy, transform.position, transform.rotation) as enemy;

        new_enemy.transform.parent = transform;  //so that new enemies are created one down the other
    }
}

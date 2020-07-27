using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelcontrol : MonoBehaviour
{
    int num_of_attackers = 0;
    bool level_time_finished = false;

    [SerializeField] GameObject level_complete_canvas;
    [SerializeField] GameObject level_lost_canvas;

    [SerializeField] float wait_to_load_nextscene = 2;
    public void Start()
    {
        level_complete_canvas.SetActive(false);
        level_lost_canvas.SetActive(false);
    }
    public void Enemyspawned()
    {
        num_of_attackers++;
    }

    public void Enemykilled()
    {
        num_of_attackers--;
        if(num_of_attackers<=0 && level_time_finished)
        {
            StartCoroutine(Wincondition());
        }
    }

    IEnumerator Wincondition()
    {
        level_complete_canvas.SetActive(true);

        GetComponent<AudioSource>().Play();

        yield return new WaitForSeconds(wait_to_load_nextscene);

        FindObjectOfType<levelloader>().Loadnextscene();

    }

    public void Loseconditionhandler()
    {
        level_lost_canvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Time_of_level_finished()
    {
        level_time_finished = true;
        Stopspawners();

    }

    private void Stopspawners()
    {
        enemyspawner[] array_spawner = FindObjectsOfType<enemyspawner>();
        foreach(enemyspawner a in array_spawner)
        {
            a.StopSpawning();
        }

    }
}

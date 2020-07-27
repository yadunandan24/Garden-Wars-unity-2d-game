using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    [SerializeField] float level_time=10;

    bool triggeredlevelfinished = false;
    private void Update()
    {
        if (triggeredlevelfinished) { return; }  //so that do nothing when level finishes
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / level_time;

        bool time_finished = Time.timeSinceLevelLoad >= level_time;

        if(time_finished)
        {
            FindObjectOfType<levelcontrol>().Time_of_level_finished();
            triggeredlevelfinished = true;
        }
    }
}

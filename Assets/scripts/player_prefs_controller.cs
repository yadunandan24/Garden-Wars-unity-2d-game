using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_prefs_controller : MonoBehaviour
{
    const string MASTER_VOLUME_KEY = "master volume";
    const string MASTER_DIFFICULTY = "master difficulty";


    const float MIN_VOL = 0f;
    const float MAX_VOL = 1f;

    const float MIN_DIFF = 0f;
    const float MAX_DIFF = 2f;
    public static void Setmastervolume(float volume)
    {
        if (volume >= MIN_VOL && volume <= MAX_VOL)
        {
          
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
            Debug.Log("master volume set to " + volume);

        }
        else
        {
            Debug.LogError("master volume out of range");
        }
    }

    public static float Getmastervolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    public static void Setdifficulty(float diff)
    {
        if(diff >= MIN_DIFF && diff <= MAX_DIFF)
        {
            PlayerPrefs.SetFloat(MASTER_DIFFICULTY, diff);
        }
        else
        {
            Debug.LogError("difficulty setting out of range");
        }
    }

    public static float Getdifficulty()
    {
        return PlayerPrefs.GetFloat(MASTER_DIFFICULTY);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class options_handler : MonoBehaviour
{
    [SerializeField] Slider volumebar;
    [SerializeField] float default_volume = 0.6f;

    [SerializeField] Slider difficultybar;
    [SerializeField] float default_difficulty = 0f;
    // Start is called before the first frame update
    void Start()
    {
        volumebar.value = player_prefs_controller.Getmastervolume();
        difficultybar.value = player_prefs_controller.Getdifficulty();
    }

    // Update is called once per frame
    void Update()
    {
        var musicplayer = FindObjectOfType<musicplayer>();
        if(musicplayer)
        {
            musicplayer.Setvolume(volumebar.value);
        }
        else
        {
            Debug.LogWarning("no music player found did u start from spalsh screen");
        }
    }

    public void SaveandExit()
    {
        player_prefs_controller.Setmastervolume(volumebar.value);
        player_prefs_controller.Setdifficulty(difficultybar.value);
        FindObjectOfType<levelloader>().Loadmainmenu();

    }

    public void Setdefaultvalues()
    {
        volumebar.value = default_volume;
        difficultybar.value = default_difficulty;
    }
}

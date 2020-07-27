using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicplayer : MonoBehaviour
{
    AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        if(FindObjectsOfType<musicplayer>().Length>1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(this);
        }
        
        audiosource = GetComponent<AudioSource>();

        audiosource.volume = player_prefs_controller.Getmastervolume();
    }

    // Update is called once per frame
   
    public void Setvolume(float volume)
    {
        audiosource.volume = volume;
    }
}

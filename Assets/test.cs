using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      player_prefs_controller.Setmastervolume(0.3f);
        Debug.Log(player_prefs_controller.Getmastervolume());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

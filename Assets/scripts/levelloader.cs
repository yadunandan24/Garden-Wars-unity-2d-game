using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelloader : MonoBehaviour
{
    int currentscene;
    [SerializeField] int wait_seconds=3;
    // Start is called before the first frame update
    void Start()
    {
        currentscene = SceneManager.GetActiveScene().buildIndex;
        if (currentscene == 0)
        {
            StartCoroutine(Delay_load_menu_screen());
        }
    }

    public void Restartscene()
    {
        SceneManager.LoadScene(currentscene);
        Time.timeScale = 1;
    }

    public void Loadmainmenu()
    {
        SceneManager.LoadScene("MenuScreen");
        Time.timeScale = 1;
    }

    public void Loadoptionsscreen()
    {
        SceneManager.LoadScene("OptionsScreen");
        
    }

    IEnumerator Delay_load_menu_screen()
    {
        yield return new WaitForSeconds(wait_seconds);
        Loadnextscene();
    }

    public void Load_lose_screen()
    {
        SceneManager.LoadScene("Game_Over");
    }

    public void Loadnextscene()
    {
        SceneManager.LoadScene(currentscene + 1);
    }
   
    public void Quitgame()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class lives_display : MonoBehaviour
{
    [SerializeField] float baselives = 3;
    float lives=0f;
    [SerializeField] int life_amount = 1;

    Text lives_text;

    void Start()
    {
        lives = baselives - player_prefs_controller.Getdifficulty();
        lives_text = GetComponent<Text>();
        Update_display();
    }

    private void Update_display()
    {
        lives_text.text = lives.ToString();
    }

    public void Spend_live()
    {

        lives -= life_amount;
        Update_display();
           
        if(lives<=0)
        {
            FindObjectOfType<levelcontrol>().Loseconditionhandler();
        }
        

    }
  
}

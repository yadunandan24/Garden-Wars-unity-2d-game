using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class currencydisplay : MonoBehaviour
{
    [SerializeField] float base_currency = 1000;
    float currency=0f;
    Text curr_text;

    // Start is called before the first frame update
    void Start()
    {
        currency = base_currency - (player_prefs_controller.Getdifficulty()*200);   //to reduce currency on difficulty
        curr_text = GetComponent<Text>();
        Update_display();
    }

    private void Update_display()
    {
        curr_text.text =currency.ToString();
    }


    public void Add_currency(int amt)
    {
        currency += amt;
        Update_display();
    }

    public bool Do_we_have_enough_stars(int amt)
    {
        return currency > amt;
    }

    public void Spend_currency(int amt)
    {
        
        if(currency>=amt)
        {
            currency -= amt;
            Update_display();
            
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

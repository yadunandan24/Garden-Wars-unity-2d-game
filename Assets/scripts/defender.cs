using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defender : MonoBehaviour
{
    [SerializeField] int cost = 100;

    public void Add_currency_of_defender_script(int amt)
    {
        FindObjectOfType<currencydisplay>().Add_currency(amt);
    }

    public int Get_currency_cost()
    {
        return cost;
    }
}

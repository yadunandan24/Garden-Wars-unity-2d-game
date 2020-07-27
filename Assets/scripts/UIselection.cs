using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIselection : MonoBehaviour
{
    [SerializeField] defender defender_prefab;
    // Start is called before the first frame update
    void Start()
    {
        Setdefendercostlabel();
    }

    private void Setdefendercostlabel()
    {
        Text costtext = GetComponentInChildren<Text>();
        costtext.text = defender_prefab.Get_currency_cost().ToString();
    }

    public void OnMouseDown()
    {
        var ui = FindObjectsOfType<UIselection>();
        foreach(UIselection u in ui)
        {
            u.GetComponent<SpriteRenderer>().color = new Color32(72, 70, 70, 255);
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<defenderspawners>().Set_selected_defender(defender_prefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

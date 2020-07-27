using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class defenderspawners : MonoBehaviour
{
    defender def;

    GameObject parent_defender;
    const string PARENT_DEFENDER_NAME = "Parent defender";
    private void Start()
    {
        Create_parent_defender();
    }

    private void Create_parent_defender()
    {
        parent_defender = GameObject.Find(PARENT_DEFENDER_NAME);//finds gameobject by name
        if(!parent_defender)
        {
            parent_defender = new GameObject(PARENT_DEFENDER_NAME);
        }
    }
    public void OnMouseDown()
    {
        Attempt_to_place_defender(Click_square());
    }

    public void Set_selected_defender(defender selected_defender)
    {
        def = selected_defender;
    }

    public void Attempt_to_place_defender(Vector2 gridpos)
    {
        var curr_disp = FindObjectOfType<currencydisplay>();

        int def_cost = def.Get_currency_cost();

        //check for currency
        if(curr_disp.Do_we_have_enough_stars(def_cost))
        {
            curr_disp.Spend_currency(def_cost);
            Spawn_defender(gridpos);
            
        }
    }


    public Vector2 Click_square()
    {
        Vector2 click_pos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Debug.Log(click_pos);
        Vector2 world_pos = Camera.main.ScreenToWorldPoint(click_pos);
        Vector2 grid_pos = Get_grid_pos(world_pos);
        return grid_pos;
    }

    private Vector2 Get_grid_pos(Vector2 world_pos)
    {
        float newx = Mathf.RoundToInt(world_pos.x);
        float newy = Mathf.RoundToInt(world_pos.y);

        return new Vector2(newx, newy);
    }
    public void Spawn_defender(Vector2 grid_pos)
    {
        defender new_def = Instantiate(def, grid_pos, Quaternion.identity) as defender;

        new_def.transform.parent = parent_defender.transform;
    }
}

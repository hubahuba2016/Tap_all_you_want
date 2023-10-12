using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubberDuckyClickLvl2 : MonoBehaviour
{
    public RulesLvl2 rules_script;
    void OnMouseDown()
    {
        if(rules_script.property_string== "tap all the rubber ducky" || rules_script.property_string == "tap all except stop sign" || rules_script.property_string == "tap all except fish")
        {
            rules_script.score = rules_script.score + 1;
            Destroy(gameObject);
        }
        else
        {
            rules_script.game_over = true;
        }
        Debug.Log("duck is clicked");
        Debug.Log("string is " + rules_script.property_string);
    }
    void Start()
    {
        rules_script = GameObject.Find("World").GetComponent<RulesLvl2>();
    }
}

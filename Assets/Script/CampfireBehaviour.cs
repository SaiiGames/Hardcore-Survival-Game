using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampfireBehaviour : MonoBehaviour
{
    public GameObject campfireIndicator;
    public BackpackBehaviour backpack;
    public LifeSystem lifeSystem;
    public HelpPopover help;
    private void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Player")){return;}
        
        campfireIndicator.SetActive(true);

    }

    private void OnTriggerExit(Collider other)
    {
        if(!other.CompareTag("Player")){return;}
        
        campfireIndicator.SetActive(false);    
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            if (backpack.heatAmount > 1)
            {
                lifeSystem.UpdateHeat(backpack.heatAmount);
                backpack.heatAmount = 0;
            }
            else
            {
                help.Cast("你的所有燃料都会转换成热量",4f);
            }
            
        }
    }
}

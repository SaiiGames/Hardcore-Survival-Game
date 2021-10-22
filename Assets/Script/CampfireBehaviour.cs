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
            if (backpack.heatAmount > 25)
            {
                lifeSystem.UpdateHeat(backpack.heatAmount);
                backpack.heatAmount = 0;
            }
            else
            {
                help.Cast("请记住：燃料需高于1/4容量",4f);
            }
            
        }
    }
}

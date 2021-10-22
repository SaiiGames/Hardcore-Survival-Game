using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableItemBehaviour : MonoBehaviour
{
    private const float maxF=100, minF=0;
    public CollectableItem item;
    public TextMesh textMesh;
    [SerializeField] private GameObject CollectableIndicator;
    [SerializeField]private Image hungerIndicator, thirstIndicator, heatIndicator;
    private void Awake()
    {
        CollectableIndicator = GameObject.Find("CollectablePopover");
        textMesh = transform.GetChild(0).GetComponent<TextMesh>();
        textMesh.text = item.itemName;
        thirstIndicator = GameObject.Find("ItemThirstValue").GetComponent<Image>();
        hungerIndicator = GameObject.Find("ItemHungerValue").GetComponent<Image>();
        heatIndicator = GameObject.Find("ItemHeatValue").GetComponent<Image>();

    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Player")){return;}
        CollectableIndicator.SetActive(true);
        hungerIndicator.fillAmount = item.hunger*10 / maxF;
        thirstIndicator.fillAmount = item.thirst*10 / maxF;
        heatIndicator.fillAmount = item.heatAmount*10 / maxF;
        if (Input.GetKey(KeyCode.Q))
        {
            
            other.GetComponent<LifeSystem>().ConsumeItem(item.hunger,item.thirst);
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if(!other.CompareTag("Player")){return;}
        if (Input.GetKey(KeyCode.Q))
        {
            other.GetComponent<LifeSystem>().ConsumeItem(item.hunger,item.thirst);
            CollectableIndicator.SetActive(false);
            Destroy(gameObject);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            other.GetComponent<BackpackBehaviour>().FillHeat(item.heatAmount);
            CollectableIndicator.SetActive(false);
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(!other.CompareTag("Player")){return;}
        CollectableIndicator.SetActive(false);
    }
}

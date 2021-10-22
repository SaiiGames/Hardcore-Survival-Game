using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeSystem : MonoBehaviour
{
    public Image thirstUI, hungerUI;
    
    private const float maxF=100, minF=0;
    [SerializeField]private float thirst=98, hunger=98;

    [SerializeField] private float thirstIndex,hungetIndex;

    private void Start()
    {
        InvokeRepeating(nameof(UpdateAmount),0,0.5f);
    }

    private void Update()
    {
        
        UpdateUI();
    }

    private void UpdateUI()
    {
        thirstUI.fillAmount = thirst / maxF;
        hungerUI.fillAmount = hunger / maxF;
    }

    private void UpdateAmount()
    {
        thirst -= thirstIndex;
        hunger -= hungetIndex;
    }

    public void ConsumeItem(float _hunger , float _thirst)
    {
        hunger += _hunger;
        thirst += _thirst;
    }
    
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackpackBehaviour : MonoBehaviour
{
    public float heatAmount = 0;
    public Image heatIndicator;
    private const float maxF = 100;
    private void Update()
    {
        UpdateUI();
        
    }

    void UpdateUI()
    {
        heatIndicator.fillAmount = heatAmount / maxF;
    }
    
    public void FillHeat(float _heat)
    {
        heatAmount += _heat;
    }
    
}

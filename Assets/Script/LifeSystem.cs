using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class LifeSystem : MonoBehaviour
{
    public Image thirstUI, hungerUI,temperatureUI;
    
    private const float maxF=100, minF=0;
    [SerializeField]private float thirst=98, hunger=98, temperature = 100;

    [SerializeField] private float thirstIndex;
    [FormerlySerializedAs("hungetIndex")] [SerializeField] private float hungerIndex;
    [SerializeField] private float temperatureIndex;

    private void Awake()
    {
        thirstUI = GameObject.Find("thirst").GetComponent<Image>();
        hungerUI = GameObject.Find("hunger").GetComponent<Image>();
        temperatureUI = GameObject.Find("temperature").GetComponent<Image>();

    }

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
        temperatureUI.fillAmount = temperature / maxF;
    }

    private void UpdateAmount()
    {
        thirst = thirst > maxF ? maxF - 0.5f : thirst - thirstIndex;
        hunger = hunger > maxF ? maxF - 0.5f : hunger - hungerIndex;
        temperature = temperature > maxF ? maxF - 0.5f : temperature - temperatureIndex;
    }

    public void ConsumeItem(float _hunger , float _thirst)
    {
        hunger += _hunger;
        thirst += _thirst;
    }

    public void UpdateHeat(float _heat)
    {
        temperature += _heat;
    }
    
}

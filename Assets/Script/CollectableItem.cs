using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(menuName = "SO/CollectableObject")]

public class CollectableItem : ScriptableObject
{
    public String itemName;
    public float hunger;
    public float thirst;
    public float heatAmount;
}

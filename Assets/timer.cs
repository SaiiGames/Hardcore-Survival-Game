using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    private Text text;

    private float timerNum = 0;
    // Start is called before the first frame update
    private void Awake()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timerNum += Time.deltaTime;
        text.text = timerNum.ToString("#0.0");
    }
}

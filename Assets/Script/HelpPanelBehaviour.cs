using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpPanelBehaviour : MonoBehaviour
{
    private bool isOpen = false;
    [SerializeField]private float cd = 0;
    [SerializeField]private GameObject helpPanel;

    private void Awake()
    {
        helpPanel = GameObject.Find("HelpPanel");
    }

    private void Update()
    {
        cd -= Time.deltaTime;
        if (Input.GetKey(KeyCode.P) && !isOpen && cd<=0)
        {
            helpPanel.transform.GetChild(0).gameObject.SetActive(true);
            isOpen = true;
            cd = 1;
        }else if (Input.GetKey(KeyCode.P) && isOpen && cd<=0)
        {
            helpPanel.transform.GetChild(0).gameObject.SetActive(false);
            isOpen = false;
            cd = 1;
        }
    }
    
    
}

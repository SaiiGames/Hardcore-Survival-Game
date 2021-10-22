using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    public HelpPopover help;
    private bool Reloading = false;
    public void onLowLife()
    {
        help.Cast("你的生命体征过低...",4f);
        StartReload();
    }

    void StartReload()
    {
        if (!Reloading)
        {
            Reloading = true;
            StartCoroutine(Reload());
        }
    }
    IEnumerator Reload()
    {
        Reloading = true;
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(0);
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.F12))
        {
            help.Cast("再试一次！",2f);
            StartReload();
        }
    }
    
    
}

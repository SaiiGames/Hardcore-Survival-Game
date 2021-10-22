using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpPopover : MonoBehaviour
{
    private GameObject child;
    private Text text;
    private void Awake()
    {
        child = transform.GetChild(0).gameObject;
        text = child.transform.GetChild(1).GetComponent<Text>();
    }

    private void Start()
    {
        StartCoroutine(Show("按[P]打开帮助 按[F12]重置游戏",8f));
    }

    public void Cast(string _content,float _time)
    {
        StopCoroutine(Show(_content,_time));
        StartCoroutine(Show(_content,_time));
    }

    private IEnumerator Show(string _content,float _time)
    {
        child.SetActive(true);
        text.text = _content;
        yield return new WaitForSeconds(_time);
        child.SetActive(false);
    }
    
    
}

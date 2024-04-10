using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Comer : State
{
    
    [SerializeField]
    int index = 0;
    void Start()
    {
        RandeArray();
        LoadComponent();
    }
    
    public override void LoadComponent()
    {
        base.LoadComponent();
    }
    public override void Execute()
    {
        if (FrameRate > arrayTime[index])
        {
            FrameRate = 0;
            index++;
            if (index == arrayTime.Length)
                RandeArray();
            index = index % arrayTime.Length;

            
        }
        FrameRate += Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        Execute();
    }
}

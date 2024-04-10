using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Comer : State
{
    float FrameRate;
    [SerializeField]
    float[] arrayTime = new float[10];
    [SerializeField]
    int index = 0;
    void Start()
    {
        RandeArray();
        LoadComponent();
    }
    void RandeArray()
    {
        for (int i = 0; i < arrayTime.Length; i++)
        {
            arrayTime[i] = UnityEngine.Random.Range(4, 10);
        }
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

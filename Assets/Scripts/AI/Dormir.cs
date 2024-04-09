using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Dormir : State
{
    float FrameRate;
    [SerializeField]
    float[] arrayTime = new float[10];
    [SerializeField]
    int index = 0;
    public int Timesleep = 8;
    void Start()
    {
        LoadComponent();
    }
    public override void LoadComponent()
    {
        base.LoadComponent();
    }
    void RandeArray()
    {
        for (int i = 0; i < arrayTime.Length; i++)
        {
            arrayTime[i] = UnityEngine.Random.Range(4, 10);
        }
    }
    public override void Enter()
    {

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

            Timesleep--;
            if (Timesleep == 0)
                m_MachineState.NextState(TypeState.Jugar);

        }
        FrameRate += Time.deltaTime;
    }
    public override void Exit()
    {
        Timesleep = 8;
    }
    // Update is called once per frame
    void Update()
    {
        Execute();
    }
}
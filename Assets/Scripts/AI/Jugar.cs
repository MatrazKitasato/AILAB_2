using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugar : State
{
    
    
    public VisionSensor _sensor { get; private set; }
    void Start()
    {
        RandeArray();
        LoadComponent();
    }
    public override void LoadComponent()
    {
        base.LoadComponent();
        _sensor = GetComponent<VisionSensor>();
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

            m_health.hunger = Mathf.Clamp(m_health.hunger - UnityEngine.Random.Range(0, 50),0, 100);
            if (m_health.hunger == 0)
                m_MachineState.NextState(TypeState.Comer);
            m_health.sleep = Mathf.Clamp(m_health.sleep - UnityEngine.Random.Range(0, 50), 0, 100);
            if (m_health.sleep == 0)
                m_MachineState.NextState(TypeState.Dormir);
            return;
        }
        FrameRate += Time.deltaTime;
        if(_sensor.EnemyView != null)
        {
            m_MachineState.NextState(TypeState.Seguir);
            if(m_MachineState.CurrentState is Seguir)
            {
                ((Seguir)m_MachineState.CurrentState).target = _sensor.EnemyView.transform;

            }
            return;
        }
    }
    // Update is called once per frame
    void Update()
    {
        Execute();
    }
}

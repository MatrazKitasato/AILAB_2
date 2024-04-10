using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguir : State
{
    public Transform target;
    public int Timesleep = 8;
    StreeringBehavior _steeringBehavior;
    void Start()
    {
        RandeArray();
        LoadComponent();
    }
    public override void LoadComponent()
    {
        base.LoadComponent();
        _steeringBehavior = GetComponent<StreeringBehavior>();
    }
    public override void Enter()
    {
        FrameRate = 0;
    }
    public override void Execute()
    {
        if(FrameRate > arrayTime[index])
        {
            FrameRate = 0;
            index++;
            if (index == arrayTime.Length)
                RandeArray();
            index = index % arrayTime.Length;

            m_health.sleep = Mathf.Clamp(m_health.sleep + UnityEngine.Random.Range(2, 20), 0, 100);
            if (m_health.sleep == 100)
                m_MachineState.NextState(TypeState.Dormir);
        }
        FrameRate += Time.deltaTime;
        if (target != null)
            _steeringBehavior.ArriveNavigatorMesh(target.position);
        else
            m_MachineState.NextState(TypeState.Jugar);
    }
    // Update is called once per frame
    void Update()
    {
        Execute();
    }
}

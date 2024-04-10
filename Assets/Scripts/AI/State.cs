using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum TypeState { Comer,Jugar,Banno,Dormir,Seguir}
public class State : MonoBehaviour
{
    public TypeState type;
    public MachineState m_MachineState;
    protected Health m_health;
    protected float FrameRate;
    protected int index;
    [SerializeField] protected float[] arrayTime;
    [SerializeField] protected int time;

    public void RandeArray()
    {
        for (int i = 0; i < arrayTime.Length; i++)
        {
            arrayTime[i] = UnityEngine.Random.Range(4, 10);
        }
    }
    public virtual void LoadComponent()
    {
        m_MachineState = GetComponent<MachineState>();
    }
    public virtual void Enter()
    {

    }
    public virtual void Execute()
    {

    }
    public virtual void Exit()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using BehaviorDesigner.Runtime.Tasks;
[TaskCategory("IA SC/Node Base")]

public class ActionNode : Action
{
    protected AICharacterVehicle _AICharacterVehicle;
    protected AICharacterAction _AICharacterAction;
    //protected UnitSC UnitSC;
    public override void OnStart()
    {
        _AICharacterVehicle = GetComponent<AICharacterVehicle>();
        if(_AICharacterVehicle == null)
        {
            Debug.LogWarning("Not load component AICharacterVehicle");
        }
        _AICharacterAction = GetComponent<AICharacterAction>();
        if (_AICharacterAction == null)
        {
            Debug.LogWarning("Not load component AICharacterAction");
        }
        if (_AICharacterVehicle != null)
        {
            //UnitSC = this._AICharacterVehicle.Health._Unity;
        }
        else
        {
            if (_AICharacterAction != null)
            {
                //UnitSC = this._AICharacterAction.Health._Unity;
            }
        }
        base.OnStart();
    }
}

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
    public UnitGame UnitGame;
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
            UnitGame = this._AICharacterVehicle.Health._UnitGame;
        }
        else
        {
            if (_AICharacterAction != null)
            {
                UnitGame = this._AICharacterAction.Health._UnitGame;
            }
        }
        base.OnStart();
    }
}

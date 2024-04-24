using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;

[TaskCategory("IA SC/Node Attack")]
public class ActionFire : ActionNodeActions
{
    public override void OnStart()
    {
        base.OnStart();
    }
    public override TaskStatus OnUpdate()
    {
        /*if (_AICharacterAction.Health.IsDead)
        {
            return TaskStatus.Failure;
        }*/
        SwitchFirePlay();
        return TaskStatus.Success;
    }
    void SwitchFirePlay()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using BehaviorDesigner.Runtime;

[RequireComponent(typeof(BehaviorTree))]
public class AICharacterControl : MonoBehaviour
{
    //protected ThirdPersonCharacterAnimatorBase character;
    protected VisionSensor _AIEye;
    public Health Health;

    public virtual void LoadComponent()
    {
        Health = GetComponent<Health>();
        _AIEye = GetComponent<VisionSensor>();
    }
}

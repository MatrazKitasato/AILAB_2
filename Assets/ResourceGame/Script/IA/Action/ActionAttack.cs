using UnityEngine;
using System.Collections;
using BehaviorDesigner.Runtime.Tasks;
namespace BloodSun
{
    public class ActionAttack : ActionNode
    {
        public float distanceEvadeMin;
        public override void OnStart()
        {
            //_AIMonoBehaviour = GetComponent<AIMonoBehaviour>();
        }
        public override TaskStatus OnUpdate()
        {
            /*if (_AIMonoBehaviour.HealthIA.isDead)
                return TaskStatus.Success;

            float distance = _AIMonoBehaviour.DistanceEnemy;

            if (distance <= distanceEvadeMin)
            {
                _AIMonoBehaviour.Attack();
                return TaskStatus.Success;
            }

            _AIMonoBehaviour.MoveDefenderAttack();*/
            return TaskStatus.Success;
        }


    }
}
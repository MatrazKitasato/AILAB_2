using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StreeringBehavior : MonoBehaviour
{

    public float radius;
    public float speed;
    public float speedMax;
    private NavMeshAgent agent;
    public Transform player;
    public float range = 10.0f;
    public float radiusSphere = 1.0f;
    public Color colorgizmos;
    public void Arrive(Vector3 target)
    {
        Vector3 direction = target - transform.position;
        float d = direction.magnitude;
        if(d < radius)
        {
            speed = Mathf.Clamp(d/radius, 0, radius);
        }
        else
        {
            speed = Mathf.Lerp(speed, speedMax, Time.deltaTime * 5f);
        }
        transform.rotation = Quaternion.LookRotation(direction);
        transform.position += transform.forward * Time.deltaTime * speed;
    }
    public void ArriveNavigatorMesh(Vector3 target)
    {
        agent.SetDestination(target);
    }

    public void Evade()
    {

    }
        
    bool RandomPoint(Vector3 center, float range, out Vector3 result)
    {
        for(int i = 0; i < 30; i++)
        {
            Vector3 randomPoint = center + Random.insideUnitSphere * range;
            NavMeshHit hit;
            if(NavMesh.SamplePosition(randomPoint, out hit, 1.0f, NavMesh.AllAreas))
            {
                result = hit.position;
                return true;
            }
        }
        result = Vector3.zero;
        return false;
    }
    public void WanderNavigatorMesh(Vector3 target)
    {
        if (agent == null)
            return;
        ArriveNavigatorMesh(target);
        if(agent.remainingDistance < agent.stoppingDistance)
        {
            //RandomPoint(,range, )
        }
        
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        ArriveNavigatorMesh(player.position);
        Debug.Log(agent.remainingDistance);
        Debug.Log(agent.stoppingDistance);
    }
    
}

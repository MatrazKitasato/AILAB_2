using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreeringBehavior : MonoBehaviour
{

    public float radius;
    public float speed;
    public float speedMax;
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
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}

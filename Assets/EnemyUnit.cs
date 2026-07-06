using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyUnit : MonoBehaviour
{
    public float Speed;
    public float MaxHealth;
    public float CurrentHealth;
    public Transform Waypoint;
    public NavMeshAgent NavMeshAg;

    public void Awake()
    {
        NavMeshAg = GetComponent<NavMeshAgent>();
        NavMeshAg.speed = Speed;
        NavMeshAg.SetDestination(Waypoint.position);
        MaxHealth = CurrentHealth;
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

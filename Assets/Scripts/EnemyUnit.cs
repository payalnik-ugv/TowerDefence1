using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyUnit : MonoBehaviour
{
    public float Speed;
    public float MaxHealth;
    public float CurrentHealth;
    public float Damage;
    public Transform Waypoint;
    public NavMeshAgent NavMeshAg;

    //public void Awake()
    //{
    //    NavMeshAg = GetComponent<NavMeshAgent>();
    //    NavMeshAg.speed = Speed;
    //    NavMeshAg.SetDestination(Waypoint.position);
    //    MaxHealth = CurrentHealth;
    //}

    // Start is called before the first frame update
    void Start()
    {
        NavMeshAg = GetComponent<NavMeshAgent>();
        NavMeshAg.speed = Speed;
        NavMeshAg.SetDestination(Waypoint.position);
        MaxHealth = CurrentHealth;
        Debug.Log("I go on");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FinishWall")) //if (other.CompareTag("FinishWall"))
        {
            Debug.Log("Получил урон");
            Map map = other.gameObject.GetComponentInParent<Map>();
            map.castle.TakeDamage(Damage); // Deal 100 damage to the castle
            Destroy(gameObject);           // Destroy the enemy unit
        }
    }

}

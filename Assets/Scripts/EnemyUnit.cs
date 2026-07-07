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
        Debug.Log("Я пошел");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Коллизия");
        if (other.gameObject.CompareTag("FinishWall"))
        {
            //Castle castle = collision.gameObject.GetComponent<Castle>();
            //if (castle != null)
            //{
                //castle.TakeDamage(10f); // Deal 10 damage to the castle
            Destroy(gameObject); // Destroy the enemy unit
            Map map = other.gameObject.GetComponentInParent<Map>();
            map.castle.TakeDamage(Damage); // Deal 10 damage to the castle
            Debug.Log("Получил урон");
            //}
        }
    }

}

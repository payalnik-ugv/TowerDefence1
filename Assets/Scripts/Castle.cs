using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castle : MonoBehaviour
{
    public float MaxHealth = 100f;
    public float CurrentHealth;

    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damage)
    {
        CurrentHealth -= damage;
        if (CurrentHealth <= 0)
        {
            CastleDeath();
        }
    }

    void CastleDeath()
    {
        // Handle castle destruction logic here
        Debug.Log("Castle has been destroyed!");
    }
}

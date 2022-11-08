using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostEnemy : MonoBehaviour
{
    public int health = 100; 
    
    public void TakeDamage (int damage)
    {
        health -= damage;
        
        if(health <= 0)//Check to see if the enemies health has been reduced to zero or less
        {
           Death(); //Run Death method
        }
    }

    void Death()
    {
        // Add Sound & Particle Effects
        Destroy(gameObject);// Destorys the enemy
    }
}

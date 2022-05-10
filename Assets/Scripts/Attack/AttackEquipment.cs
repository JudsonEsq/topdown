using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Abstract class representing all possible attacks that an entity may have and use
public abstract class AttackEquipment : MonoBehaviour
{
    // Generates an attack of the variety that this equipment can perform.
    public abstract void attack(Quaternion direction);

    // Stores the class containing the stats of this attack's user.
    public StatController entityStats;
    
    // The projectile that this attack will produce.
    public GameObject projectilePrefab;


    // Update is called once per frame
    void Update()
    {
        
    }
}

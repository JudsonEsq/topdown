using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float ProjectileSpeed = 20;

    void Awake()
    {
        Rigidbody rb = this.gameObject.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * ProjectileSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EssencePickup : MonoBehaviour
{
    // How much essence the player gets for picking this up.
    [SerializeField] private int essence;

    // This pickup's box collider
    private BoxCollider boxCol;
    
    public EssencePickup(int value)
    {
        essence = value;
    }

    void Start()
    {
        boxCol = gameObject.GetComponent<BoxCollider>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            other.GetComponent<StatController>().ess += this.essence;
            Destroy(gameObject);
        }
    }

}

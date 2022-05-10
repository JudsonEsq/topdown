using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed;

    // Multiplier for the dex stat's effect on moveSpeed
    public float dexStatMod;

    private StatController playerStats;

    // How much essence is required before it can be converted into permanent stats.
    public int essThresh;

    // Start is called before the first frame update
    void Start()
    {
        playerStats = this.gameObject.GetComponent<StatController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            this.GetComponentInParent<Rigidbody>().AddForce(new Vector3(0f, 0f, moveSpeed + playerStats.dex * dexStatMod));
        }   
        
        if(Input.GetKey(KeyCode.S))
        {
            this.GetComponentInParent<Rigidbody>().AddForce(new Vector3(0f, 0f, -moveSpeed - playerStats.dex * dexStatMod));
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.GetComponentInParent<Rigidbody>().AddForce(new Vector3(moveSpeed + playerStats.dex * dexStatMod, 0f, 0f));
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.GetComponentInParent<Rigidbody>().AddForce(new Vector3(-moveSpeed - playerStats.dex * dexStatMod, 0f, 0f));
        }

        if(Input.GetKeyDown(KeyCode.E) && playerStats.ess > essThresh)
        {
            playerStats.dex++;
            playerStats.ess -= essThresh;
        }    
    }
}

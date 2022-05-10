using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatController : MonoBehaviour
{

    // Controls defensive stats like max health and flat damage reduction,
    // as well as "stability" like friction and knockback experienced.
    // Generally is the least interesting stat, so will likely need to
    // be most effective when modified by items.
    public float def;

    // Controls offensive capabilities. Raw damage mostly, and very 
    // appealing to players. Likely needs fewer items directly modulated
    // by it.
    public float str;

    // Controls movement speed, fire rate, shot speed.
    public float dex;
    
    // Universal currency used to up stats at certain thresholds
    public float ess;

    // Start is called before the first frame update
    void Start()
    {
        ess = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}

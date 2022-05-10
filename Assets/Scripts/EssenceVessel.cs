using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Essence vessels are consumable items players can find that collect essence.
// Essence is gained by killing enemies.
// Filling a vessel allows it to be activated, permanently increasing stats.
// Various options will have varying effects: massive but temporary gains, affecting
// a random stat, affecting only your lowest or highest stat, triggering combat effects
// when used, etc.

// Maybe these will be reusable, or maybe they will disappear on one use. Worth testing 
// how they feel. It may be frustrating to be faced with a choice of dumping your current
// gathered essence to switch focus, but that may also be an interesting cost/benefit
// assessment to make.
public  class EssenceVessel : MonoBehaviour
{

    private StatController playerStats;

    // Enum of all possible vessel options
    public enum VESSELS
    {
        Str_basic,
        Dex_basic,
        Def_basic
    }

    public VESSELS currentVessel;
    // The essence capacity of your current vessel
    private int currEssLim;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerStats.ess >= currEssLim)
        {
            switch(currentVessel)
            {
                case VESSELS.Str_basic:
                    break;
                case VESSELS.Dex_basic:
                    playerStats.dex += 3;
                    break;
                // The default case is the basic defense vessel 
                default:
                    playerStats.def += 3;
                    break;
            }
        }
    }

    public void Awake()
    {
        playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<StatController>();
        currentVessel = VESSELS.Str_basic;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurstWeapon : AttackEquipment
{
    // Minimum time allowed between shots, in milliseconds
    public double fireDelay = 750;
    // True if the fire delay has passed since the last shot
    private bool ready;
    // Total time passed since last shot
    private double shotTimeElapsed;
    // Number of shots already fired this burst.
    private int shotsFired;

    // Start is called before the first frame update
    void Start()
    {
        ready = true;
    }


    public override void attack(Quaternion direction)
    {
        shotsFired = 0;

        IEnumerator burst()
        {
            while (shotsFired < 3)
            {
                Instantiate(projectilePrefab, this.gameObject.transform.position, direction);
                ready = false;
                shotTimeElapsed = 0;

                shotsFired++;
                // Something to create a gap between shots here?
                yield return new WaitForSeconds(0.2f);
            }
        }

        StartCoroutine(burst());
    }

    // Update is called once per frame
    void Update()
    {
        if (!ready)
        {
            shotTimeElapsed += Time.deltaTime;

            if (shotTimeElapsed >= fireDelay / 1000)
            {
                ready = true;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                attack(Quaternion.Euler(0f, 270f, 0f));
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                attack(Quaternion.Euler(0f, 0f, 0f));
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                attack(Quaternion.Euler(0f, 90f, 0f));
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                attack(Quaternion.Euler(0f, 180f, 0f));
            }
        }
    }
}

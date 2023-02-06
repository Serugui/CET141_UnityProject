using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    [SerializeField]
    float hitPoints = 100f;



    void Hit(float rawDamage)
    {
        hitPoints -= rawDamage;
        Debug.Log("OUCH: " + hitPoints.ToString());

        if(hitPoints <= 0)
        {
            //TODO: Game Over
            Debug.Log("GAME OVER - YOU DIED");
        }
    }
}
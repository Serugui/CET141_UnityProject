using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    [SerializeField] float maxHitPoints = 100f;
    float hitPoints;

    public Slider healthSlider;

    private void Start()
    {
        hitPoints = maxHitPoints;
    }


    public void Hit(float rawDamage)
    {
        hitPoints -= rawDamage;
        SetHealthSlider();
        Debug.Log("OUCH: " + hitPoints.ToString());

        if(hitPoints <= 0)
        {
            //TODO: Game Over
            Debug.Log("GAME OVER - YOU DIED");
        }
    }

    void SetHealthSlider()
    {
        if(healthSlider != null)
        {
            healthSlider.value = NormalisedHitPoints();
        }
    }

    float NormalisedHitPoints()
    {
        return hitPoints / maxHitPoints;
    }
}

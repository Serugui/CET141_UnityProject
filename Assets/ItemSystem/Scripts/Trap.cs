using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField]
    Transform playerTransform;
    [SerializeField]
    float rawDamage = 10f;
    [SerializeField]
    float delayTimer = 2f;
    float tick;
    [SerializeField]
    string itemName;
    [SerializeField]
    [TextArea(4, 16)]
    string description;
    bool damageReady = true;

    void Start()
    {
        tick = delayTimer;
    }

    void Update()
    {

    }


    void OnTriggerStay(Collider collider)
    {
        float damage = rawDamage * Time.deltaTime;

        collider.SendMessageUpwards("Hit", damage, SendMessageOptions.DontRequireReceiver);

    }

    //bool IsDamageReady()
    //{
    //    if (tick < delayTimer)
    //    {
    //        tick += Time.deltaTime;
    //        return false;
    //    }

    //    return true;
    //}
}

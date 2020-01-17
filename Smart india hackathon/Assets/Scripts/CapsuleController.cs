using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleController : MonoBehaviour
{
    public GameObject pickupEffect;

    // Start is called before the first frame update
    void OnTriggerEnter()
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        // Only one thing can collide with the capsule - the FPS Controller i.e. our player
        GameEvents.current.CapsuleFound();

        Destroy(gameObject);
    }

    
}

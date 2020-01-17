using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoorController : MonoBehaviour
{
    void Start()
    {
        GameEvents.current.onCapsuleFound += OnCapsuleFound;
    }

    private void OnCapsuleFound()
    {
        gameObject.SetActive(false);
    }
}

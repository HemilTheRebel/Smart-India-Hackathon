using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireOnPlayerEntered : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        Debug.Log("On trigger enter");
        GameEvents.current.PlayerEnteredMaze();
    }
}

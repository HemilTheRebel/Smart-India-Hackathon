using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.onPlayerEnteredMaze += OnPlayerEnteredMaze;
    }

    // Update is called once per frame
    private void OnPlayerEnteredMaze()
    {
        Debug.Log("OnPlayerEnteredMaze");

        gameObject.GetComponent<MeshRenderer>().enabled = true;
        gameObject.GetComponent<BoxCollider>().enabled = true;

        GameEvents.current.onPlayerEnteredMaze -= OnPlayerEnteredMaze;
    }
}

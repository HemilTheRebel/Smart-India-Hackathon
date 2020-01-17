using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    private void Awake()
    {
        current = this;
    }

    // On Capsule Found
    public event Action onCapsuleFound;
    public void CapsuleFound()
    {
        onCapsuleFound?.Invoke();
    }

    // On Player Entered Maze
    public event Action onPlayerEnteredMaze;
    public void PlayerEnteredMaze()
    {
        onPlayerEnteredMaze?.Invoke();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Base class for any puzzle
public class Puzzle : MonoBehaviour
{
    public UnlockObjects unlockObjects;
    public void UnLockPuzzle()
    {
        unlockObjects.Unlock?.Invoke();
    }
}

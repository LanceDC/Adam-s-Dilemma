using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//Class that holds events for when a puzzle is complete
public class UnlockObjects : MonoBehaviour
{
    //Functions get added in the inspector, allowing anyone to add events that are called when a puzzle is completed
    public UnityEvent Unlock;
}

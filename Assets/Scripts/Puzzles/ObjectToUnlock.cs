using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Class used for when you need to put an object in a place to unlock a puzzle, e.g. key into lock
public class ObjectToUnlock : Puzzle
{
    public GameObject requiredObject;
    public Transform requiredItemLocation;

    public virtual void PlaceItem(GameObject obj)
    {
        if (obj == requiredObject)
        {
            UnLockPuzzle();

            //Put the  object that is used to unlock the puzzle in the right place
            obj.transform.position = requiredItemLocation.position;
            obj.transform.rotation = requiredItemLocation.rotation;
            obj.transform.parent = requiredItemLocation;

            obj.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class marbleInventory : MonoBehaviour
{
    public int NumberOfMarbles { get; private set; }
    public int NumberOfMarblesElla { get; private set; }



    public UnityEvent<marbleInventory> OnMarbleCollected;

    public void MarbleCollected()
    {
        NumberOfMarbles++;
        OnMarbleCollected.Invoke(this);
    }

    public void MarblesCollectedella()
    {
        NumberOfMarblesElla++;
        OnMarbleCollected.Invoke(this);
    }
}

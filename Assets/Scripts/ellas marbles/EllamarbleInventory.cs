using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EllamarbleInventory : MonoBehaviour
{
    public int NumberOfMarbles { get; private set; }
    public int NumberOfMarblesElla { get; private set; }



    public UnityEvent<EllamarbleInventory> OnMarbleCollected;


    public void MarbleCollectedElla()
    {
        NumberOfMarblesElla++;
        OnMarbleCollected.Invoke(this);
    }
}
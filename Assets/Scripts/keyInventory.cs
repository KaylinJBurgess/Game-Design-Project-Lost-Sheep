using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class keyInventory : MonoBehaviour
{
    public int NumberOfkeys { get; private set; }
    public int NumberOfkeysElla { get; private set; }



    public UnityEvent<keyInventory> OnKeysCollected;

    public void KeysCollected()
    {
        NumberOfkeys++;
        OnKeysCollected.Invoke(this);
    }

    public void KeysCollectedella()
    {
        NumberOfkeysElla++;
        OnKeysCollected.Invoke(this);
    }
}

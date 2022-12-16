using UnityEngine;
using UnityEngine.Events;

public class keyInventoryElla : MonoBehaviour
{
    public int NumberOfkeysElla { get; private set; }
    // public int NumberOfkeysElla { get; private set; }



    public UnityEvent<keyInventoryElla> OnKeysCollectedElla;
    //Stores the number of keys collected
    public void KeysCollectedElla()
    {
        NumberOfkeysElla++;
        OnKeysCollectedElla.Invoke(this);
    }

 
 
}

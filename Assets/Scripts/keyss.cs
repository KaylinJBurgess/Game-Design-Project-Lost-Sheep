using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyss : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        keyInventory keyInventory = other.GetComponent<keyInventory>();
        
        if (keyInventory != null)
        {
            keyInventory.KeysCollected();
            gameObject.SetActive(false);
        }
        
    }
}

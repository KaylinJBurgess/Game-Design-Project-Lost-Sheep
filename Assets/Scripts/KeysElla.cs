    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeysElla : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        keyInventoryElla keyInventoryElla = other.GetComponent<keyInventoryElla>();

        if (keyInventoryElla != null)
        {
            keyInventoryElla.KeysCollectedElla();
            gameObject.SetActive(false);
        }

    }
}

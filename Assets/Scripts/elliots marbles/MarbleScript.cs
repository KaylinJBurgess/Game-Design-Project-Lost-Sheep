using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        marbleInventory marbleInventory = other.GetComponent<marbleInventory>();

        if (marbleInventory != null)
        {
            marbleInventory.MarbleCollected();
            gameObject.SetActive(false);
        }

    }
}

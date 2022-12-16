using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EllaMarbleScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        EllamarbleInventory EllamarbleInventory = other.GetComponent<EllamarbleInventory>();

        if (EllamarbleInventory != null)
        {
            EllamarbleInventory.MarbleCollectedElla();
            gameObject.SetActive(false);
        }

    }
}

// I need marbles

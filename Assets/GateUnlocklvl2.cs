using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateUnlocklvl2 : MonoBehaviour
{
    public GameObject gateObject;
    private int elliotsTotal;
    private int ellasTotal;

    private void Start()
    {

    }
    // Update is called once per frame
   public void Update()
    {
        if (gateObject.tag == "Gate1" && elliotsTotal == 3 && ellasTotal == 3 && Input.GetKey("o"))
        {
            gateObject.GetComponent<Animator>().Play("GateOpen");
        }
        else
        {

        }
        Debug.Log("This is elliots total: " + elliotsTotal);
    }

    public void ElliotsInventroylvl2(keyInventory keyInventory)
    {
        elliotsTotal = keyInventory.NumberOfkeys;
    }
    public void EllasInventorylvl2(keyInventoryElla keyInventoryElla)
    {
        ellasTotal = keyInventoryElla.NumberOfkeysElla;
    }
}


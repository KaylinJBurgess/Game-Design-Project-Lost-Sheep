using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateUnlocked : MonoBehaviour
{
    public GameObject gateObject1;
    public GameObject gateObject2;
    public GameObject gateObject3;
    private int elliotsTotal;
    private int ellasTotal;

    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if(gameObject.tag == "Gate1")
        {
            if (elliotsTotal == 3 && ellasTotal == 3 && Input.GetKey("o"))
            {
                gateObject1.GetComponent<Animator>().Play("GateOpen");
                
                gateObject3.GetComponent<Animator>().Play("GateOpen");
            }
        }
        
            if (elliotsTotal == 6 && ellasTotal == 6 && Input.GetKey("o"))
            {
                gateObject2.GetComponent<Animator>().Play("GateOpen");
            }
        if (elliotsTotal == 9 && ellasTotal == 9 && Input.GetKey("o"))
        {
            gateObject3.GetComponent<Animator>().Play("GateOpen");
        }


        //Debug.Log("This is elliots total: " + elliotsTotal);
    }

    public void ElliotsInventroy(keyInventory keyInventory)
    {
        elliotsTotal = keyInventory.NumberOfkeys;
    }
    public void EllasInventory(keyInventoryElla keyInventoryElla)
    {
        ellasTotal = keyInventoryElla.NumberOfkeysElla;
    }
}

